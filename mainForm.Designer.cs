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
            this.panel1 = new System.Windows.Forms.Panel();
            this.botsPanel = new System.Windows.Forms.Panel();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleName = new System.Windows.Forms.Label();
            this.tradersPanel = new System.Windows.Forms.Panel();
            this.raidsPanel = new System.Windows.Forms.Panel();
            this.playerPanel = new System.Windows.Forms.Panel();
            this.qolPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.titlePanel.SuspendLayout();
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
            this.lblSPTAKI.Size = new System.Drawing.Size(266, 48);
            this.lblSPTAKI.TabIndex = 1;
            this.lblSPTAKI.Text = "SPT-AKI 3.5.5";
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.mainMenu);
            this.panel1.Controls.Add(this.lblSPTAKI);
            this.panel1.Controls.Add(this.lblEFT);
            this.panel1.Location = new System.Drawing.Point(30, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 706);
            this.panel1.TabIndex = 2;
            // 
            // botsPanel
            // 
            this.botsPanel.BackColor = System.Drawing.Color.Transparent;
            this.botsPanel.Location = new System.Drawing.Point(419, 105);
            this.botsPanel.Name = "botsPanel";
            this.botsPanel.Size = new System.Drawing.Size(683, 494);
            this.botsPanel.TabIndex = 3;
            this.botsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.botsPanel_Paint);
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.Transparent;
            this.titlePanel.Controls.Add(this.titleName);
            this.titlePanel.Location = new System.Drawing.Point(419, 42);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(218, 48);
            this.titlePanel.TabIndex = 4;
            this.titlePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.titlePanel_Paint);
            // 
            // titleName
            // 
            this.titleName.AutoSize = true;
            this.titleName.Font = new System.Drawing.Font("Bahnschrift", 22F);
            this.titleName.Location = new System.Drawing.Point(3, 4);
            this.titleName.Name = "titleName";
            this.titleName.Size = new System.Drawing.Size(198, 36);
            this.titleName.TabIndex = 2;
            this.titleName.Text = "SPT-AKI 3.5.5";
            // 
            // tradersPanel
            // 
            this.tradersPanel.BackColor = System.Drawing.Color.Transparent;
            this.tradersPanel.Location = new System.Drawing.Point(419, 105);
            this.tradersPanel.Name = "tradersPanel";
            this.tradersPanel.Size = new System.Drawing.Size(683, 494);
            this.tradersPanel.TabIndex = 4;
            // 
            // raidsPanel
            // 
            this.raidsPanel.BackColor = System.Drawing.Color.Transparent;
            this.raidsPanel.Location = new System.Drawing.Point(419, 105);
            this.raidsPanel.Name = "raidsPanel";
            this.raidsPanel.Size = new System.Drawing.Size(683, 494);
            this.raidsPanel.TabIndex = 5;
            // 
            // playerPanel
            // 
            this.playerPanel.BackColor = System.Drawing.Color.Transparent;
            this.playerPanel.Location = new System.Drawing.Point(419, 105);
            this.playerPanel.Name = "playerPanel";
            this.playerPanel.Size = new System.Drawing.Size(683, 494);
            this.playerPanel.TabIndex = 6;
            // 
            // qolPanel
            // 
            this.qolPanel.BackColor = System.Drawing.Color.Transparent;
            this.qolPanel.Location = new System.Drawing.Point(419, 105);
            this.qolPanel.Name = "qolPanel";
            this.qolPanel.Size = new System.Drawing.Size(683, 494);
            this.qolPanel.TabIndex = 7;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1157, 705);
            this.Controls.Add(this.qolPanel);
            this.Controls.Add(this.playerPanel);
            this.Controls.Add(this.raidsPanel);
            this.Controls.Add(this.tradersPanel);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.botsPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 11F);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QoL Utility";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.Resize += new System.EventHandler(this.mainForm_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblEFT;
        private System.Windows.Forms.Label lblSPTAKI;
        private System.Windows.Forms.Panel mainMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel botsPanel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label titleName;
        private System.Windows.Forms.Panel tradersPanel;
        private System.Windows.Forms.Panel raidsPanel;
        private System.Windows.Forms.Panel playerPanel;
        private System.Windows.Forms.Panel qolPanel;
    }
}

