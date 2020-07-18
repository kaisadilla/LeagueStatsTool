using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueStatsTool.Models {
    public class History {
        public List<Match> matches = new List<Match>();
        public string summonerName;
        public int endIndex;
        public int startIndex;
        public int totalGames;

        public History(string summonerName) {
            this.summonerName = summonerName;
        }

        [JsonIgnore]
        public long LastGameId {
            get {
                return (matches.Count > 0) ? matches[0].gameId : -1;
            }
        }
    }
}
