using QoLUtility.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QoLUtility
{
    public partial class mainForm : Form
    {
        public string currentDir = Environment.CurrentDirectory;

        int default_item_height = 22; // item height
        int default_item_loc_x = 1; // keep 1
        int default_item_loc_y = 16; // item location startpoint
        int default_item_spacer = 22; // spacer between item to item

        public Color idleText = Color.LightGray;
        public Color idleColor = Color.FromArgb(255, 28, 28, 28);
        public Color hoverColor = Color.FromArgb(255, 32, 32, 32);
        public Color selectColor = Color.FromArgb(255, 35, 35, 35);
        public Color selectText = Color.DodgerBlue;
        public Font idleFont = new Font("Bahnschrift Light", 11, FontStyle.Regular);

        public string[] selectionMenu =
        {
            "Bots",
            "Traders",
            "Raids",
            "Player",
            "QoL"
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
                MessageBox.Show("Works!");
            }
            else
            {
                MessageBox.Show("Not works");
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

            bool akiServerPath = Directory.Exists(Path.Combine(currentDir, "Aki.Server.exe"));
            bool akiLauncherPath = Directory.Exists(Path.Combine(currentDir, "Aki.Launcher.exe"));
            bool EFTData = Directory.Exists(Path.Combine(currentDir, "EscapeFromTarkov_Data"));

            string[] akiDB_FullPath = { "Aki_Data", "Server", "database", "templates" };
            string fullPath = string.Join("\\", akiDB_FullPath);
            bool fullPathExists = Directory.Exists(Path.Combine(currentDir, fullPath));
            bool akiDatabase = File.Exists(Path.Combine(akiDB_FullPath[3], "items.json"));

            if (akiServerPath && akiLauncherPath && EFTData && fullPathExists && akiDatabase)
            {
                allExist = true;
            }

            return allExist;
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

        private void panel2_Paint(object sender, PaintEventArgs e)
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

            using (Pen pen = new Pen(Color.FromArgb(255, 100, 100, 100), 1))
            {
                graphics.DrawPath(pen, path);
            }
        }

        public void listSystem(string[] arr)
        {
            clearUI(mainMenu);
            for (int i = 0; i < arr.Length; i++)
            {
                Label lbl = new Label();
                lbl.Text = arr[i];
                lbl.AutoSize = false;
                lbl.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
                lbl.TextAlign = ContentAlignment.MiddleLeft;
                lbl.Size = new Size(mainMenu.Size.Width - 2, default_item_height);
                lbl.Location = new Point(default_item_loc_x, default_item_loc_y + (i * default_item_spacer));
                lbl.Font = idleFont;
                lbl.BackColor = idleColor;
                lbl.ForeColor = Color.Black;
                lbl.Margin = new Padding(1, 1, 1, 1);
                lbl.Cursor = Cursors.Hand;
                lbl.MouseEnter += new EventHandler(lbl_MouseEnter);
                lbl.MouseLeave += new EventHandler(lbl_MouseLeave);
                lbl.MouseDown += new MouseEventHandler(lbl_MouseDown);
                lbl.MouseUp += new MouseEventHandler(lbl_MouseUp);
                lbl.TextAlign = ContentAlignment.MiddleLeft;
                lbl.Visible = true;
                mainMenu.Controls.Add(lbl);
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
                    if (component.Text.Contains("> "))
                    {
                        //component.Text = component.Text.Remove(0, 2);
                        component.Text = component.Text.Replace("> ", "");
                    }

                    if (component is Label && component.Text != lbl.Text)
                    {
                        component.BackColor = idleColor;
                        component.ForeColor = idleText;
                    }
                }
                lbl.BackColor = hoverColor;

                string activeItem = lbl.Text;
                activeItem = "> " + activeItem;
                lbl.Text = activeItem;
                lbl.ForeColor = selectText;

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
    }
}
