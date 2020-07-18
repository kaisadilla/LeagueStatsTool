using Kaisa.Standard;
using LeagueStatsTool.Models;
using System.Collections.Generic;
using System.IO;

namespace LeagueStatsTool {
    public partial class Main {
        private List<Player> loadedPlayers;

        private void LoadPlayerList() {
            Console.WriteLine($"Loading list of players for {Server}.");
            listBox_players.Items.Clear();
            textBox_searchPlayer.Text = "";
            loadedPlayers = DataManager.LoadPlayerList(Server);
            Console.WriteLine($"Players found: {loadedPlayers.Count}.");

            if (loadedPlayers != null) {
                foreach(var p in loadedPlayers) {
                    listBox_players.Items.Add(p);
                }
            }
        }

        /// <summary>
        /// Tries to load the key from the file. Returns true if it succeeds and the key is still valid, false otherwise.
        /// </summary>
        /// <returns></returns>
        private bool LoadApiKey() {
            if (RequestManager.LoadApiKey()) {
                textBox_apiKey.Text = RequestManager.ApiKey.key;
                SetEnabledApiKeyForm(false);
                return true;
            }
            else {
                SetEnabledApiKeyForm(true);
                return false;
            }
        }

        private void SetEnabledApiKeyForm(bool enabled) {
            textBox_apiKey.Enabled = enabled;
            comboBox_keyType.Enabled = enabled;
            button_saveKey.Enabled = enabled;

            if (RequestManager.ApiKey != null) {
                label_keyDate.Text = $"This key was saved on {RequestManager.ApiKey.Timestamp}.";
            }
        }

        private void UpdatePlayerHistory() {
            string accountId = ChosenPlayer.accountId;

            bool fileExists = File.Exists(FilePaths.PLAYER_HISTORY(accountId, Server));

            if (fileExists) {
                History savedHistory = DataManager.LoadPlayerHistory(accountId, Server);

                if (savedHistory.LastGameId == -1) {
                    Console.WriteLine($"Player {ChosenPlayer.name} has no history saved. A new one will be created.");
                }
                else {
                    Instant lastMatch = Instant.FromEpochSeconds(savedHistory.matches[0].timestamp / 1000);
                    Console.WriteLine($"Player {ChosenPlayer.name} has a history saved," +
                        $" with the last game played on {lastMatch.ToString("dddd, MMMM d, yyyy - HH:mm")}." +
                        $" Their history will now be updated.");
                }

                savedHistory = UpdateHistoryFromApi(savedHistory, ChosenPlayer, Server);
                DataManager.SavePlayerHistory(savedHistory, accountId, Server);
            }
            else {
                Console.WriteLine($"Player {ChosenPlayer.name} has no history saved. A new one will be created.");
                History history = GetFullHistoryFromApi(ChosenPlayer, Server);
                DataManager.SavePlayerHistory(history, accountId, Server);
            }
        }

        private History GetFullHistoryFromApi(Player player, string server) {
            string accountId = player.accountId;
            History fullHistory = new History(player.name);

            int beginIndex = 0, endIndex = 100;
            int matchesFound;

            do {
                Console.WriteLine($"Finding matches from {beginIndex} to {endIndex}");
                History currentLoop = RequestManager.GetPlayerHistory(accountId, server, beginIndex, endIndex);

                if (currentLoop == null) {
                    Console.WriteLine($"The server returned an error.");
                    break;
                }

                matchesFound = currentLoop.matches.Count;
                Console.WriteLine($"Matches found: {matchesFound}.");

                foreach (var m in currentLoop.matches) {
                    fullHistory.matches.Add(m);
                }

                beginIndex = endIndex;
                endIndex += 100;
            } while (matchesFound == 100);


            fullHistory.startIndex = 0;
            fullHistory.endIndex = fullHistory.totalGames = fullHistory.matches.Count;

            Console.WriteLine($"Total matches found: {fullHistory.endIndex}.");

            return fullHistory;
        }

        private History UpdateHistoryFromApi(History history, Player player, string server) {
            if (history.LastGameId == -1) {
                //return GetFullPlayerHistory(accountId, server);
            }

            string accountId = player.accountId;
            History fullHistory = new History(player.name);
            long lastGameId = history.LastGameId;

            int beginIndex = 0, endIndex = 100;
            int matchesFound;
            int addedMatches = 0;

            do {
                Console.WriteLine($"Finding matches from {beginIndex} to {endIndex}");
                History currentLoop = RequestManager.GetPlayerHistory(accountId, server, beginIndex, endIndex);

                if (currentLoop == null) {
                    Console.WriteLine($"The server returned an error.");
                    break; //goto EndLoop;
                }

                matchesFound = currentLoop.matches.Count;
                Console.WriteLine($"Matches found: {matchesFound}.");

                foreach (var m in currentLoop.matches) {
                    if (m.gameId != lastGameId) {
                        fullHistory.matches.Add(m);
                        addedMatches++;
                    }
                    else {
                        goto EndLoop;
                    }
                }

                beginIndex = endIndex;
                endIndex += 100;
            } while (matchesFound == 100);
            EndLoop:

            Console.WriteLine($"Total matches added: {addedMatches}.");

            fullHistory.matches.AddRange(history.matches);

            fullHistory.startIndex = 0;
            fullHistory.endIndex = fullHistory.totalGames = fullHistory.matches.Count;

            return fullHistory;
        }
    }
}
