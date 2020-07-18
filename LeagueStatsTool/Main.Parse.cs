using LeagueStatsTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueStatsTool {
    /// <summary>
    /// This part of the class parses data input from controls.
    /// </summary>
    public partial class Main {

        //private string Server => comboBox_server.SelectedItem.ToString();
        private KeyType ChosenKeyType => (KeyType)comboBox_keyType.SelectedIndex;
        private Player ChosenPlayer => (Player)listBox_players.SelectedItem;

        private string Server {
            get {
                switch (comboBox_server.SelectedIndex) {
                    case 0:
                        return "br1";
                    case 1:
                        return "eun1";
                    case 2:
                        return "euw1";
                    case 3:
                        return "lan1";
                    case 4:
                        return "las1";
                    case 5:
                        return "na1";
                    case 6:
                        return "oc1";
                    case 7:
                        return "ru";
                    case 8:
                        return "tr1";
                    case 9:
                        return "jp1";
                    case 10:
                        return "kr";
                    case 11:
                        return "pbe1";
                    default:
                        return "euw1";
                }
            }
        }

    }
}
