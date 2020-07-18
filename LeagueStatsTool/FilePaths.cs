using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueStatsTool {
    public static class FilePaths {
        public static string API_KEY = $@".\saved_data\api_key.json";

        public static string PLAYER_KEYS(string server) {
            return $@".\saved_data\players-{server}.json";
        }

        public static string PLAYER_HISTORY(string accountId, string server) {
            return $@".\saved_data\match_history\{server}-{accountId}.json";
        }
    }
}
