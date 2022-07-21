
namespace Focus_Timer
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTime = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rndSonstiges = new System.Windows.Forms.RadioButton();
            this.rndOrga = new System.Windows.Forms.RadioButton();
            this.rndCoding = new System.Windows.Forms.RadioButton();
            this.rdbLerning = new System.Windows.Forms.RadioButton();
            this.lblLerningTime = new System.Windows.Forms.Label();
            this.lblSonstigesTime = new System.Windows.Forms.Label();
            this.lblPauseTime = new System.Windows.Forms.Label();
            this.lblCodingTime = new System.Windows.Forms.Label();
            this.lblOrgaTime = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.rndMeeting = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imVordergrundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ausToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rndPause = new System.Windows.Forms.RadioButton();
            this.lblMeetingTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(98, 36);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(299, 54);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "00:00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rndPause);
            this.groupBox1.Controls.Add(this.rndMeeting);
            this.groupBox1.Controls.Add(this.rndSonstiges);
            this.groupBox1.Controls.Add(this.rndOrga);
            this.groupBox1.Controls.Add(this.rndCoding);
            this.groupBox1.Controls.Add(this.rdbLerning);
            this.groupBox1.Location = new System.Drawing.Point(19, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 80);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Welcher Zeitaufwand";
            // 
            // rndSonstiges
            // 
            this.rndSonstiges.AutoSize = true;
            this.rndSonstiges.Location = new System.Drawing.Point(142, 48);
            this.rndSonstiges.Name = "rndSonstiges";
            this.rndSonstiges.Size = new System.Drawing.Size(71, 17);
            this.rndSonstiges.TabIndex = 13;
            this.rndSonstiges.TabStop = true;
            this.rndSonstiges.Text = "Sonstiges";
            this.rndSonstiges.UseVisualStyleBackColor = true;
            // 
            // rndOrga
            // 
            this.rndOrga.AutoSize = true;
            this.rndOrga.Location = new System.Drawing.Point(142, 19);
            this.rndOrga.Name = "rndOrga";
            this.rndOrga.Size = new System.Drawing.Size(84, 17);
            this.rndOrga.TabIndex = 12;
            this.rndOrga.TabStop = true;
            this.rndOrga.Text = "Organisieren";
            this.rndOrga.UseVisualStyleBackColor = true;
            // 
            // rndCoding
            // 
            this.rndCoding.AutoSize = true;
            this.rndCoding.Location = new System.Drawing.Point(13, 48);
            this.rndCoding.Name = "rndCoding";
            this.rndCoding.Size = new System.Drawing.Size(56, 17);
            this.rndCoding.TabIndex = 11;
            this.rndCoding.TabStop = true;
            this.rndCoding.Text = "Coden";
            this.rndCoding.UseVisualStyleBackColor = true;
            // 
            // rdbLerning
            // 
            this.rdbLerning.AutoSize = true;
            this.rdbLerning.Location = new System.Drawing.Point(13, 19);
            this.rdbLerning.Name = "rdbLerning";
            this.rdbLerning.Size = new System.Drawing.Size(58, 17);
            this.rdbLerning.TabIndex = 10;
            this.rdbLerning.TabStop = true;
            this.rdbLerning.Text = "Lernen";
            this.rdbLerning.UseVisualStyleBackColor = true;
            // 
            // lblLerningTime
            // 
            this.lblLerningTime.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLerningTime.Location = new System.Drawing.Point(4, 229);
            this.lblLerningTime.Name = "lblLerningTime";
            this.lblLerningTime.Size = new System.Drawing.Size(223, 39);
            this.lblLerningTime.TabIndex = 3;
            this.lblLerningTime.Text = "Lernen: 00:00:00";
            this.lblLerningTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSonstigesTime
            // 
            this.lblSonstigesTime.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSonstigesTime.Location = new System.Drawing.Point(250, 223);
            this.lblSonstigesTime.Name = "lblSonstigesTime";
            this.lblSonstigesTime.Size = new System.Drawing.Size(223, 39);
            this.lblSonstigesTime.TabIndex = 4;
            this.lblSonstigesTime.Text = "Sonstiges: 00:00:00";
            this.lblSonstigesTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPauseTime
            // 
            this.lblPauseTime.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPauseTime.Location = new System.Drawing.Point(250, 260);
            this.lblPauseTime.Name = "lblPauseTime";
            this.lblPauseTime.Size = new System.Drawing.Size(223, 39);
            this.lblPauseTime.TabIndex = 6;
            this.lblPauseTime.Text = "Pause: 00:00:00";
            this.lblPauseTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCodingTime
            // 
            this.lblCodingTime.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodingTime.Location = new System.Drawing.Point(4, 264);
            this.lblCodingTime.Name = "lblCodingTime";
            this.lblCodingTime.Size = new System.Drawing.Size(223, 39);
            this.lblCodingTime.TabIndex = 5;
            this.lblCodingTime.Text = "Coden: 00:00:00";
            this.lblCodingTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOrgaTime
            // 
            this.lblOrgaTime.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrgaTime.Location = new System.Drawing.Point(3, 299);
            this.lblOrgaTime.Name = "lblOrgaTime";
            this.lblOrgaTime.Size = new System.Drawing.Size(223, 39);
            this.lblOrgaTime.TabIndex = 7;
            this.lblOrgaTime.Text = "Orga: 00:00:00";
            this.lblOrgaTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(134, 96);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(280, 97);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 9;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // rndMeeting
            // 
            this.rndMeeting.AutoSize = true;
            this.rndMeeting.Location = new System.Drawing.Point(296, 48);
            this.rndMeeting.Name = "rndMeeting";
            this.rndMeeting.Size = new System.Drawing.Size(63, 17);
            this.rndMeeting.TabIndex = 14;
            this.rndMeeting.TabStop = true;
            this.rndMeeting.Text = "Meeting";
            this.rndMeeting.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(403, 27);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.einstellungenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(485, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imVordergrundToolStripMenuItem,
            this.designToolStripMenuItem});
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen";
            // 
            // imVordergrundToolStripMenuItem
            // 
            this.imVordergrundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.einToolStripMenuItem,
            this.ausToolStripMenuItem});
            this.imVordergrundToolStripMenuItem.Name = "imVordergrundToolStripMenuItem";
            this.imVordergrundToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imVordergrundToolStripMenuItem.Text = "Im Vordergrund";
            // 
            // einToolStripMenuItem
            // 
            this.einToolStripMenuItem.Name = "einToolStripMenuItem";
            this.einToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.einToolStripMenuItem.Text = "Ein";
            // 
            // ausToolStripMenuItem
            // 
            this.ausToolStripMenuItem.Name = "ausToolStripMenuItem";
            this.ausToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ausToolStripMenuItem.Text = "Aus";
            // 
            // designToolStripMenuItem
            // 
            this.designToolStripMenuItem.Name = "designToolStripMenuItem";
            this.designToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.designToolStripMenuItem.Text = "Design";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            // 
            // rndPause
            // 
            this.rndPause.AutoSize = true;
            this.rndPause.Location = new System.Drawing.Point(296, 19);
            this.rndPause.Name = "rndPause";
            this.rndPause.Size = new System.Drawing.Size(55, 17);
            this.rndPause.TabIndex = 15;
            this.rndPause.TabStop = true;
            this.rndPause.Text = "Pause";
            this.rndPause.UseVisualStyleBackColor = true;
            // 
            // lblMeetingTime
            // 
            this.lblMeetingTime.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeetingTime.Location = new System.Drawing.Point(250, 299);
            this.lblMeetingTime.Name = "lblMeetingTime";
            this.lblMeetingTime.Size = new System.Drawing.Size(223, 39);
            this.lblMeetingTime.TabIndex = 12;
            this.lblMeetingTime.Text = "Meeting: 00:00:00";
            this.lblMeetingTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 347);
            this.Controls.Add(this.lblMeetingTime);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblOrgaTime);
            this.Controls.Add(this.lblPauseTime);
            this.Controls.Add(this.lblCodingTime);
            this.Controls.Add(this.lblSonstigesTime);
            this.Controls.Add(this.lblLerningTime);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Focus Timer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLerningTime;
        private System.Windows.Forms.Label lblSonstigesTime;
        private System.Windows.Forms.RadioButton rndSonstiges;
        private System.Windows.Forms.RadioButton rndOrga;
        private System.Windows.Forms.RadioButton rndCoding;
        private System.Windows.Forms.RadioButton rdbLerning;
        private System.Windows.Forms.Label lblPauseTime;
        private System.Windows.Forms.Label lblCodingTime;
        private System.Windows.Forms.Label lblOrgaTime;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.RadioButton rndMeeting;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imVordergrundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ausToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem designToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.RadioButton rndPause;
        private System.Windows.Forms.Label lblMeetingTime;
        private System.Windows.Forms.Timer timer1;
    }
}

