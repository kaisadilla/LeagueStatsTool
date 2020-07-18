using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaisa.Standard {
    public class Instant {
        DateTime time;
        public Instant(int year, int month, int day, int hours = 0, int mins = 0, int secs = 0) {
            time = new DateTime(year, month, day, hours, mins, secs);
        }

        public Instant(DateTime time) {
            this.time = time;
        }

        public Instant(long epoch) {
            time = new DateTime(1970, 1, 1).AddSeconds(epoch);
        }

        public static Instant Now => new Instant(DateTime.UtcNow);
        public static Instant LocalNow => new Instant(DateTime.Now);

        public static Instant FromEpochSeconds(long epoch) {
            return new Instant(epoch);
        }

        public Instant ToLocalTime() {
            return new Instant(time.ToLocalTime());
        }

        public Instant ToUniversalTime() {
            return new Instant(time.ToUniversalTime());
        }

        public long EpochSeconds => (long)(time - new DateTime(1970, 1, 1)).TotalSeconds;

        public string ToString(string format) {
            return time.ToString(format);
        }
    }
}
