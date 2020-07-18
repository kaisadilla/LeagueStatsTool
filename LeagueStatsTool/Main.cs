using LeagueStatsTool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeagueStatsTool {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
            Console.SetOutput(textBox_console);
            BuildGUI();
        }

        private void BuildGUI() {
            comboBox_server.SelectedIndex = 2;
            comboBox_keyType.SelectedIndex = 0;
            LoadPlayerList();
            LoadApiKey();

            //long creationDate = 1595025917; //in epoch seconds
            //DateTime date = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(creationDate);
            //Console.WriteLine(date.ToLocalTime().ToString("dddd, MMMM d, yyyy - HH:mm"));
        }

        private void button_editKey_Click(object sender, EventArgs e) {
            SetEnabledApiKeyForm(true);
        }

        private void button_loadKey_Click(object sender, EventArgs e) {
            bool succeed = LoadApiKey();
            if (!succeed) {
                MessageBox.Show("Saved key is missing or expired. Please introduce a new key.", "Error");
            }
        }

        private void button_saveKey_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(textBox_apiKey.Text)) {
                MessageBox.Show("Introduce a key to save it.");
            }
            else {
                string key = textBox_apiKey.Text;
                RequestManager.SaveApiKey(key, ChosenKeyType);
                SetEnabledApiKeyForm(false);
            }
        }

        private void button_updateHistory_Click(object sender, EventArgs e) {
            UpdatePlayerHistory();
        }

        private void button_renewHistory_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete the current history for {ChosenPlayer.name} and recreate it?",
                "Are you sure?",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes) {
                Console.WriteLine($"Deleting history from {ChosenPlayer} and downloading data from RIOT servers.");

                History history = GetFullHistoryFromApi(ChosenPlayer, Server);
                DataManager.SavePlayerHistory(history, ChosenPlayer.accountId, Server);
            }
        }

        private void button_prTimeline_Click(object sender, EventArgs e) {

        }
    }
}
