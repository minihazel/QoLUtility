using QoLUtility.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace QoLUtility
{
    public partial class mainForm : Form
    {
        // public string currentDir = Environment.CurrentDirectory();
        public string currentDir = "C:\\SPT 3.5.5";

        /*         LIST SYSTEM         */
        int default_item_height = 35; // item height
        int default_item_loc_x = 1; // keep 1
        int default_item_loc_y = 16; // item location startpoint
        int default_item_spacer = 35; // spacer between item to item

        int default_item_height_title = 45; // title item height
        int default_item_spacer_title = 45; // spacer between title items

        public Color idleText = Color.LightGray;
        public Color idleColor = Color.FromArgb(255, 28, 28, 28);
        public Color hoverColor = Color.FromArgb(255, 32, 32, 32);
        public Color selectColor = Color.FromArgb(255, 35, 35, 35);
        public Color selectText = Color.DodgerBlue;
        public Color criticalText = Color.IndianRed;

        public Font idleFont = new Font("Bahnschrift Light", 11, FontStyle.Regular);
        public Font idleFontTitle = new Font("Bahnschrift Light", 15, FontStyle.Regular);
        public Font idleFontSpacer = new Font("Bahnschrift Light", 10, FontStyle.Regular);
        /*         LIST SYSTEM         */

        public string[] selectionMenu =
        {
            "TITLE: Raccoon's Essentials",
            "-",
            "Player",
            "Traders",
            "Raids",
            "Bots",
            "QoL",
            "Exit",
            "spacer",
            "Information",
        };

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            bool doDependenciesExist = checkDependencies();
            if (doDependenciesExist)
            {
                initializeSystem();
                this.BackgroundImage = new Bitmap(Resources.default_wp);
            }
            else
            {
                MessageBox.Show($"We could not detect one or more of the critical parts needed to function. Please ensure that you placed {this.Text} into your SPT folder.\n\nShutting down to avoid errors.", this.Text, MessageBoxButtons.OK);
                Application.Exit();
            }
        }

        public bool checkDependencies()
        {
            bool allExist = false;

            /*
            // - List all important directories & files to check;
            // - - Check if they exist;
            // - - - Verify
            */

            bool akiServerPath = File.Exists(Path.Combine(currentDir, "Aki.Server.exe"));
            bool akiLauncherPath = File.Exists(Path.Combine(currentDir, "Aki.Launcher.exe"));
            bool eftLaunchPath = File.Exists(Path.Combine(currentDir, "EscapeFromTarkov.exe"));
            bool EFTData = Directory.Exists(Path.Combine(currentDir, "EscapeFromTarkov_Data"));

            string[] akiDB_FullPath = { "Aki_Data", "Server", "database", "templates" };
            string fullPath = string.Join("\\", akiDB_FullPath);
            bool fullPathExists = Directory.Exists(Path.Combine(currentDir, fullPath));
            bool akiDatabase = File.Exists(Path.Combine(Path.Combine(currentDir, fullPath), "items.json"));

            if (akiServerPath && akiLauncherPath && eftLaunchPath && EFTData && fullPathExists && akiDatabase)
            {
                allExist = true;
            }

            return allExist;
        }

        public void initializeSystem()
        {
            drawObjects(this.Controls);
            clearUI(mainMenu);
            listSystem(selectionMenu, mainMenu);
            displayWatermark();
            welcomePanel.BringToFront();
        }

        public void drawObjects(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is Panel panel)
                {
                    if (panel.Name.ToLower() != "flagpanel")
                    {
                        // panel.BackColor = Color.Transparent;

                        /*
                        panel.Paint += (sender, e) =>
                        {
                            int radius = 25;
                            Graphics graphics = e.Graphics;
                            graphics.SmoothingMode = SmoothingMode.AntiAlias;
                            Rectangle rect = new Rectangle(0, 0, panel.Width - 1, panel.Height - 1);

                            GraphicsPath path = new GraphicsPath();
                            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                            path.CloseAllFigures();

                            using (Pen pen = new Pen(Color.White, 1))
                            {
                                graphics.DrawPath(pen, path);
                            }
                        };
                        */
                    }
                }
            }
        }

        public void displayWatermark()
        {
            if (mainMenu != null)
            {
                string akiData = Path.Combine(currentDir, "Aki_Data");
                string akiServer = Path.Combine(akiData, "Server");
                string akiConfigs = Path.Combine(akiServer, "configs");
                string akiConfig = Path.Combine(akiConfigs, "core.json");
                bool coreExists = File.Exists(akiConfig);

                if (coreExists)
                {
                    string content = File.ReadAllText(akiConfig);
                    JavaScriptSerializer coreJson = new JavaScriptSerializer();
                    var readCore = coreJson.Deserialize<Dictionary<string, object>>(content);

                    var akiVersion = (string)readCore["akiVersion"];
                    var akiName = (string)readCore["projectName"];
                    var tarkovVersion = (string)readCore["compatibleTarkovVersion"];
                    tarkovVersion = tarkovVersion.Remove(0, 2);

                    lblEFT.Text = $"Escape From Tarkov       ({tarkovVersion})";
                    lblSPTAKI.Text = $"{akiName} {akiVersion}";
                }
            }
        }

        private void clearUI(Panel control)
        {
            // server box
            for (int i = control.Controls.Count - 1; i >= 0; i--)
            {
                Label selected = control.Controls[i] as Label;
                if (selected != null)
                {
                    try
                    {
                        control.Controls.RemoveAt(i);
                        selected.Dispose();
                    }
                    catch (Exception err)
                    {
                        Debug.WriteLine($"ERROR: {err.ToString()}");
                        MessageBox.Show($"Oops! It seems like we received an error. If you're uncertain what it\'s about, please message the developer with a screenshot:\n\n{err.ToString()}", this.Text, MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void mainMenu_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = new Rectangle(0, 0, mainMenu.Width - 1, mainMenu.Height - 1);
            int radius = 13;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            using (Pen pen = new Pen(Color.White, 1))
            {
                graphics.DrawPath(pen, path);
            }
        }

        public void listSystem(string[] arr, Control area)
        {
            clearUI(mainMenu);
            for (int i = 0; i < arr.Length; i++)
            {
                Label lbl = new Label();
                string _item = arr[i].ToLower();

                if (_item.Contains("title:"))
                {
                    arr[i] = arr[i].Replace("TITLE: ", "");

                    lbl.Text = arr[i];

                    lbl.AutoSize = false;
                    lbl.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
                    lbl.TextAlign = ContentAlignment.MiddleLeft;
                    lbl.Size = new Size(area.Size.Width - 2, default_item_height_title);
                    lbl.Location = new Point(default_item_loc_x, default_item_loc_y + (i * default_item_spacer_title));
                    lbl.Font = idleFontTitle;
                    lbl.BackColor = Color.Transparent;
                    lbl.ForeColor = idleText;
                    lbl.Margin = new Padding(1, 1, 1, 1);
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    lbl.Visible = true;
                }
                else if (_item.Contains("spacer"))
                {
                    lbl.AutoSize = false;
                    lbl.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
                    lbl.TextAlign = ContentAlignment.MiddleLeft;
                    lbl.Size = new Size(area.Size.Width - 2, default_item_height);
                    lbl.Location = new Point(default_item_loc_x, default_item_loc_y + (i * default_item_spacer));
                    lbl.Font = idleFontTitle;
                    lbl.BackColor = Color.Transparent;
                    lbl.ForeColor = idleText;
                    lbl.Margin = new Padding(1, 1, 1, 1);
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    lbl.Visible = true;

                    lbl.Text = "";
                }
                else if (_item.Contains("-"))
                {
                    // lbl.Text = "——————————————";
                    lbl.Text = "════════════════════════════════════════════════";

                    lbl.AutoSize = false;
                    lbl.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
                    lbl.TextAlign = ContentAlignment.MiddleLeft;
                    lbl.Size = new Size(area.Size.Width - 2, default_item_height);
                    lbl.Location = new Point(default_item_loc_x, default_item_loc_y + (i * default_item_spacer));
                    lbl.Font = idleFontSpacer;
                    lbl.BackColor = Color.Transparent;
                    lbl.ForeColor = idleText;
                    lbl.Margin = new Padding(1, 1, 1, 1);
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    lbl.Visible = true;
                }
                else if (_item.Contains("exit"))
                {
                    lbl.Text = arr[i];

                    lbl.AutoSize = false;
                    lbl.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
                    lbl.TextAlign = ContentAlignment.MiddleLeft;
                    lbl.Size = new Size(area.Size.Width - 2, default_item_height);
                    lbl.Location = new Point(default_item_loc_x, default_item_loc_y + (i * default_item_spacer));
                    lbl.Font = idleFont;
                    lbl.BackColor = Color.Transparent;
                    lbl.ForeColor = criticalText;
                    lbl.Margin = new Padding(1, 1, 1, 1);
                    lbl.Cursor = Cursors.Hand;
                    lbl.MouseEnter += new EventHandler(lbl_MouseEnter);
                    lbl.MouseLeave += new EventHandler(lbl_MouseLeave);
                    lbl.MouseDown += new MouseEventHandler(lbl_MouseDown);
                    lbl.MouseUp += new MouseEventHandler(lbl_MouseUp);
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    lbl.Visible = true;
                }
                else
                {
                    lbl.Name = $"menuItem_{arr[i].ToLower()}";
                    lbl.Text = arr[i];

                    lbl.AutoSize = false;
                    lbl.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
                    lbl.TextAlign = ContentAlignment.MiddleLeft;
                    lbl.Size = new Size(area.Size.Width - 2, default_item_height);
                    lbl.Location = new Point(default_item_loc_x, default_item_loc_y + (i * default_item_spacer));
                    lbl.Font = idleFont;
                    lbl.BackColor = Color.Transparent;
                    lbl.ForeColor = idleText;
                    lbl.Margin = new Padding(1, 1, 1, 1);
                    lbl.Cursor = Cursors.Hand;
                    lbl.MouseEnter += new EventHandler(lbl_MouseEnter);
                    lbl.MouseLeave += new EventHandler(lbl_MouseLeave);
                    lbl.MouseDown += new MouseEventHandler(lbl_MouseDown);
                    lbl.MouseUp += new MouseEventHandler(lbl_MouseUp);
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    lbl.Visible = true;
                }

                area.Controls.Add(lbl);
            }
        }

        private void lbl_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;
            if (label.Text != "")
            {
                label.BackColor = hoverColor;
            }
        }

        private void lbl_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;
            if (label.Text != "")
            {
                label.BackColor = idleColor;
            }
        }

        private void lbl_MouseDown(object sender, EventArgs e)
        {
            System.Windows.Forms.Label lbl = (System.Windows.Forms.Label)sender;
            if (lbl.Text != "")
            {
                foreach (Control component in mainMenu.Controls)
                {
                    if (component is Label && component.Text != lbl.Text)
                    {
                        if (component.Text.ToLower().Contains("exit"))
                        {
                            component.BackColor = idleColor;
                            component.ForeColor = criticalText;
                        }
                        else
                        {
                            component.BackColor = idleColor;
                            component.ForeColor = idleText;
                        }
                    }
                }

                lbl.BackColor = hoverColor;
                lbl.ForeColor = selectText;

                if (!lbl.Text.Contains("utility") || !lbl.Text.Contains("spacer") || !lbl.Text.Contains("exit"))
                {
                    titleName.Text = lbl.Text;
                }

                switch (lbl.Text.ToLower())
                {
                    case "bots":
                        botsPanel.BringToFront();
                        break;
                    case "traders":
                        tradersPanel.BringToFront();
                        break;
                    case "raids":
                        raidsPanel.BringToFront();
                        break;
                    case "player":
                        playerPanel.BringToFront();
                        initializePlayerSystem();
                        break;
                    case "qol":
                        qolPanel.BringToFront();
                        break;
                    case "information":
                        welcomePanel.BringToFront();
                        break;
                }
                
                if (lbl.Text.ToLower() == "exit")
                {
                    Application.Exit();
                }
            }
        }

        private void lbl_MouseUp(object sender, EventArgs e)
        {
            System.Windows.Forms.Label label = (System.Windows.Forms.Label)sender;
            if (label.Text != "")
            {
            }
        }

        private void mainForm_Resize(object sender, EventArgs e)
        {
            mainMenu.Invalidate();
        }

        private void infoComponentPlayer_Click(object sender, EventArgs e)
        {
            foreach (Control component in mainMenu.Controls)
            {
                if (component is Label)
                {
                    if (component.Text.ToLower() == infoComponentPlayer.Text.ToLower())
                    {
                        component.ForeColor = selectText;
                    }
                }
            }
            lbl_MouseDown(sender, e);
            infoComponentPlayer.BackColor = Color.Transparent;
            infoComponentPlayer.ForeColor = idleText;
        }

        private void infoComponentTraders_Click(object sender, EventArgs e)
        {
            foreach (Control component in mainMenu.Controls)
            {
                if (component is Label)
                {
                    if (component.Text.ToLower() == infoComponentTraders.Text.ToLower())
                    {
                        component.ForeColor = selectText;
                    }
                }
            }
            lbl_MouseDown(sender, e);
            infoComponentTraders.BackColor = Color.Transparent;
            infoComponentTraders.ForeColor = idleText;
        }

        private void infoComponentRaids_Click(object sender, EventArgs e)
        {
            foreach (Control component in mainMenu.Controls)
            {
                if (component is Label)
                {
                    if (component.Text.ToLower() == infoComponentRaids.Text.ToLower())
                    {
                        component.ForeColor = selectText;
                    }
                }
            }
            lbl_MouseDown(sender, e);
            infoComponentRaids.BackColor = Color.Transparent;
            infoComponentRaids.ForeColor = idleText;
        }

        private void infoComponentBots_Click(object sender, EventArgs e)
        {
            foreach (Control component in mainMenu.Controls)
            {
                if (component is Label)
                {
                    if (component.Text.ToLower() == infoComponentBots.Text.ToLower())
                    {
                        component.ForeColor = selectText;
                    }
                }
            }
            lbl_MouseDown(sender, e);
            infoComponentBots.BackColor = Color.Transparent;
            infoComponentBots.ForeColor = idleText;
        }

        private void infoComponentQoL_Click(object sender, EventArgs e)
        {
            foreach (Control component in mainMenu.Controls)
            {
                if (component is Label)
                {
                    if (component.Text.ToLower() == infoComponentQoL.Text.ToLower())
                    {
                        component.ForeColor = selectText;
                    }
                }
            }
            lbl_MouseDown(sender, e);
            infoComponentQoL.BackColor = Color.Transparent;
            infoComponentQoL.ForeColor = idleText;
        }

        public void initializePlayerSystem()
        {
            playerList.Items.Clear();
            /*
            foreach (Control component in playerList.Controls)
            {
                if (component is GroupBox)
                {
                    component.Visible = false;

                    foreach (Control inComponent in component.Controls)
                    {
                        if (inComponent is TextBox tbx)
                        {
                            tbx.Text = "";
                        }
                        else if (inComponent is ListBox lbx)
                        {
                            lbx.Items.Clear();
                        }
                    }
                }
            }
            */

            listProfiles();
        }

        public void listProfiles()
        {
            string userFolder = Path.Combine(currentDir, "user");
            string profilesFolder = Path.Combine(userFolder, "profiles");

            bool userFolderExists = Directory.Exists(userFolder);
            if (userFolderExists)
            {
                bool profilesFolderExists = Directory.Exists(profilesFolder);
                if (profilesFolderExists)
                {
                    foreach (string profile in Directory.GetFiles(profilesFolder))
                    {
                        JavaScriptSerializer serializer = new JavaScriptSerializer();
                        dynamic _profile = serializer.Deserialize<dynamic>(File.ReadAllText(profile));

                        string nickname = _profile["characters"]["pmc"]["Info"]["Nickname"];
                        playerList.Items.Add(nickname);
                    }
                }
            }
        }

        private void playerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (playerList.SelectedIndex > -1)
            {
                // set all necessary components visible
                playerTabHealth.Visible = true;
                playerTabInfo.Visible = true;

                playerHealthBox.Visible = true;
                playerInventoryPanel.Visible = true;
                playerLevelingPanel.Visible = true;
                playerAccountPanel.Visible = true;

                // code stuff
                string selectedName = playerList.SelectedItem.ToString();
                int playerIndex = playerList.SelectedIndex;

                string userFolder = Path.Combine(currentDir, "user");
                string profilesFolder = Path.Combine(userFolder, "profiles");

                bool existsUser = Directory.Exists(userFolder);
                bool existsProfiles = Directory.Exists(profilesFolder);

                if (existsUser && existsProfiles)
                {
                    string[] profiles = Directory.GetFiles(profilesFolder);
                    string matchedProfile = profiles[playerIndex];

                    bool doesProfileExist = File.Exists(matchedProfile);

                    if (doesProfileExist)
                    {
                        readProfileInfo(matchedProfile);
                    }
                }

                playerInfoPanel.BringToFront();
            }
        }

        public void readProfileInfo(string path)
        {
            string fileToRead = File.ReadAllText(path);
            JavaScriptSerializer profileJson = new JavaScriptSerializer();
            dynamic readCore = profileJson.Deserialize<dynamic>(fileToRead);

            // Read values and variables
            string ACCOUNT_AID = (string)readCore["info"]["id"];
            string ACCOUNT_USERNAME = (string)readCore["info"]["username"];
            string ACCOUNT_PW = (string)readCore["info"]["password"];
            
            string INGAME_USERNAME = (string)readCore["characters"]["pmc"]["Info"]["Nickname"];
            string INGAME_FACTION = (string)readCore["characters"]["pmc"]["Info"]["Side"];
            string INGAME_GAME_VERSION = (string)readCore["characters"]["pmc"]["Info"]["GameVersion"];
            string INGAME_LEVEL = Convert.ToString((int)readCore["characters"]["pmc"]["Info"]["Level"]);
            string INGAME_EXPERIENCE = Convert.ToString((int)readCore["characters"]["pmc"]["Info"]["Experience"]);

            INGAME_FACTION = INGAME_FACTION.ToUpper();
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            INGAME_GAME_VERSION = textInfo.ToTitleCase(INGAME_GAME_VERSION);

            // Assign values to components
            playerAID.Text = ACCOUNT_AID;
            playerUser.Text = INGAME_USERNAME;
            playerFaction.Text = INGAME_FACTION;
            playerLevel.Text = INGAME_LEVEL;
            playerExp.Text = INGAME_EXPERIENCE;
            launcherUser.Text = ACCOUNT_USERNAME;

            INGAME_GAME_VERSION = INGAME_GAME_VERSION.Replace("_", " ");
            INGAME_GAME_VERSION = textInfo.ToTitleCase(INGAME_GAME_VERSION);
            playerGV.Text = INGAME_GAME_VERSION;

            if (ACCOUNT_PW.Length == 0)
            {
                launcherPw.Text = "No password";
            }
            else
            {
                launcherPw.Text = ACCOUNT_PW;
            }

        }

        private void playerTabInfo_Click(object sender, EventArgs e)
        {
            playerInfoPanel.BringToFront();
        }

        private void playerTabHealth_Click(object sender, EventArgs e)
        {
            playerHealthPanel.BringToFront();
        }

        private void playerFaction_MouseDown(object sender, MouseEventArgs e)
        {
            switch (playerFaction.Text.ToLower())
            {
                case "bear":
                    playerFaction.Text = "USEC";
                    break;
                case "usec":
                    playerFaction.Text = "BEAR";
                    break;
            }
        }

        private void playerGV_MouseDown(object sender, MouseEventArgs e)
        {
            switch (playerGV.Text.ToLower())
            {
                case "standard":
                    playerGV.Text = "Left Behind";
                    break;
                case "left behind":
                    playerGV.Text = "Prepare for Darkness";
                    break;
                case "prepare for darkness":
                    playerGV.Text = "Edge of Darkness";
                    break;
                case "edge of darkness":
                    playerGV.Text = "Standard";
                    break;
            }
        }
    }
}
