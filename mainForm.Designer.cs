namespace QoLUtility
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.lblEFT = new System.Windows.Forms.Label();
            this.lblSPTAKI = new System.Windows.Forms.Label();
            this.mainMenu = new System.Windows.Forms.Panel();
            this.flagPanel = new System.Windows.Forms.Panel();
            this.botsPanel = new System.Windows.Forms.Panel();
            this.titleName = new System.Windows.Forms.Label();
            this.tradersPanel = new System.Windows.Forms.Panel();
            this.raidsPanel = new System.Windows.Forms.Panel();
            this.playerPanel = new System.Windows.Forms.Panel();
            this.playerList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.qolPanel = new System.Windows.Forms.Panel();
            this.welcomePanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.infoComponentQoL = new System.Windows.Forms.Label();
            this.infoComponentBots = new System.Windows.Forms.Label();
            this.spacerPanel = new System.Windows.Forms.Panel();
            this.infoComponentRaids = new System.Windows.Forms.Label();
            this.infoComponentTraders = new System.Windows.Forms.Label();
            this.infoComponentPlayer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.playerHealthPanel = new System.Windows.Forms.GroupBox();
            this.playerInventoryPanel = new System.Windows.Forms.GroupBox();
            this.playerHealthHead = new System.Windows.Forms.TextBox();
            this.playerHealthChest = new System.Windows.Forms.TextBox();
            this.playerHealthTorso = new System.Windows.Forms.TextBox();
            this.playerHealthLeftArm = new System.Windows.Forms.TextBox();
            this.playerHealthRightArm = new System.Windows.Forms.TextBox();
            this.playerHealthRightLeg = new System.Windows.Forms.TextBox();
            this.playerHealthLeftLeg = new System.Windows.Forms.TextBox();
            this.flagPanel.SuspendLayout();
            this.playerPanel.SuspendLayout();
            this.welcomePanel.SuspendLayout();
            this.playerHealthPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEFT
            // 
            this.lblEFT.AutoSize = true;
            this.lblEFT.ForeColor = System.Drawing.Color.Silver;
            this.lblEFT.Location = new System.Drawing.Point(10, 613);
            this.lblEFT.Name = "lblEFT";
            this.lblEFT.Size = new System.Drawing.Size(143, 18);
            this.lblEFT.TabIndex = 0;
            this.lblEFT.Text = "Escape From Tarkov";
            // 
            // lblSPTAKI
            // 
            this.lblSPTAKI.AutoSize = true;
            this.lblSPTAKI.Font = new System.Drawing.Font("Bahnschrift", 30F);
            this.lblSPTAKI.Location = new System.Drawing.Point(3, 631);
            this.lblSPTAKI.Name = "lblSPTAKI";
            this.lblSPTAKI.Size = new System.Drawing.Size(172, 48);
            this.lblSPTAKI.TabIndex = 1;
            this.lblSPTAKI.Text = "SPT-AKI";
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.mainMenu.Location = new System.Drawing.Point(10, 153);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(300, 400);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.mainMenu_Paint);
            // 
            // flagPanel
            // 
            this.flagPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flagPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.flagPanel.Controls.Add(this.mainMenu);
            this.flagPanel.Controls.Add(this.lblSPTAKI);
            this.flagPanel.Controls.Add(this.lblEFT);
            this.flagPanel.Location = new System.Drawing.Point(30, -1);
            this.flagPanel.Name = "flagPanel";
            this.flagPanel.Size = new System.Drawing.Size(320, 706);
            this.flagPanel.TabIndex = 2;
            // 
            // botsPanel
            // 
            this.botsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.botsPanel.Location = new System.Drawing.Point(419, 105);
            this.botsPanel.Name = "botsPanel";
            this.botsPanel.Size = new System.Drawing.Size(683, 494);
            this.botsPanel.TabIndex = 3;
            // 
            // titleName
            // 
            this.titleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleName.BackColor = System.Drawing.Color.Transparent;
            this.titleName.Font = new System.Drawing.Font("Bahnschrift", 20F);
            this.titleName.Location = new System.Drawing.Point(413, 32);
            this.titleName.Name = "titleName";
            this.titleName.Size = new System.Drawing.Size(689, 36);
            this.titleName.TabIndex = 2;
            this.titleName.Text = "Information";
            this.titleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tradersPanel
            // 
            this.tradersPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tradersPanel.Location = new System.Drawing.Point(419, 105);
            this.tradersPanel.Name = "tradersPanel";
            this.tradersPanel.Size = new System.Drawing.Size(683, 494);
            this.tradersPanel.TabIndex = 4;
            // 
            // raidsPanel
            // 
            this.raidsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.raidsPanel.Location = new System.Drawing.Point(419, 105);
            this.raidsPanel.Name = "raidsPanel";
            this.raidsPanel.Size = new System.Drawing.Size(683, 494);
            this.raidsPanel.TabIndex = 5;
            // 
            // playerPanel
            // 
            this.playerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.playerPanel.Controls.Add(this.playerInventoryPanel);
            this.playerPanel.Controls.Add(this.playerHealthPanel);
            this.playerPanel.Controls.Add(this.playerList);
            this.playerPanel.Controls.Add(this.label2);
            this.playerPanel.Location = new System.Drawing.Point(419, 105);
            this.playerPanel.Name = "playerPanel";
            this.playerPanel.Size = new System.Drawing.Size(683, 494);
            this.playerPanel.TabIndex = 6;
            // 
            // playerList
            // 
            this.playerList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.playerList.FormattingEnabled = true;
            this.playerList.Location = new System.Drawing.Point(239, 13);
            this.playerList.Name = "playerList";
            this.playerList.Size = new System.Drawing.Size(319, 26);
            this.playerList.TabIndex = 1;
            this.playerList.SelectedIndexChanged += new System.EventHandler(this.playerList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select profile:";
            // 
            // qolPanel
            // 
            this.qolPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.qolPanel.Location = new System.Drawing.Point(419, 105);
            this.qolPanel.Name = "qolPanel";
            this.qolPanel.Size = new System.Drawing.Size(683, 494);
            this.qolPanel.TabIndex = 7;
            // 
            // welcomePanel
            // 
            this.welcomePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.welcomePanel.Controls.Add(this.label11);
            this.welcomePanel.Controls.Add(this.label10);
            this.welcomePanel.Controls.Add(this.label9);
            this.welcomePanel.Controls.Add(this.label8);
            this.welcomePanel.Controls.Add(this.label7);
            this.welcomePanel.Controls.Add(this.infoComponentQoL);
            this.welcomePanel.Controls.Add(this.infoComponentBots);
            this.welcomePanel.Controls.Add(this.spacerPanel);
            this.welcomePanel.Controls.Add(this.infoComponentRaids);
            this.welcomePanel.Controls.Add(this.infoComponentTraders);
            this.welcomePanel.Controls.Add(this.infoComponentPlayer);
            this.welcomePanel.Controls.Add(this.label1);
            this.welcomePanel.Location = new System.Drawing.Point(419, 105);
            this.welcomePanel.Name = "welcomePanel";
            this.welcomePanel.Size = new System.Drawing.Size(683, 494);
            this.welcomePanel.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label11.Location = new System.Drawing.Point(253, 288);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(272, 19);
            this.label11.TabIndex = 11;
            this.label11.Text = "Miscellaneous quality of life settings";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label10.Location = new System.Drawing.Point(253, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 19);
            this.label10.TabIndex = 10;
            this.label10.Text = "AI settings and behavior";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label9.Location = new System.Drawing.Point(253, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 19);
            this.label9.TabIndex = 9;
            this.label9.Text = "Raid settings and extracts";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label8.Location = new System.Drawing.Point(253, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(225, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "Trader settings and insurance";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label7.Location = new System.Drawing.Point(253, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(324, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Player related information and profile stats";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // infoComponentQoL
            // 
            this.infoComponentQoL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoComponentQoL.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Underline);
            this.infoComponentQoL.Location = new System.Drawing.Point(3, 288);
            this.infoComponentQoL.Name = "infoComponentQoL";
            this.infoComponentQoL.Size = new System.Drawing.Size(218, 19);
            this.infoComponentQoL.TabIndex = 6;
            this.infoComponentQoL.Text = "QoL";
            this.infoComponentQoL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.infoComponentQoL.Click += new System.EventHandler(this.infoComponentQoL_Click);
            // 
            // infoComponentBots
            // 
            this.infoComponentBots.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoComponentBots.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Underline);
            this.infoComponentBots.Location = new System.Drawing.Point(3, 257);
            this.infoComponentBots.Name = "infoComponentBots";
            this.infoComponentBots.Size = new System.Drawing.Size(218, 19);
            this.infoComponentBots.TabIndex = 5;
            this.infoComponentBots.Text = "Bots";
            this.infoComponentBots.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.infoComponentBots.Click += new System.EventHandler(this.infoComponentBots_Click);
            // 
            // spacerPanel
            // 
            this.spacerPanel.Location = new System.Drawing.Point(237, 119);
            this.spacerPanel.Name = "spacerPanel";
            this.spacerPanel.Size = new System.Drawing.Size(10, 372);
            this.spacerPanel.TabIndex = 4;
            this.spacerPanel.Visible = false;
            // 
            // infoComponentRaids
            // 
            this.infoComponentRaids.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoComponentRaids.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Underline);
            this.infoComponentRaids.Location = new System.Drawing.Point(3, 226);
            this.infoComponentRaids.Name = "infoComponentRaids";
            this.infoComponentRaids.Size = new System.Drawing.Size(218, 19);
            this.infoComponentRaids.TabIndex = 3;
            this.infoComponentRaids.Text = "Raids";
            this.infoComponentRaids.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.infoComponentRaids.Click += new System.EventHandler(this.infoComponentRaids_Click);
            // 
            // infoComponentTraders
            // 
            this.infoComponentTraders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoComponentTraders.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Underline);
            this.infoComponentTraders.Location = new System.Drawing.Point(3, 195);
            this.infoComponentTraders.Name = "infoComponentTraders";
            this.infoComponentTraders.Size = new System.Drawing.Size(218, 19);
            this.infoComponentTraders.TabIndex = 2;
            this.infoComponentTraders.Text = "Traders";
            this.infoComponentTraders.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.infoComponentTraders.Click += new System.EventHandler(this.infoComponentTraders_Click);
            // 
            // infoComponentPlayer
            // 
            this.infoComponentPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoComponentPlayer.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Underline);
            this.infoComponentPlayer.Location = new System.Drawing.Point(3, 164);
            this.infoComponentPlayer.Name = "infoComponentPlayer";
            this.infoComponentPlayer.Size = new System.Drawing.Size(218, 19);
            this.infoComponentPlayer.TabIndex = 1;
            this.infoComponentPlayer.Text = "Player";
            this.infoComponentPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.infoComponentPlayer.Click += new System.EventHandler(this.infoComponentPlayer_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 12F);
            this.label1.Location = new System.Drawing.Point(3, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(677, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Raccoon\'s Essentials!\r\n\r\nHere you\'ll find the things that I find most " +
    "essential.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerHealthPanel
            // 
            this.playerHealthPanel.Controls.Add(this.playerHealthRightLeg);
            this.playerHealthPanel.Controls.Add(this.playerHealthLeftLeg);
            this.playerHealthPanel.Controls.Add(this.playerHealthRightArm);
            this.playerHealthPanel.Controls.Add(this.playerHealthLeftArm);
            this.playerHealthPanel.Controls.Add(this.playerHealthTorso);
            this.playerHealthPanel.Controls.Add(this.playerHealthChest);
            this.playerHealthPanel.Controls.Add(this.playerHealthHead);
            this.playerHealthPanel.ForeColor = System.Drawing.Color.LightGray;
            this.playerHealthPanel.Location = new System.Drawing.Point(34, 61);
            this.playerHealthPanel.Name = "playerHealthPanel";
            this.playerHealthPanel.Size = new System.Drawing.Size(300, 300);
            this.playerHealthPanel.TabIndex = 2;
            this.playerHealthPanel.TabStop = false;
            this.playerHealthPanel.Text = "Player health";
            this.playerHealthPanel.Visible = false;
            // 
            // playerInventoryPanel
            // 
            this.playerInventoryPanel.ForeColor = System.Drawing.Color.LightGray;
            this.playerInventoryPanel.Location = new System.Drawing.Point(349, 61);
            this.playerInventoryPanel.Name = "playerInventoryPanel";
            this.playerInventoryPanel.Size = new System.Drawing.Size(300, 300);
            this.playerInventoryPanel.TabIndex = 3;
            this.playerInventoryPanel.TabStop = false;
            this.playerInventoryPanel.Text = "Player inventory";
            this.playerInventoryPanel.Visible = false;
            // 
            // playerHealthHead
            // 
            this.playerHealthHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.playerHealthHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerHealthHead.Font = new System.Drawing.Font("Bahnschrift Light", 14F);
            this.playerHealthHead.ForeColor = System.Drawing.Color.LightGray;
            this.playerHealthHead.Location = new System.Drawing.Point(115, 40);
            this.playerHealthHead.Name = "playerHealthHead";
            this.playerHealthHead.Size = new System.Drawing.Size(70, 30);
            this.playerHealthHead.TabIndex = 0;
            this.playerHealthHead.Text = "0";
            this.playerHealthHead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // playerHealthChest
            // 
            this.playerHealthChest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.playerHealthChest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerHealthChest.Font = new System.Drawing.Font("Bahnschrift Light", 14F);
            this.playerHealthChest.ForeColor = System.Drawing.Color.LightGray;
            this.playerHealthChest.Location = new System.Drawing.Point(115, 132);
            this.playerHealthChest.Name = "playerHealthChest";
            this.playerHealthChest.Size = new System.Drawing.Size(70, 30);
            this.playerHealthChest.TabIndex = 1;
            this.playerHealthChest.Text = "0";
            this.playerHealthChest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // playerHealthTorso
            // 
            this.playerHealthTorso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.playerHealthTorso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerHealthTorso.Font = new System.Drawing.Font("Bahnschrift Light", 14F);
            this.playerHealthTorso.ForeColor = System.Drawing.Color.LightGray;
            this.playerHealthTorso.Location = new System.Drawing.Point(115, 168);
            this.playerHealthTorso.Name = "playerHealthTorso";
            this.playerHealthTorso.Size = new System.Drawing.Size(70, 30);
            this.playerHealthTorso.TabIndex = 2;
            this.playerHealthTorso.Text = "0";
            this.playerHealthTorso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // playerHealthLeftArm
            // 
            this.playerHealthLeftArm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.playerHealthLeftArm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerHealthLeftArm.Font = new System.Drawing.Font("Bahnschrift Light", 14F);
            this.playerHealthLeftArm.ForeColor = System.Drawing.Color.LightGray;
            this.playerHealthLeftArm.Location = new System.Drawing.Point(30, 90);
            this.playerHealthLeftArm.Name = "playerHealthLeftArm";
            this.playerHealthLeftArm.Size = new System.Drawing.Size(70, 30);
            this.playerHealthLeftArm.TabIndex = 3;
            this.playerHealthLeftArm.Text = "0";
            this.playerHealthLeftArm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // playerHealthRightArm
            // 
            this.playerHealthRightArm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.playerHealthRightArm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerHealthRightArm.Font = new System.Drawing.Font("Bahnschrift Light", 14F);
            this.playerHealthRightArm.ForeColor = System.Drawing.Color.LightGray;
            this.playerHealthRightArm.Location = new System.Drawing.Point(200, 90);
            this.playerHealthRightArm.Name = "playerHealthRightArm";
            this.playerHealthRightArm.Size = new System.Drawing.Size(70, 30);
            this.playerHealthRightArm.TabIndex = 4;
            this.playerHealthRightArm.Text = "0";
            this.playerHealthRightArm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // playerHealthRightLeg
            // 
            this.playerHealthRightLeg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.playerHealthRightLeg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerHealthRightLeg.Font = new System.Drawing.Font("Bahnschrift Light", 14F);
            this.playerHealthRightLeg.ForeColor = System.Drawing.Color.LightGray;
            this.playerHealthRightLeg.Location = new System.Drawing.Point(200, 231);
            this.playerHealthRightLeg.Name = "playerHealthRightLeg";
            this.playerHealthRightLeg.Size = new System.Drawing.Size(70, 30);
            this.playerHealthRightLeg.TabIndex = 6;
            this.playerHealthRightLeg.Text = "0";
            this.playerHealthRightLeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // playerHealthLeftLeg
            // 
            this.playerHealthLeftLeg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.playerHealthLeftLeg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerHealthLeftLeg.Font = new System.Drawing.Font("Bahnschrift Light", 14F);
            this.playerHealthLeftLeg.ForeColor = System.Drawing.Color.LightGray;
            this.playerHealthLeftLeg.Location = new System.Drawing.Point(30, 231);
            this.playerHealthLeftLeg.Name = "playerHealthLeftLeg";
            this.playerHealthLeftLeg.Size = new System.Drawing.Size(70, 30);
            this.playerHealthLeftLeg.TabIndex = 5;
            this.playerHealthLeftLeg.Text = "0";
            this.playerHealthLeftLeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1157, 705);
            this.Controls.Add(this.titleName);
            this.Controls.Add(this.flagPanel);
            this.Controls.Add(this.playerPanel);
            this.Controls.Add(this.raidsPanel);
            this.Controls.Add(this.tradersPanel);
            this.Controls.Add(this.welcomePanel);
            this.Controls.Add(this.botsPanel);
            this.Controls.Add(this.qolPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Bahnschrift Light", 11F);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devraccoon\'s QoL";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.Resize += new System.EventHandler(this.mainForm_Resize);
            this.flagPanel.ResumeLayout(false);
            this.flagPanel.PerformLayout();
            this.playerPanel.ResumeLayout(false);
            this.playerPanel.PerformLayout();
            this.welcomePanel.ResumeLayout(false);
            this.welcomePanel.PerformLayout();
            this.playerHealthPanel.ResumeLayout(false);
            this.playerHealthPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblEFT;
        private System.Windows.Forms.Label lblSPTAKI;
        private System.Windows.Forms.Panel mainMenu;
        private System.Windows.Forms.Panel flagPanel;
        private System.Windows.Forms.Panel botsPanel;
        private System.Windows.Forms.Label titleName;
        private System.Windows.Forms.Panel tradersPanel;
        private System.Windows.Forms.Panel raidsPanel;
        private System.Windows.Forms.Panel playerPanel;
        private System.Windows.Forms.Panel qolPanel;
        private System.Windows.Forms.Panel welcomePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label infoComponentRaids;
        private System.Windows.Forms.Label infoComponentTraders;
        private System.Windows.Forms.Label infoComponentPlayer;
        private System.Windows.Forms.Panel spacerPanel;
        private System.Windows.Forms.Label infoComponentBots;
        private System.Windows.Forms.Label infoComponentQoL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox playerList;
        private System.Windows.Forms.GroupBox playerHealthPanel;
        private System.Windows.Forms.GroupBox playerInventoryPanel;
        private System.Windows.Forms.TextBox playerHealthHead;
        private System.Windows.Forms.TextBox playerHealthRightArm;
        private System.Windows.Forms.TextBox playerHealthLeftArm;
        private System.Windows.Forms.TextBox playerHealthTorso;
        private System.Windows.Forms.TextBox playerHealthChest;
        private System.Windows.Forms.TextBox playerHealthRightLeg;
        private System.Windows.Forms.TextBox playerHealthLeftLeg;
    }
}

