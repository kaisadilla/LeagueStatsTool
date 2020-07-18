using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueStatsTool.Models {
    public class Player {
        public int profileIconId;
        public string name;
        public string puuid;
        public long summonerLevel;
        public long revisionDate;
        public string id;
        public string accountId;

        public override string ToString() {
            return name;
        }
    }
}
