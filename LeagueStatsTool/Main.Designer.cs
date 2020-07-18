namespace LeagueStatsTool {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_server = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox_players = new System.Windows.Forms.ListBox();
            this.textBox_searchPlayer = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_renewHistory = new System.Windows.Forms.Button();
            this.button_updateHistory = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_prTimeline = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox_keyType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_keyDate = new System.Windows.Forms.Label();
            this.button_editKey = new System.Windows.Forms.Button();
            this.button_loadKey = new System.Windows.Forms.Button();
            this.button_saveKey = new System.Windows.Forms.Button();
            this.textBox_apiKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_console = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_server);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.listBox_players);
            this.groupBox1.Controls.Add(this.textBox_searchPlayer);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 309);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player";
            // 
            // comboBox_server
            // 
            this.comboBox_server.FormattingEnabled = true;
            this.comboBox_server.Items.AddRange(new object[] {
            "BR",
            "EUNE",
            "EUW",
            "LAN",
            "LAS",
            "NA",
            "OCE",
            "RU",
            "TR",
            "JP",
            "KR",
            "PBE"});
            this.comboBox_server.Location = new System.Drawing.Point(137, 279);
            this.comboBox_server.Name = "comboBox_server";
            this.comboBox_server.Size = new System.Drawing.Size(63, 21);
            this.comboBox_server.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(41, 278);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBox_players
            // 
            this.listBox_players.FormattingEnabled = true;
            this.listBox_players.Location = new System.Drawing.Point(7, 47);
            this.listBox_players.Name = "listBox_players";
            this.listBox_players.Size = new System.Drawing.Size(194, 225);
            this.listBox_players.TabIndex = 1;
            // 
            // textBox_searchPlayer
            // 
            this.textBox_searchPlayer.Location = new System.Drawing.Point(7, 20);
            this.textBox_searchPlayer.Name = "textBox_searchPlayer";
            this.textBox_searchPlayer.Size = new System.Drawing.Size(158, 20);
            this.textBox_searchPlayer.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_renewHistory);
            this.groupBox2.Controls.Add(this.button_updateHistory);
            this.groupBox2.Location = new System.Drawing.Point(226, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(532, 170);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Get data from RIOT Api";
            // 
            // button_renewHistory
            // 
            this.button_renewHistory.Location = new System.Drawing.Point(158, 16);
            this.button_renewHistory.Name = "button_renewHistory";
            this.button_renewHistory.Size = new System.Drawing.Size(146, 23);
            this.button_renewHistory.TabIndex = 1;
            this.button_renewHistory.Text = "Renew match history";
            this.button_renewHistory.UseVisualStyleBackColor = true;
            this.button_renewHistory.Click += new System.EventHandler(this.button_renewHistory_Click);
            // 
            // button_updateHistory
            // 
            this.button_updateHistory.Location = new System.Drawing.Point(6, 16);
            this.button_updateHistory.Name = "button_updateHistory";
            this.button_updateHistory.Size = new System.Drawing.Size(146, 23);
            this.button_updateHistory.TabIndex = 0;
            this.button_updateHistory.Text = "Update match history";
            this.button_updateHistory.UseVisualStyleBackColor = true;
            this.button_updateHistory.Click += new System.EventHandler(this.button_updateHistory_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_prTimeline);
            this.groupBox3.Location = new System.Drawing.Point(226, 190);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(532, 131);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Manipulate data";
            // 
            // button_prTimeline
            // 
            this.button_prTimeline.Location = new System.Drawing.Point(7, 20);
            this.button_prTimeline.Name = "button_prTimeline";
            this.button_prTimeline.Size = new System.Drawing.Size(145, 23);
            this.button_prTimeline.TabIndex = 0;
            this.button_prTimeline.Text = "Get timeline";
            this.button_prTimeline.UseVisualStyleBackColor = true;
            this.button_prTimeline.Click += new System.EventHandler(this.button_prTimeline_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBox_keyType);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label_keyDate);
            this.groupBox4.Controls.Add(this.button_editKey);
            this.groupBox4.Controls.Add(this.button_loadKey);
            this.groupBox4.Controls.Add(this.button_saveKey);
            this.groupBox4.Controls.Add(this.textBox_apiKey);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(12, 327);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(568, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "API key";
            // 
            // comboBox_keyType
            // 
            this.comboBox_keyType.FormattingEnabled = true;
            this.comboBox_keyType.Items.AddRange(new object[] {
            "Development",
            "Personal",
            "Production"});
            this.comboBox_keyType.Location = new System.Drawing.Point(265, 48);
            this.comboBox_keyType.Name = "comboBox_keyType";
            this.comboBox_keyType.Size = new System.Drawing.Size(121, 21);
            this.comboBox_keyType.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Key type:";
            // 
            // label_keyDate
            // 
            this.label_keyDate.AutoSize = true;
            this.label_keyDate.Location = new System.Drawing.Point(42, 77);
            this.label_keyDate.Name = "label_keyDate";
            this.label_keyDate.Size = new System.Drawing.Size(132, 13);
            this.label_keyDate.TabIndex = 5;
            this.label_keyDate.Text = "No key is currently loaded.";
            // 
            // button_editKey
            // 
            this.button_editKey.Location = new System.Drawing.Point(126, 47);
            this.button_editKey.Name = "button_editKey";
            this.button_editKey.Size = new System.Drawing.Size(75, 23);
            this.button_editKey.TabIndex = 4;
            this.button_editKey.Text = "Edit key";
            this.button_editKey.UseVisualStyleBackColor = true;
            this.button_editKey.Click += new System.EventHandler(this.button_editKey_Click);
            // 
            // button_loadKey
            // 
            this.button_loadKey.Location = new System.Drawing.Point(42, 47);
            this.button_loadKey.Name = "button_loadKey";
            this.button_loadKey.Size = new System.Drawing.Size(75, 23);
            this.button_loadKey.TabIndex = 3;
            this.button_loadKey.Text = "Load key";
            this.button_loadKey.UseVisualStyleBackColor = true;
            this.button_loadKey.Click += new System.EventHandler(this.button_loadKey_Click);
            // 
            // button_saveKey
            // 
            this.button_saveKey.Location = new System.Drawing.Point(388, 19);
            this.button_saveKey.Name = "button_saveKey";
            this.button_saveKey.Size = new System.Drawing.Size(75, 22);
            this.button_saveKey.TabIndex = 2;
            this.button_saveKey.Text = "Save";
            this.button_saveKey.UseVisualStyleBackColor = true;
            this.button_saveKey.Click += new System.EventHandler(this.button_saveKey_Click);
            // 
            // textBox_apiKey
            // 
            this.textBox_apiKey.Location = new System.Drawing.Point(42, 20);
            this.textBox_apiKey.Name = "textBox_apiKey";
            this.textBox_apiKey.Size = new System.Drawing.Size(340, 20);
            this.textBox_apiKey.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Key:";
            // 
            // textBox_console
            // 
            this.textBox_console.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_console.Location = new System.Drawing.Point(12, 433);
            this.textBox_console.Multiline = true;
            this.textBox_console.Name = "textBox_console";
            this.textBox_console.ReadOnly = true;
            this.textBox_console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_console.Size = new System.Drawing.Size(1058, 169);
            this.textBox_console.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(75, 278);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Purge";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 614);
            this.Controls.Add(this.textBox_console);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_server;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox_players;
        private System.Windows.Forms.TextBox textBox_searchPlayer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_renewHistory;
        private System.Windows.Forms.Button button_updateHistory;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_prTimeline;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBox_keyType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_keyDate;
        private System.Windows.Forms.Button button_editKey;
        private System.Windows.Forms.Button button_loadKey;
        private System.Windows.Forms.Button button_saveKey;
        private System.Windows.Forms.TextBox textBox_apiKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_console;
        private System.Windows.Forms.Button button4;
    }
}

