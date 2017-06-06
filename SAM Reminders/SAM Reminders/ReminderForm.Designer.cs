namespace SAM_Reminders
{
    partial class ReminderForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.Openfile = new System.Windows.Forms.PictureBox();
            this.Slotuselbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SW = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RTime = new System.Windows.Forms.MaskedTextBox();
            this.RDate = new System.Windows.Forms.MaskedTextBox();
            this.Editbtn = new System.Windows.Forms.Button();
            this.ReminderList = new System.Windows.Forms.ListBox();
            this.Savestuff = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Slot1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Slot5 = new System.Windows.Forms.Button();
            this.Slot2 = new System.Windows.Forms.Button();
            this.Slot3 = new System.Windows.Forms.Button();
            this.Slot4 = new System.Windows.Forms.Button();
            this.QURYPNL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Closethis = new System.Windows.Forms.PictureBox();
            this.Replybox = new System.Windows.Forms.TextBox();
            this.Open = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Openfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Closethis)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(76, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 342;
            this.label5.Text = "Message:";
            // 
            // Openfile
            // 
            this.Openfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Openfile.BackColor = System.Drawing.Color.Transparent;
            this.Openfile.BackgroundImage = global::SAM_Reminders.Properties.Resources.folderC;
            this.Openfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Openfile.Location = new System.Drawing.Point(318, 281);
            this.Openfile.Name = "Openfile";
            this.Openfile.Size = new System.Drawing.Size(30, 30);
            this.Openfile.TabIndex = 341;
            this.Openfile.TabStop = false;
            this.Openfile.Click += new System.EventHandler(this.Openfile_Click);
            this.Openfile.MouseEnter += new System.EventHandler(this.Openfile_MouseEnter);
            this.Openfile.MouseLeave += new System.EventHandler(this.Openfile_MouseLeave);
            // 
            // Slotuselbl
            // 
            this.Slotuselbl.AutoSize = true;
            this.Slotuselbl.BackColor = System.Drawing.Color.Transparent;
            this.Slotuselbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slotuselbl.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Slotuselbl.Location = new System.Drawing.Point(242, 419);
            this.Slotuselbl.Name = "Slotuselbl";
            this.Slotuselbl.Size = new System.Drawing.Size(78, 20);
            this.Slotuselbl.TabIndex = 322;
            this.Slotuselbl.Text = "Slot No. 1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft NeoGothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label11.Location = new System.Drawing.Point(188, 288);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 20);
            this.label11.TabIndex = 340;
            this.label11.Text = "Ringtone Source:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SW
            // 
            this.SW.AutoCompleteCustomSource.AddRange(new string[] {
            "Yes",
            "No"});
            this.SW.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.SW.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SW.BackColor = System.Drawing.SystemColors.InfoText;
            this.SW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SW.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SW.FormattingEnabled = true;
            this.SW.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.SW.Location = new System.Drawing.Point(323, 241);
            this.SW.Name = "SW";
            this.SW.Size = new System.Drawing.Size(61, 24);
            this.SW.TabIndex = 338;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft NeoGothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Location = new System.Drawing.Point(188, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 20);
            this.label10.TabIndex = 339;
            this.label10.Text = "Custom Ringtone ?";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(181, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 20);
            this.label2.TabIndex = 334;
            this.label2.Text = "|\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RTime
            // 
            this.RTime.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.RTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTime.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.RTime.Location = new System.Drawing.Point(105, 268);
            this.RTime.Mask = "00:00";
            this.RTime.Name = "RTime";
            this.RTime.Size = new System.Drawing.Size(70, 22);
            this.RTime.TabIndex = 324;
            this.RTime.Text = "2230";
            this.RTime.ValidatingType = typeof(System.DateTime);
            // 
            // RDate
            // 
            this.RDate.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.RDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.RDate.Location = new System.Drawing.Point(105, 240);
            this.RDate.Mask = "00/00/0000";
            this.RDate.Name = "RDate";
            this.RDate.Size = new System.Drawing.Size(70, 22);
            this.RDate.TabIndex = 325;
            this.RDate.Text = "31122015";
            this.RDate.ValidatingType = typeof(System.DateTime);
            // 
            // Editbtn
            // 
            this.Editbtn.BackColor = System.Drawing.SystemColors.InfoText;
            this.Editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editbtn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Editbtn.Location = new System.Drawing.Point(161, 418);
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Size = new System.Drawing.Size(75, 25);
            this.Editbtn.TabIndex = 326;
            this.Editbtn.Text = "Clear Slot";
            this.Editbtn.UseVisualStyleBackColor = false;
            this.Editbtn.Click += new System.EventHandler(this.Editbtn_Click);
            // 
            // ReminderList
            // 
            this.ReminderList.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ReminderList.BackColor = System.Drawing.Color.Black;
            this.ReminderList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReminderList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReminderList.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ReminderList.FormattingEnabled = true;
            this.ReminderList.ItemHeight = 24;
            this.ReminderList.Location = new System.Drawing.Point(118, 75);
            this.ReminderList.Name = "ReminderList";
            this.ReminderList.Size = new System.Drawing.Size(266, 146);
            this.ReminderList.TabIndex = 323;
            // 
            // Savestuff
            // 
            this.Savestuff.BackColor = System.Drawing.Color.Black;
            this.Savestuff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savestuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savestuff.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Savestuff.Location = new System.Drawing.Point(80, 418);
            this.Savestuff.Name = "Savestuff";
            this.Savestuff.Size = new System.Drawing.Size(75, 25);
            this.Savestuff.TabIndex = 327;
            this.Savestuff.Text = "Save";
            this.Savestuff.UseVisualStyleBackColor = false;
            this.Savestuff.Click += new System.EventHandler(this.Savestuff_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(56, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 18);
            this.label7.TabIndex = 321;
            this.label7.Text = "Time:";
            // 
            // Slot1
            // 
            this.Slot1.BackColor = System.Drawing.SystemColors.InfoText;
            this.Slot1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Slot1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Slot1.Location = new System.Drawing.Point(58, 78);
            this.Slot1.Name = "Slot1";
            this.Slot1.Size = new System.Drawing.Size(54, 23);
            this.Slot1.TabIndex = 328;
            this.Slot1.Text = "Slot 1";
            this.Slot1.UseVisualStyleBackColor = false;
            this.Slot1.Click += new System.EventHandler(this.Slot1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(58, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 18);
            this.label6.TabIndex = 320;
            this.label6.Text = "Date:";
            // 
            // Slot5
            // 
            this.Slot5.BackColor = System.Drawing.SystemColors.InfoText;
            this.Slot5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Slot5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Slot5.Location = new System.Drawing.Point(58, 194);
            this.Slot5.Name = "Slot5";
            this.Slot5.Size = new System.Drawing.Size(54, 23);
            this.Slot5.TabIndex = 332;
            this.Slot5.Text = "Slot 5";
            this.Slot5.UseVisualStyleBackColor = false;
            this.Slot5.Click += new System.EventHandler(this.Slot5_Click_1);
            // 
            // Slot2
            // 
            this.Slot2.BackColor = System.Drawing.SystemColors.InfoText;
            this.Slot2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Slot2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Slot2.Location = new System.Drawing.Point(58, 107);
            this.Slot2.Name = "Slot2";
            this.Slot2.Size = new System.Drawing.Size(54, 23);
            this.Slot2.TabIndex = 329;
            this.Slot2.Text = "Slot 2";
            this.Slot2.UseVisualStyleBackColor = false;
            this.Slot2.Click += new System.EventHandler(this.Slot2_Click_1);
            // 
            // Slot3
            // 
            this.Slot3.BackColor = System.Drawing.SystemColors.InfoText;
            this.Slot3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Slot3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Slot3.Location = new System.Drawing.Point(58, 136);
            this.Slot3.Name = "Slot3";
            this.Slot3.Size = new System.Drawing.Size(54, 23);
            this.Slot3.TabIndex = 330;
            this.Slot3.Text = "Slot 3";
            this.Slot3.UseVisualStyleBackColor = false;
            this.Slot3.Click += new System.EventHandler(this.Slot3_Click_1);
            // 
            // Slot4
            // 
            this.Slot4.BackColor = System.Drawing.SystemColors.InfoText;
            this.Slot4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Slot4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Slot4.Location = new System.Drawing.Point(58, 165);
            this.Slot4.Name = "Slot4";
            this.Slot4.Size = new System.Drawing.Size(54, 23);
            this.Slot4.TabIndex = 331;
            this.Slot4.Text = "Slot 4";
            this.Slot4.UseVisualStyleBackColor = false;
            this.Slot4.Click += new System.EventHandler(this.Slot4_Click_1);
            // 
            // QURYPNL
            // 
            this.QURYPNL.AutoCompleteCustomSource.AddRange(new string[] {
            "Hello",
            "SAM",
            "Stop talking",
            "What\'s my name?",
            "mute",
            "What time is it",
            "What day is it",
            "Whats todays date",
            "Hows the weather",
            "Whats tomorrows forecast",
            "Whats the temperature",
            "Switch Window",
            "Close this",
            "SAM you are blocking my view",
            "SAM I need you back",
            "Show default commands",
            "I need the default command list",
            "Hide the command list",
            "Shutdown",
            "Log off",
            "Restart",
            "Abort",
            "I want to add a custom command",
            "Update Data",
            "Stop listening",
            "enable access",
            "SAM drop my needle",
            "Lock",
            "Core data",
            "Pause",
            "Resume"});
            this.QURYPNL.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.QURYPNL.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.QURYPNL.BackColor = System.Drawing.SystemColors.InfoText;
            this.QURYPNL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QURYPNL.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.QURYPNL.Location = new System.Drawing.Point(70, 317);
            this.QURYPNL.Multiline = true;
            this.QURYPNL.Name = "QURYPNL";
            this.QURYPNL.Size = new System.Drawing.Size(304, 94);
            this.QURYPNL.TabIndex = 319;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(54, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 20);
            this.label1.TabIndex = 333;
            this.label1.Text = "____________________________________";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(181, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 20);
            this.label3.TabIndex = 335;
            this.label3.Text = "|\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(181, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 20);
            this.label4.TabIndex = 336;
            this.label4.Text = "|\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Location = new System.Drawing.Point(181, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 20);
            this.label9.TabIndex = 337;
            this.label9.Text = "|\r\n";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(181, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 20);
            this.label8.TabIndex = 343;
            this.label8.Text = "|\r\n";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.Location = new System.Drawing.Point(181, 293);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 20);
            this.label12.TabIndex = 344;
            this.label12.Text = "|\r\n";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Closethis
            // 
            this.Closethis.BackColor = System.Drawing.Color.Transparent;
            this.Closethis.BackgroundImage = global::SAM_Reminders.Properties.Resources.close_icon;
            this.Closethis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Closethis.Location = new System.Drawing.Point(370, 37);
            this.Closethis.Name = "Closethis";
            this.Closethis.Size = new System.Drawing.Size(20, 20);
            this.Closethis.TabIndex = 345;
            this.Closethis.TabStop = false;
            this.Closethis.Click += new System.EventHandler(this.Closethis_Click_2);
            // 
            // Replybox
            // 
            this.Replybox.Location = new System.Drawing.Point(284, 455);
            this.Replybox.Name = "Replybox";
            this.Replybox.Size = new System.Drawing.Size(100, 20);
            this.Replybox.TabIndex = 346;
            this.Replybox.Visible = false;
            // 
            // Open
            // 
            this.Open.FileName = "openFileDialog1";
            // 
            // ReminderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAM_Reminders.Properties.Resources.ReminderWindow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(426, 476);
            this.Controls.Add(this.Replybox);
            this.Controls.Add(this.Closethis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Openfile);
            this.Controls.Add(this.Slotuselbl);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.SW);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RTime);
            this.Controls.Add(this.RDate);
            this.Controls.Add(this.Editbtn);
            this.Controls.Add(this.ReminderList);
            this.Controls.Add(this.Savestuff);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Slot1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Slot5);
            this.Controls.Add(this.Slot2);
            this.Controls.Add(this.Slot3);
            this.Controls.Add(this.Slot4);
            this.Controls.Add(this.QURYPNL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReminderForm";
            this.Text = "ReminderForm";
            this.Load += new System.EventHandler(this.ReminderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Openfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Closethis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox Openfile;
        private System.Windows.Forms.Label Slotuselbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox SW;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox RTime;
        private System.Windows.Forms.MaskedTextBox RDate;
        private System.Windows.Forms.Button Editbtn;
        private System.Windows.Forms.ListBox ReminderList;
        private System.Windows.Forms.Button Savestuff;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Slot1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Slot5;
        private System.Windows.Forms.Button Slot2;
        private System.Windows.Forms.Button Slot3;
        private System.Windows.Forms.Button Slot4;
        private System.Windows.Forms.TextBox QURYPNL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox Closethis;
        private System.Windows.Forms.TextBox Replybox;
        private System.Windows.Forms.OpenFileDialog Open;

    }
}