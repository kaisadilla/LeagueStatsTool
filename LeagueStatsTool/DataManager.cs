using LeagueStatsTool.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueStatsTool {
    public static class DataManager {
        //private JsonSerializer json = new JsonSerializer() { Formatting = Formatting.Indented };

        public static List<Player> LoadPlayerList(string server) {
            string sJson = File.ReadAllText(FilePaths.PLAYER_KEYS(server));

            if (string.IsNullOrEmpty(sJson)) {
                return null;
            }
            else {
                return JsonConvert.DeserializeObject<List<Player>>(sJson);
            }
        }

        public static History LoadPlayerHistory(string accountId, string server) {
            string sJson = File.ReadAllText(FilePaths.PLAYER_HISTORY(accountId, server));

            if (string.IsNullOrEmpty(sJson)) {
                return null;
            }
            else {
                return JsonConvert.DeserializeObject<History>(sJson);
            }
        }

        public static void SavePlayerHistory(History history, string accountId, string server) {
            string sJson = JsonConvert.SerializeObject(history, Formatting.Indented);
            File.WriteAllText(FilePaths.PLAYER_HISTORY(accountId, server), sJson);
        }

    }
}
