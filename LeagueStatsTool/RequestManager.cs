using Kaisa.Standard;
using LeagueStatsTool.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeagueStatsTool {
    public static class RequestManager {
        public static Key ApiKey { get; private set; }

        public static bool LoadApiKey() {
            Key k;
            string sJson;

            try {
                sJson = File.ReadAllText(FilePaths.API_KEY);
            }
            catch (FileNotFoundException) {
                return false;
            }

            if (string.IsNullOrEmpty(sJson)) {
                return false;
            }

            k = JsonConvert.DeserializeObject<Key>(sJson);

            Instant i = Instant.Now;
            long currentDate = i.EpochSeconds;

            //86,400 is a full day. A minute is removed to account for the amount of time it takes to paste the key.
            if (k.keyType == KeyType.Development && k.creationDate + 86340 < currentDate) {
                return false;
            }
            else {
                ApiKey = k;
                return true;
            }
        }

        public static void SaveApiKey(String key, KeyType type) {
            if (ApiKey != null && ApiKey.key == key) {
                return;
            }

            Key k = new Key(key, type);

            string sJson = JsonConvert.SerializeObject(k, Formatting.Indented);
            File.WriteAllText(FilePaths.API_KEY, sJson);
            LoadApiKey();
        }

        public static History GetPlayerHistory(string accountId, string server, int beginIndex, int endIndex) {
            string sJson;

            string reqhttp = $"https://{server}.api.riotgames.com/lol/match/v4/matchlists/by-account/{accountId}/" +
                $"?api_key={ApiKey.key}" +
                $"&beginIndex={beginIndex}" +
                $"&endIndex={endIndex}";

            using (WebClient wc = new WebClient()) {
                try {
                    sJson = wc.DownloadString(reqhttp);
                }
                catch (WebException ex) {
                    MessageBox.Show($"RIOT's Api returned an error: {ex.Response}", "Error");
                    return null;
                }
            }

            return JsonConvert.DeserializeObject<History>(sJson);
        }
    }
}
