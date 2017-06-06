using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Media;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using System.Net;
using SAM_Reminders.Properties;
using System.Net.Mail;
using System.Net.Mime;
using System.Net.Sockets;
using System.Globalization;

namespace SAM_Reminders
{
    public partial class ReminderForm : Form
    {
        string Username = Environment.UserName;
        public ReminderForm()
        {
            InitializeComponent();
            BackColor = Color.Pink;
            TransparencyKey = Color.Pink;
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;


        private void ReminderForm_Load(object sender, EventArgs e)
        {
            ReminderList.Items.Clear();
            ReminderList.SelectionMode = SelectionMode.None;
            ReminderList.Visible = true;
            ReminderList.Items.Add(Settings.Default.ReminderSlot1);
            ReminderList.Items.Add(Settings.Default.ReminderSlot2);
            ReminderList.Items.Add(Settings.Default.ReminderSlot3);
            ReminderList.Items.Add(Settings.Default.ReminderSlot4);
            ReminderList.Items.Add(Settings.Default.ReminderSlot5);
        }

        private void Savestuff_Click(object sender, EventArgs e)
        {
            if (Slotuselbl.Text == "Slot No. 1")
            {
                if (RDate.Text != String.Empty)
                {
                    Settings.Default.ReminderDate1 = RDate.Text;
                    Settings.Default.Save();
                }
                if (RTime.Text != String.Empty)
                {
                    Settings.Default.ReminderTime1 = RTime.Text;
                    Settings.Default.Save();
                }
                Settings.Default.ReminderSlot1 = QURYPNL.Text;
                Settings.Default.Save();
            }

            if (Slotuselbl.Text == "Slot No. 2")
            {
                if (RDate.Text != String.Empty)
                {
                    Settings.Default.ReminderDate2 = RDate.Text;
                    Settings.Default.Save();
                }
                if (RTime.Text != String.Empty)
                {
                    Settings.Default.ReminderTime2 = RTime.Text;
                    Settings.Default.Save();
                }
                Settings.Default.ReminderSlot2 = QURYPNL.Text;
                Settings.Default.Save();
            }

            if (Slotuselbl.Text == "Slot No. 3")
            {
                if (RDate.Text != String.Empty)
                {
                    Settings.Default.ReminderDate3 = RDate.Text;
                    Settings.Default.Save();
                }
                if (RTime.Text != String.Empty)
                {
                    Settings.Default.ReminderTime3 = RTime.Text;
                    Settings.Default.Save();
                }
                Settings.Default.ReminderSlot3 = QURYPNL.Text;
                Settings.Default.Save();
            }

            if (Slotuselbl.Text == "Slot No. 4")
            {
                if (RDate.Text != String.Empty)
                {
                    Settings.Default.ReminderDate4 = RDate.Text;
                    Settings.Default.Save();
                }
                if (RTime.Text != String.Empty)
                {
                    Settings.Default.ReminderTime4 = RTime.Text;
                    Settings.Default.Save();
                }
                Settings.Default.ReminderSlot4 = QURYPNL.Text;
                Settings.Default.Save();
            }

            if (Slotuselbl.Text == "Slot No. 5")
            {
                if (RDate.Text != String.Empty)
                {
                    Settings.Default.ReminderDate5 = RDate.Text;
                    Settings.Default.Save();
                }
                if (RTime.Text != String.Empty)
                {
                    Settings.Default.ReminderTime5 = RTime.Text;
                    Settings.Default.Save();
                }
                Settings.Default.ReminderSlot5 = QURYPNL.Text;
                Settings.Default.Save();
            }
            Settings.Default.Alarm = "true";
            ReminderList.Items.Clear();
            ReminderList.SelectionMode = SelectionMode.None;
            ReminderList.Visible = true;
            ReminderList.Items.Add(Settings.Default.ReminderSlot1);
            ReminderList.Items.Add(Settings.Default.ReminderSlot2);
            ReminderList.Items.Add(Settings.Default.ReminderSlot3);
            ReminderList.Items.Add(Settings.Default.ReminderSlot4);
            ReminderList.Items.Add(Settings.Default.ReminderSlot5);
            Settings.Default.Save();
            ReminderList.Items.Clear();
            ReminderList.SelectionMode = SelectionMode.None;
            ReminderList.Visible = true;
            ReminderList.Items.Add(Settings.Default.ReminderSlot1);
            ReminderList.Items.Add(Settings.Default.ReminderSlot2);
            ReminderList.Items.Add(Settings.Default.ReminderSlot3);
            ReminderList.Items.Add(Settings.Default.ReminderSlot4);
            ReminderList.Items.Add(Settings.Default.ReminderSlot5);
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            if (Replybox.Text.Contains("1"))
            {
                Settings.Default.ReminderSlot1 = String.Empty;
                Settings.Default.ReminderDate1 = String.Empty;
                Settings.Default.ReminderTime1 = String.Empty;
                Settings.Default.Save();
            }
            if (Replybox.Text.Contains("2"))
            {
                Settings.Default.ReminderSlot2 = String.Empty;
                Settings.Default.ReminderDate2 = String.Empty;
                Settings.Default.ReminderTime2 = String.Empty;
                Settings.Default.Save();
            }
            if (Replybox.Text.Contains("3"))
            {
                Settings.Default.ReminderSlot3 = String.Empty;
                Settings.Default.ReminderDate3 = String.Empty;
                Settings.Default.ReminderTime3 = String.Empty;
                Settings.Default.Save();
            }
            if (Replybox.Text.Contains("4"))
            {
                Settings.Default.ReminderSlot4 = String.Empty;
                Settings.Default.ReminderDate4 = String.Empty;
                Settings.Default.ReminderTime4 = String.Empty;
                Settings.Default.Save();
            }
            if (Replybox.Text.Contains("5"))
            {
                Settings.Default.ReminderSlot5 = String.Empty;
                Settings.Default.ReminderDate5 = String.Empty;
                Settings.Default.ReminderTime5 = String.Empty;
                Settings.Default.Save();
            }
            ReminderList.Items.Clear();
            ReminderList.SelectionMode = SelectionMode.None;
            ReminderList.Visible = true;
            ReminderList.Items.Add(Settings.Default.ReminderSlot1);
            ReminderList.Items.Add(Settings.Default.ReminderSlot2);
            ReminderList.Items.Add(Settings.Default.ReminderSlot3);
            ReminderList.Items.Add(Settings.Default.ReminderSlot4);
            ReminderList.Items.Add(Settings.Default.ReminderSlot5);
        }

        private void Closethis_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Openfile_MouseEnter(object sender, EventArgs e)
        {
            Openfile.BackgroundImage = global::SAM_Reminders.Properties.Resources.folderN;
        }

        private void Openfile_MouseLeave(object sender, EventArgs e)
        {
            Openfile.BackgroundImage = global::SAM_Reminders.Properties.Resources.folderC;
        }

        private void Openfile_Click(object sender, EventArgs e)
        {
            Open.ShowDialog();
            Settings.Default.AlarmSrc = Open.FileName;
            Settings.Default.Save();
        }

        private void Slot1_Click_1(object sender, EventArgs e)
        {
            Slotuselbl.Text = "Slot No. 1";
            if (Settings.Default.ReminderSlot1 == String.Empty)
            {
                Replybox.Text = "Slot No. 1 is Empty";
            }
            if (Settings.Default.ReminderSlot1 != String.Empty)
            {
                Replybox.Text = "Slot No.1 is in use";
            }
            if (Settings.Default.ReminderSlot1 != String.Empty)
            {
                RDate.Text = Settings.Default.ReminderDate1.ToString();
                RTime.Text = Settings.Default.ReminderTime1.ToString();
                QURYPNL.Text = Settings.Default.ReminderSlot1.ToString();
            }
        }

        private void Slot2_Click_1(object sender, EventArgs e)
        {
            Slotuselbl.Text = "Slot No. 2";
            if (Settings.Default.ReminderSlot2 == String.Empty)
            {
                Replybox.Text = "Slot No. 2 is Empty";
            }
            if (Settings.Default.ReminderSlot2 != String.Empty)
            {
                Replybox.Text = "Slot No.2 is in use";
            }
            if (Settings.Default.ReminderSlot2 != String.Empty)
            {
                RDate.Text = Settings.Default.ReminderDate2.ToString();
                RTime.Text = Settings.Default.ReminderTime2.ToString();
                QURYPNL.Text = Settings.Default.ReminderSlot2.ToString();
            }
        }

        private void Slot3_Click_1(object sender, EventArgs e)
        {
            Slotuselbl.Text = "Slot No. 3";
            if (Settings.Default.ReminderSlot3 == String.Empty)
            {
                Replybox.Text = "Slot No. 3 is Empty";
            }
            if (Settings.Default.ReminderSlot3 != String.Empty)
            {
                Replybox.Text = "Slot No.3 is in use";
            }
            if (Settings.Default.ReminderSlot3 != String.Empty)
            {
                RDate.Text = Settings.Default.ReminderDate3.ToString();
                RTime.Text = Settings.Default.ReminderTime3.ToString();
                QURYPNL.Text = Settings.Default.ReminderSlot3.ToString();
            }
        }

        private void Slot4_Click_1(object sender, EventArgs e)
        {
            Slotuselbl.Text = "Slot No. 4";
            if (Settings.Default.ReminderSlot4 == String.Empty)
            {
                Replybox.Text = "Slot No. 4 is Empty";
            }
            if (Settings.Default.ReminderSlot4 != String.Empty)
            {
                Replybox.Text = "Slot No.4 is in use";
            }
            if (Settings.Default.ReminderSlot4 != String.Empty)
            {
                RDate.Text = Settings.Default.ReminderDate4.ToString();
                RTime.Text = Settings.Default.ReminderTime4.ToString();
                QURYPNL.Text = Settings.Default.ReminderSlot4.ToString();
            }
        }

        private void Slot5_Click_1(object sender, EventArgs e)
        {
            Slotuselbl.Text = "Slot No. 5";
            if (Settings.Default.ReminderSlot5 == String.Empty)
            {
                Replybox.Text = "Slot No. 5 is Empty";
            }
            if (Settings.Default.ReminderSlot5 != String.Empty)
            {
                Replybox.Text = "Slot No.5 is in use";
            }
            if (Settings.Default.ReminderSlot5 != String.Empty)
            {
                RDate.Text = Settings.Default.ReminderDate5.ToString();
                RTime.Text = Settings.Default.ReminderTime5.ToString();
                QURYPNL.Text = Settings.Default.ReminderSlot5.ToString();
            }
        }
    }
}