using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueStatsTool.Models {
    public class Match {
        public string lane;
        public long gameId;
        public int champion;
        public string platformId;
        public long timestamp;
        public int queue;
        public string role;
        public int season;
    }
}
