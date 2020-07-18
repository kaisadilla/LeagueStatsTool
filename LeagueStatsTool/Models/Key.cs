using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueStatsTool.Models {
    public class Key {
        public string key;
        public KeyType keyType;
        public long creationDate; //in epoch seconds

        public Key(string key, KeyType keyType) {
            this.key = key;
            this.keyType = keyType;

            int epoch = (int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;
            creationDate = epoch;
        }

        [JsonIgnore]
        public string Timestamp {
            get {
                DateTime date = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(creationDate);
                return date.ToLocalTime().ToString("dddd, MMMM d, yyyy - HH:mm");
            }
        }
    }

    public enum KeyType {
        Development, Personal, Production
    }
}
