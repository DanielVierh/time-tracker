
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
            this.lblHr = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rndPause = new System.Windows.Forms.RadioButton();
            this.rndMeeting = new System.Windows.Forms.RadioButton();
            this.rndSonstiges = new System.Windows.Forms.RadioButton();
            this.rndOrga = new System.Windows.Forms.RadioButton();
            this.rndCoding = new System.Windows.Forms.RadioButton();
            this.rdbLerning = new System.Windows.Forms.RadioButton();
            this.lbl_lerning = new System.Windows.Forms.Label();
            this.lbl_sonstiges = new System.Windows.Forms.Label();
            this.lbl_pause = new System.Windows.Forms.Label();
            this.lbl_coding = new System.Windows.Forms.Label();
            this.lbl_orga = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imVordergrundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ausToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hintergrundfarbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hellblauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schwarzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dunkelgrünToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tealToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.midnightBlueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cornflowerBlueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verkleinernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kleinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.großToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kleinToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.großToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organisiernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meetingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sonstigesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_meeting = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblMin = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInitReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHr
            // 
            this.lblHr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblHr.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHr.ForeColor = System.Drawing.Color.White;
            this.lblHr.Location = new System.Drawing.Point(124, 42);
            this.lblHr.Name = "lblHr";
            this.lblHr.Size = new System.Drawing.Size(65, 54);
            this.lblHr.TabIndex = 1;
            this.lblHr.Text = "00";
            this.lblHr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rndPause);
            this.groupBox1.Controls.Add(this.rndMeeting);
            this.groupBox1.Controls.Add(this.rndSonstiges);
            this.groupBox1.Controls.Add(this.rndOrga);
            this.groupBox1.Controls.Add(this.rndCoding);
            this.groupBox1.Controls.Add(this.rdbLerning);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(19, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 80);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Welcher Zeitaufwand";
            // 
            // rndPause
            // 
            this.rndPause.AutoSize = true;
            this.rndPause.ForeColor = System.Drawing.Color.White;
            this.rndPause.Location = new System.Drawing.Point(342, 22);
            this.rndPause.Name = "rndPause";
            this.rndPause.Size = new System.Drawing.Size(60, 17);
            this.rndPause.TabIndex = 15;
            this.rndPause.Text = "Pause";
            this.rndPause.UseVisualStyleBackColor = true;
            this.rndPause.CheckedChanged += new System.EventHandler(this.rndPause_CheckedChanged);
            // 
            // rndMeeting
            // 
            this.rndMeeting.AutoSize = true;
            this.rndMeeting.ForeColor = System.Drawing.Color.White;
            this.rndMeeting.Location = new System.Drawing.Point(342, 51);
            this.rndMeeting.Name = "rndMeeting";
            this.rndMeeting.Size = new System.Drawing.Size(70, 17);
            this.rndMeeting.TabIndex = 14;
            this.rndMeeting.Text = "Meeting";
            this.rndMeeting.UseVisualStyleBackColor = true;
            this.rndMeeting.CheckedChanged += new System.EventHandler(this.rndMeeting_CheckedChanged);
            // 
            // rndSonstiges
            // 
            this.rndSonstiges.AutoSize = true;
            this.rndSonstiges.ForeColor = System.Drawing.Color.White;
            this.rndSonstiges.Location = new System.Drawing.Point(188, 51);
            this.rndSonstiges.Name = "rndSonstiges";
            this.rndSonstiges.Size = new System.Drawing.Size(80, 17);
            this.rndSonstiges.TabIndex = 13;
            this.rndSonstiges.Text = "Sonstiges";
            this.rndSonstiges.UseVisualStyleBackColor = true;
            this.rndSonstiges.CheckedChanged += new System.EventHandler(this.rndSonstiges_CheckedChanged);
            // 
            // rndOrga
            // 
            this.rndOrga.AutoSize = true;
            this.rndOrga.ForeColor = System.Drawing.Color.White;
            this.rndOrga.Location = new System.Drawing.Point(188, 22);
            this.rndOrga.Name = "rndOrga";
            this.rndOrga.Size = new System.Drawing.Size(96, 17);
            this.rndOrga.TabIndex = 12;
            this.rndOrga.Text = "Organisieren";
            this.rndOrga.UseVisualStyleBackColor = true;
            this.rndOrga.CheckedChanged += new System.EventHandler(this.rndOrga_CheckedChanged);
            // 
            // rndCoding
            // 
            this.rndCoding.AutoSize = true;
            this.rndCoding.ForeColor = System.Drawing.Color.White;
            this.rndCoding.Location = new System.Drawing.Point(59, 51);
            this.rndCoding.Name = "rndCoding";
            this.rndCoding.Size = new System.Drawing.Size(61, 17);
            this.rndCoding.TabIndex = 11;
            this.rndCoding.Text = "Coden";
            this.rndCoding.UseVisualStyleBackColor = true;
            this.rndCoding.CheckedChanged += new System.EventHandler(this.rndCoding_CheckedChanged);
            // 
            // rdbLerning
            // 
            this.rdbLerning.AutoSize = true;
            this.rdbLerning.ForeColor = System.Drawing.Color.White;
            this.rdbLerning.Location = new System.Drawing.Point(59, 22);
            this.rdbLerning.Name = "rdbLerning";
            this.rdbLerning.Size = new System.Drawing.Size(64, 17);
            this.rdbLerning.TabIndex = 10;
            this.rdbLerning.Text = "Lernen";
            this.rdbLerning.UseVisualStyleBackColor = true;
            this.rdbLerning.CheckedChanged += new System.EventHandler(this.rdbLerning_CheckedChanged);
            // 
            // lbl_lerning
            // 
            this.lbl_lerning.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lerning.ForeColor = System.Drawing.Color.White;
            this.lbl_lerning.Location = new System.Drawing.Point(4, 229);
            this.lbl_lerning.Name = "lbl_lerning";
            this.lbl_lerning.Size = new System.Drawing.Size(223, 39);
            this.lbl_lerning.TabIndex = 3;
            this.lbl_lerning.Text = "Lernen: 00:00:00";
            this.lbl_lerning.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_sonstiges
            // 
            this.lbl_sonstiges.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sonstiges.ForeColor = System.Drawing.Color.White;
            this.lbl_sonstiges.Location = new System.Drawing.Point(250, 223);
            this.lbl_sonstiges.Name = "lbl_sonstiges";
            this.lbl_sonstiges.Size = new System.Drawing.Size(223, 39);
            this.lbl_sonstiges.TabIndex = 4;
            this.lbl_sonstiges.Text = "Sonstiges: 00:00:00";
            this.lbl_sonstiges.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_pause
            // 
            this.lbl_pause.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pause.ForeColor = System.Drawing.Color.White;
            this.lbl_pause.Location = new System.Drawing.Point(250, 260);
            this.lbl_pause.Name = "lbl_pause";
            this.lbl_pause.Size = new System.Drawing.Size(223, 39);
            this.lbl_pause.TabIndex = 6;
            this.lbl_pause.Text = "Pause: 00:00:00";
            this.lbl_pause.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_coding
            // 
            this.lbl_coding.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_coding.ForeColor = System.Drawing.Color.White;
            this.lbl_coding.Location = new System.Drawing.Point(4, 264);
            this.lbl_coding.Name = "lbl_coding";
            this.lbl_coding.Size = new System.Drawing.Size(223, 39);
            this.lbl_coding.TabIndex = 5;
            this.lbl_coding.Text = "Coden: 00:00:00";
            this.lbl_coding.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_orga
            // 
            this.lbl_orga.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orga.ForeColor = System.Drawing.Color.White;
            this.lbl_orga.Location = new System.Drawing.Point(3, 299);
            this.lbl_orga.Name = "lbl_orga";
            this.lbl_orga.Size = new System.Drawing.Size(223, 39);
            this.lbl_orga.TabIndex = 7;
            this.lbl_orga.Text = "Orga: 00:00:00";
            this.lbl_orga.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Green;
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnStart.Location = new System.Drawing.Point(134, 101);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(280, 102);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 9;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Maroon;
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnReset.Location = new System.Drawing.Point(407, 53);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Bestätigen";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SlateGray;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.einstellungenToolStripMenuItem,
            this.kleinToolStripMenuItem1,
            this.großToolStripMenuItem1,
            this.eventToolStripMenuItem});
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
            this.designToolStripMenuItem,
            this.verkleinernToolStripMenuItem});
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen";
            // 
            // imVordergrundToolStripMenuItem
            // 
            this.imVordergrundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.einToolStripMenuItem,
            this.ausToolStripMenuItem});
            this.imVordergrundToolStripMenuItem.Name = "imVordergrundToolStripMenuItem";
            this.imVordergrundToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.imVordergrundToolStripMenuItem.Text = "Im Vordergrund";
            // 
            // einToolStripMenuItem
            // 
            this.einToolStripMenuItem.Checked = true;
            this.einToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.einToolStripMenuItem.Name = "einToolStripMenuItem";
            this.einToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.einToolStripMenuItem.Text = "Ein";
            this.einToolStripMenuItem.Click += new System.EventHandler(this.einToolStripMenuItem_Click);
            // 
            // ausToolStripMenuItem
            // 
            this.ausToolStripMenuItem.Name = "ausToolStripMenuItem";
            this.ausToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.ausToolStripMenuItem.Text = "Aus";
            this.ausToolStripMenuItem.Click += new System.EventHandler(this.ausToolStripMenuItem_Click);
            // 
            // designToolStripMenuItem
            // 
            this.designToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hintergrundfarbeToolStripMenuItem});
            this.designToolStripMenuItem.Name = "designToolStripMenuItem";
            this.designToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.designToolStripMenuItem.Text = "Design";
            // 
            // hintergrundfarbeToolStripMenuItem
            // 
            this.hintergrundfarbeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hellblauToolStripMenuItem,
            this.schwarzToolStripMenuItem,
            this.grauToolStripMenuItem,
            this.dunkelgrünToolStripMenuItem,
            this.tealToolStripMenuItem,
            this.midnightBlueToolStripMenuItem,
            this.cornflowerBlueToolStripMenuItem});
            this.hintergrundfarbeToolStripMenuItem.Name = "hintergrundfarbeToolStripMenuItem";
            this.hintergrundfarbeToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.hintergrundfarbeToolStripMenuItem.Text = "Hintergrundfarbe";
            // 
            // hellblauToolStripMenuItem
            // 
            this.hellblauToolStripMenuItem.Name = "hellblauToolStripMenuItem";
            this.hellblauToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.hellblauToolStripMenuItem.Text = "Hellblau";
            this.hellblauToolStripMenuItem.Click += new System.EventHandler(this.hellblauToolStripMenuItem_Click);
            // 
            // schwarzToolStripMenuItem
            // 
            this.schwarzToolStripMenuItem.Name = "schwarzToolStripMenuItem";
            this.schwarzToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.schwarzToolStripMenuItem.Text = "Schwarz";
            this.schwarzToolStripMenuItem.Click += new System.EventHandler(this.schwarzToolStripMenuItem_Click);
            // 
            // grauToolStripMenuItem
            // 
            this.grauToolStripMenuItem.Name = "grauToolStripMenuItem";
            this.grauToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.grauToolStripMenuItem.Text = "Grau";
            this.grauToolStripMenuItem.Click += new System.EventHandler(this.grauToolStripMenuItem_Click);
            // 
            // dunkelgrünToolStripMenuItem
            // 
            this.dunkelgrünToolStripMenuItem.Name = "dunkelgrünToolStripMenuItem";
            this.dunkelgrünToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.dunkelgrünToolStripMenuItem.Text = "Dunkelgrün";
            this.dunkelgrünToolStripMenuItem.Click += new System.EventHandler(this.dunkelgrünToolStripMenuItem_Click);
            // 
            // tealToolStripMenuItem
            // 
            this.tealToolStripMenuItem.Name = "tealToolStripMenuItem";
            this.tealToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.tealToolStripMenuItem.Text = "Teal";
            this.tealToolStripMenuItem.Click += new System.EventHandler(this.tealToolStripMenuItem_Click);
            // 
            // midnightBlueToolStripMenuItem
            // 
            this.midnightBlueToolStripMenuItem.Name = "midnightBlueToolStripMenuItem";
            this.midnightBlueToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.midnightBlueToolStripMenuItem.Text = "MidnightBlue";
            this.midnightBlueToolStripMenuItem.Click += new System.EventHandler(this.midnightBlueToolStripMenuItem_Click);
            // 
            // cornflowerBlueToolStripMenuItem
            // 
            this.cornflowerBlueToolStripMenuItem.Name = "cornflowerBlueToolStripMenuItem";
            this.cornflowerBlueToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.cornflowerBlueToolStripMenuItem.Text = "CornflowerBlue";
            this.cornflowerBlueToolStripMenuItem.Click += new System.EventHandler(this.cornflowerBlueToolStripMenuItem_Click);
            // 
            // verkleinernToolStripMenuItem
            // 
            this.verkleinernToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kleinToolStripMenuItem,
            this.großToolStripMenuItem});
            this.verkleinernToolStripMenuItem.Name = "verkleinernToolStripMenuItem";
            this.verkleinernToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.verkleinernToolStripMenuItem.Text = "Größe";
            // 
            // kleinToolStripMenuItem
            // 
            this.kleinToolStripMenuItem.Name = "kleinToolStripMenuItem";
            this.kleinToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.kleinToolStripMenuItem.Text = "Klein";
            this.kleinToolStripMenuItem.Click += new System.EventHandler(this.kleinToolStripMenuItem_Click);
            // 
            // großToolStripMenuItem
            // 
            this.großToolStripMenuItem.Name = "großToolStripMenuItem";
            this.großToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.großToolStripMenuItem.Text = "Groß";
            this.großToolStripMenuItem.Click += new System.EventHandler(this.großToolStripMenuItem_Click);
            // 
            // kleinToolStripMenuItem1
            // 
            this.kleinToolStripMenuItem1.Name = "kleinToolStripMenuItem1";
            this.kleinToolStripMenuItem1.Size = new System.Drawing.Size(47, 20);
            this.kleinToolStripMenuItem1.Text = "Klein";
            this.kleinToolStripMenuItem1.Click += new System.EventHandler(this.kleinToolStripMenuItem1_Click);
            // 
            // großToolStripMenuItem1
            // 
            this.großToolStripMenuItem1.Name = "großToolStripMenuItem1";
            this.großToolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.großToolStripMenuItem1.Text = "Groß";
            this.großToolStripMenuItem1.Click += new System.EventHandler(this.großToolStripMenuItem1_Click);
            // 
            // eventToolStripMenuItem
            // 
            this.eventToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lernenToolStripMenuItem,
            this.codenToolStripMenuItem,
            this.organisiernToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.meetingToolStripMenuItem,
            this.sonstigesToolStripMenuItem});
            this.eventToolStripMenuItem.Name = "eventToolStripMenuItem";
            this.eventToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.eventToolStripMenuItem.Text = "Event";
            // 
            // lernenToolStripMenuItem
            // 
            this.lernenToolStripMenuItem.Name = "lernenToolStripMenuItem";
            this.lernenToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.lernenToolStripMenuItem.Text = "Lernen";
            this.lernenToolStripMenuItem.Click += new System.EventHandler(this.lernenToolStripMenuItem_Click);
            // 
            // codenToolStripMenuItem
            // 
            this.codenToolStripMenuItem.Name = "codenToolStripMenuItem";
            this.codenToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.codenToolStripMenuItem.Text = "Coden";
            this.codenToolStripMenuItem.Click += new System.EventHandler(this.codenToolStripMenuItem_Click);
            // 
            // organisiernToolStripMenuItem
            // 
            this.organisiernToolStripMenuItem.Name = "organisiernToolStripMenuItem";
            this.organisiernToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.organisiernToolStripMenuItem.Text = "Organisieren";
            this.organisiernToolStripMenuItem.Click += new System.EventHandler(this.organisiernToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // meetingToolStripMenuItem
            // 
            this.meetingToolStripMenuItem.Name = "meetingToolStripMenuItem";
            this.meetingToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.meetingToolStripMenuItem.Text = "Meeting";
            this.meetingToolStripMenuItem.Click += new System.EventHandler(this.meetingToolStripMenuItem_Click);
            // 
            // sonstigesToolStripMenuItem
            // 
            this.sonstigesToolStripMenuItem.Name = "sonstigesToolStripMenuItem";
            this.sonstigesToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.sonstigesToolStripMenuItem.Text = "Sonstiges";
            this.sonstigesToolStripMenuItem.Click += new System.EventHandler(this.sonstigesToolStripMenuItem_Click);
            // 
            // lbl_meeting
            // 
            this.lbl_meeting.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_meeting.ForeColor = System.Drawing.Color.White;
            this.lbl_meeting.Location = new System.Drawing.Point(250, 299);
            this.lbl_meeting.Name = "lbl_meeting";
            this.lbl_meeting.Size = new System.Drawing.Size(223, 39);
            this.lbl_meeting.TabIndex = 12;
            this.lbl_meeting.Text = "Meeting: 00:00:00";
            this.lbl_meeting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblMin
            // 
            this.lblMin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMin.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.Color.White;
            this.lblMin.Location = new System.Drawing.Point(216, 42);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(65, 54);
            this.lblMin.TabIndex = 13;
            this.lblMin.Text = "00";
            this.lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSec
            // 
            this.lblSec.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSec.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSec.ForeColor = System.Drawing.Color.White;
            this.lblSec.Location = new System.Drawing.Point(308, 42);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(65, 54);
            this.lblSec.TabIndex = 14;
            this.lblSec.Text = "00";
            this.lblSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(281, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 54);
            this.label1.TabIndex = 15;
            this.label1.Text = ":";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(189, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 54);
            this.label2.TabIndex = 16;
            this.label2.Text = ":";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInitReset
            // 
            this.btnInitReset.BackColor = System.Drawing.Color.Maroon;
            this.btnInitReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnInitReset.Location = new System.Drawing.Point(407, 24);
            this.btnInitReset.Name = "btnInitReset";
            this.btnInitReset.Size = new System.Drawing.Size(75, 23);
            this.btnInitReset.TabIndex = 17;
            this.btnInitReset.Text = "Reset";
            this.btnInitReset.UseVisualStyleBackColor = false;
            this.btnInitReset.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(485, 347);
            this.Controls.Add(this.btnInitReset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lbl_meeting);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbl_orga);
            this.Controls.Add(this.lbl_pause);
            this.Controls.Add(this.lbl_coding);
            this.Controls.Add(this.lbl_sonstiges);
            this.Controls.Add(this.lbl_lerning);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblHr);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Opacity = 0.9D;
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
        private System.Windows.Forms.Label lblHr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_lerning;
        private System.Windows.Forms.Label lbl_sonstiges;
        private System.Windows.Forms.RadioButton rndSonstiges;
        private System.Windows.Forms.RadioButton rndOrga;
        private System.Windows.Forms.RadioButton rndCoding;
        private System.Windows.Forms.RadioButton rdbLerning;
        private System.Windows.Forms.Label lbl_pause;
        private System.Windows.Forms.Label lbl_coding;
        private System.Windows.Forms.Label lbl_orga;
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
        private System.Windows.Forms.RadioButton rndPause;
        private System.Windows.Forms.Label lbl_meeting;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInitReset;
        private System.Windows.Forms.ToolStripMenuItem verkleinernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kleinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem großToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kleinToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem großToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hintergrundfarbeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hellblauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schwarzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dunkelgrünToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tealToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem midnightBlueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cornflowerBlueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lernenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organisiernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meetingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sonstigesToolStripMenuItem;
    }
}

