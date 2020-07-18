using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeagueStatsTool {
    public static class Console {
        private static TextBox consoleTB;

        public static void SetOutput(TextBox tb) {
            consoleTB = tb;
        }

        public static void Write(object message) {
            consoleTB.AppendText(message.ToString());
        }

        public static void WriteLine(object message) {
            consoleTB.AppendText(message.ToString() + Environment.NewLine);
        }
    }
}
