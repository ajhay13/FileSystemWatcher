namespace filewatcher
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnsave = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.txtfoldertowatch = new System.Windows.Forms.TextBox();
            this.btnftowatch = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Setupmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineActivitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblwatch = new System.Windows.Forms.Label();
            this.lblbatch = new System.Windows.Forms.Label();
            this.panelconfig = new System.Windows.Forms.Panel();
            this.lstnotification = new System.Windows.Forms.ListBox();
            this.txtbatchfile = new System.Windows.Forms.TextBox();
            this.btnbatch = new System.Windows.Forms.Button();
            this.panelwatchlist = new System.Windows.Forms.Panel();
            this.btnremove5 = new System.Windows.Forms.Button();
            this.btnedt5 = new System.Windows.Forms.Button();
            this.btnstart5 = new System.Windows.Forms.Button();
            this.txtevent5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtpath5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnremove4 = new System.Windows.Forms.Button();
            this.btnedit4 = new System.Windows.Forms.Button();
            this.btnstart4 = new System.Windows.Forms.Button();
            this.txtevent4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtpath4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnremove3 = new System.Windows.Forms.Button();
            this.btnedit3 = new System.Windows.Forms.Button();
            this.btnstart3 = new System.Windows.Forms.Button();
            this.txtevent3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpath3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnremove2 = new System.Windows.Forms.Button();
            this.btnedit2 = new System.Windows.Forms.Button();
            this.btnstart2 = new System.Windows.Forms.Button();
            this.txtevent2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpath2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnremove1 = new System.Windows.Forms.Button();
            this.btnedt1 = new System.Windows.Forms.Button();
            this.btnstart1 = new System.Windows.Forms.Button();
            this.txtevent1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpath1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrEditNotify = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panelconfig.SuspendLayout();
            this.panelwatchlist.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(400, 462);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(120, 30);
            this.btnsave.TabIndex = 9;
            this.btnsave.Text = "Save Config";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(541, 462);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(120, 30);
            this.btncancel.TabIndex = 14;
            this.btncancel.Text = "Close";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // txtfoldertowatch
            // 
            this.txtfoldertowatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfoldertowatch.Location = new System.Drawing.Point(12, 286);
            this.txtfoldertowatch.Name = "txtfoldertowatch";
            this.txtfoldertowatch.Size = new System.Drawing.Size(572, 28);
            this.txtfoldertowatch.TabIndex = 15;
            // 
            // btnftowatch
            // 
            this.btnftowatch.BackColor = System.Drawing.Color.Transparent;
            this.btnftowatch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnftowatch.BackgroundImage")));
            this.btnftowatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnftowatch.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnftowatch.FlatAppearance.BorderSize = 0;
            this.btnftowatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnftowatch.ForeColor = System.Drawing.Color.Transparent;
            this.btnftowatch.Location = new System.Drawing.Point(589, 278);
            this.btnftowatch.Name = "btnftowatch";
            this.btnftowatch.Size = new System.Drawing.Size(45, 43);
            this.btnftowatch.TabIndex = 16;
            this.btnftowatch.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnftowatch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnftowatch.UseVisualStyleBackColor = false;
            this.btnftowatch.Click += new System.EventHandler(this.btnftowatch_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Setupmenu,
            this.onlineActivitiesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(674, 30);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Setupmenu
            // 
            this.Setupmenu.ForeColor = System.Drawing.Color.White;
            this.Setupmenu.Name = "Setupmenu";
            this.Setupmenu.Size = new System.Drawing.Size(156, 26);
            this.Setupmenu.Text = "Setup Configuration";
            this.Setupmenu.Click += new System.EventHandler(this.Setupmenu_Click);
            // 
            // onlineActivitiesToolStripMenuItem
            // 
            this.onlineActivitiesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.onlineActivitiesToolStripMenuItem.Name = "onlineActivitiesToolStripMenuItem";
            this.onlineActivitiesToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.onlineActivitiesToolStripMenuItem.Text = "Available Watch List";
            this.onlineActivitiesToolStripMenuItem.Click += new System.EventHandler(this.onlineActivitiesToolStripMenuItem_Click);
            // 
            // lblwatch
            // 
            this.lblwatch.AutoSize = true;
            this.lblwatch.ForeColor = System.Drawing.Color.White;
            this.lblwatch.Location = new System.Drawing.Point(8, 266);
            this.lblwatch.Name = "lblwatch";
            this.lblwatch.Size = new System.Drawing.Size(108, 17);
            this.lblwatch.TabIndex = 20;
            this.lblwatch.Text = "Folder to Watch";
            // 
            // lblbatch
            // 
            this.lblbatch.AutoSize = true;
            this.lblbatch.ForeColor = System.Drawing.Color.White;
            this.lblbatch.Location = new System.Drawing.Point(8, 345);
            this.lblbatch.Name = "lblbatch";
            this.lblbatch.Size = new System.Drawing.Size(129, 17);
            this.lblbatch.TabIndex = 21;
            this.lblbatch.Text = "Process to Execute";
            // 
            // panelconfig
            // 
            this.panelconfig.Controls.Add(this.lstnotification);
            this.panelconfig.Controls.Add(this.txtbatchfile);
            this.panelconfig.Controls.Add(this.btnbatch);
            this.panelconfig.Controls.Add(this.lblbatch);
            this.panelconfig.Controls.Add(this.lblwatch);
            this.panelconfig.Controls.Add(this.btnftowatch);
            this.panelconfig.Controls.Add(this.txtfoldertowatch);
            this.panelconfig.Controls.Add(this.btncancel);
            this.panelconfig.Controls.Add(this.btnsave);
            this.panelconfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelconfig.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelconfig.Location = new System.Drawing.Point(0, 30);
            this.panelconfig.Name = "panelconfig";
            this.panelconfig.Size = new System.Drawing.Size(674, 715);
            this.panelconfig.TabIndex = 22;
            this.panelconfig.Visible = false;
            // 
            // lstnotification
            // 
            this.lstnotification.FormattingEnabled = true;
            this.lstnotification.ItemHeight = 16;
            this.lstnotification.Location = new System.Drawing.Point(12, 21);
            this.lstnotification.Name = "lstnotification";
            this.lstnotification.Size = new System.Drawing.Size(649, 228);
            this.lstnotification.TabIndex = 24;
            this.lstnotification.TabStop = false;
            this.lstnotification.SelectedIndexChanged += new System.EventHandler(this.lstnotification_SelectedIndexChanged);
            // 
            // txtbatchfile
            // 
            this.txtbatchfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbatchfile.Location = new System.Drawing.Point(12, 365);
            this.txtbatchfile.Name = "txtbatchfile";
            this.txtbatchfile.Size = new System.Drawing.Size(572, 28);
            this.txtbatchfile.TabIndex = 23;
            // 
            // btnbatch
            // 
            this.btnbatch.BackColor = System.Drawing.Color.Transparent;
            this.btnbatch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbatch.BackgroundImage")));
            this.btnbatch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbatch.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnbatch.FlatAppearance.BorderSize = 0;
            this.btnbatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbatch.ForeColor = System.Drawing.Color.Transparent;
            this.btnbatch.Location = new System.Drawing.Point(589, 357);
            this.btnbatch.Name = "btnbatch";
            this.btnbatch.Size = new System.Drawing.Size(45, 43);
            this.btnbatch.TabIndex = 22;
            this.btnbatch.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnbatch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnbatch.UseVisualStyleBackColor = false;
            this.btnbatch.Click += new System.EventHandler(this.btnbatch_Click);
            // 
            // panelwatchlist
            // 
            this.panelwatchlist.Controls.Add(this.btnremove5);
            this.panelwatchlist.Controls.Add(this.btnedt5);
            this.panelwatchlist.Controls.Add(this.btnstart5);
            this.panelwatchlist.Controls.Add(this.txtevent5);
            this.panelwatchlist.Controls.Add(this.label9);
            this.panelwatchlist.Controls.Add(this.txtpath5);
            this.panelwatchlist.Controls.Add(this.label10);
            this.panelwatchlist.Controls.Add(this.btnremove4);
            this.panelwatchlist.Controls.Add(this.btnedit4);
            this.panelwatchlist.Controls.Add(this.btnstart4);
            this.panelwatchlist.Controls.Add(this.txtevent4);
            this.panelwatchlist.Controls.Add(this.label7);
            this.panelwatchlist.Controls.Add(this.txtpath4);
            this.panelwatchlist.Controls.Add(this.label8);
            this.panelwatchlist.Controls.Add(this.btnremove3);
            this.panelwatchlist.Controls.Add(this.btnedit3);
            this.panelwatchlist.Controls.Add(this.btnstart3);
            this.panelwatchlist.Controls.Add(this.txtevent3);
            this.panelwatchlist.Controls.Add(this.label5);
            this.panelwatchlist.Controls.Add(this.txtpath3);
            this.panelwatchlist.Controls.Add(this.label6);
            this.panelwatchlist.Controls.Add(this.btnremove2);
            this.panelwatchlist.Controls.Add(this.btnedit2);
            this.panelwatchlist.Controls.Add(this.btnstart2);
            this.panelwatchlist.Controls.Add(this.txtevent2);
            this.panelwatchlist.Controls.Add(this.label3);
            this.panelwatchlist.Controls.Add(this.txtpath2);
            this.panelwatchlist.Controls.Add(this.label4);
            this.panelwatchlist.Controls.Add(this.btnremove1);
            this.panelwatchlist.Controls.Add(this.btnedt1);
            this.panelwatchlist.Controls.Add(this.btnstart1);
            this.panelwatchlist.Controls.Add(this.txtevent1);
            this.panelwatchlist.Controls.Add(this.label2);
            this.panelwatchlist.Controls.Add(this.txtpath1);
            this.panelwatchlist.Controls.Add(this.label1);
            this.panelwatchlist.Location = new System.Drawing.Point(16, 0);
            this.panelwatchlist.Name = "panelwatchlist";
            this.panelwatchlist.Size = new System.Drawing.Size(51, 722);
            this.panelwatchlist.TabIndex = 23;
            this.panelwatchlist.Visible = false;
            // 
            // btnremove5
            // 
            this.btnremove5.Location = new System.Drawing.Point(338, 623);
            this.btnremove5.Name = "btnremove5";
            this.btnremove5.Size = new System.Drawing.Size(89, 62);
            this.btnremove5.TabIndex = 34;
            this.btnremove5.Text = "Remove";
            this.btnremove5.UseVisualStyleBackColor = true;
            // 
            // btnedt5
            // 
            this.btnedt5.Location = new System.Drawing.Point(216, 623);
            this.btnedt5.Name = "btnedt5";
            this.btnedt5.Size = new System.Drawing.Size(89, 62);
            this.btnedt5.TabIndex = 33;
            this.btnedt5.Text = "Edit";
            this.btnedt5.UseVisualStyleBackColor = true;
            // 
            // btnstart5
            // 
            this.btnstart5.Location = new System.Drawing.Point(95, 623);
            this.btnstart5.Name = "btnstart5";
            this.btnstart5.Size = new System.Drawing.Size(89, 62);
            this.btnstart5.TabIndex = 32;
            this.btnstart5.Text = "Start";
            this.btnstart5.UseVisualStyleBackColor = true;
            this.btnstart5.Click += new System.EventHandler(this.btnstart5_Click);
            // 
            // txtevent5
            // 
            this.txtevent5.Location = new System.Drawing.Point(95, 586);
            this.txtevent5.Name = "txtevent5";
            this.txtevent5.Size = new System.Drawing.Size(470, 22);
            this.txtevent5.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(34, 586);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "Event";
            // 
            // txtpath5
            // 
            this.txtpath5.Location = new System.Drawing.Point(95, 548);
            this.txtpath5.Name = "txtpath5";
            this.txtpath5.Size = new System.Drawing.Size(470, 22);
            this.txtpath5.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(34, 548);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "Path";
            // 
            // btnremove4
            // 
            this.btnremove4.Location = new System.Drawing.Point(338, 485);
            this.btnremove4.Name = "btnremove4";
            this.btnremove4.Size = new System.Drawing.Size(89, 57);
            this.btnremove4.TabIndex = 27;
            this.btnremove4.Text = "Remove";
            this.btnremove4.UseVisualStyleBackColor = true;
            // 
            // btnedit4
            // 
            this.btnedit4.Location = new System.Drawing.Point(216, 485);
            this.btnedit4.Name = "btnedit4";
            this.btnedit4.Size = new System.Drawing.Size(89, 57);
            this.btnedit4.TabIndex = 26;
            this.btnedit4.Text = "Edit";
            this.btnedit4.UseVisualStyleBackColor = true;
            // 
            // btnstart4
            // 
            this.btnstart4.Location = new System.Drawing.Point(95, 485);
            this.btnstart4.Name = "btnstart4";
            this.btnstart4.Size = new System.Drawing.Size(89, 57);
            this.btnstart4.TabIndex = 25;
            this.btnstart4.Text = "Start";
            this.btnstart4.UseVisualStyleBackColor = true;
            this.btnstart4.Click += new System.EventHandler(this.btnstart4_Click);
            // 
            // txtevent4
            // 
            this.txtevent4.Location = new System.Drawing.Point(95, 448);
            this.txtevent4.Name = "txtevent4";
            this.txtevent4.Size = new System.Drawing.Size(470, 22);
            this.txtevent4.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(34, 448);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Event";
            // 
            // txtpath4
            // 
            this.txtpath4.Location = new System.Drawing.Point(95, 410);
            this.txtpath4.Name = "txtpath4";
            this.txtpath4.Size = new System.Drawing.Size(470, 22);
            this.txtpath4.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(34, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Path";
            // 
            // btnremove3
            // 
            this.btnremove3.Location = new System.Drawing.Point(338, 355);
            this.btnremove3.Name = "btnremove3";
            this.btnremove3.Size = new System.Drawing.Size(89, 49);
            this.btnremove3.TabIndex = 20;
            this.btnremove3.Text = "Remove";
            this.btnremove3.UseVisualStyleBackColor = true;
            // 
            // btnedit3
            // 
            this.btnedit3.Location = new System.Drawing.Point(216, 355);
            this.btnedit3.Name = "btnedit3";
            this.btnedit3.Size = new System.Drawing.Size(89, 49);
            this.btnedit3.TabIndex = 19;
            this.btnedit3.Text = "Edit";
            this.btnedit3.UseVisualStyleBackColor = true;
            // 
            // btnstart3
            // 
            this.btnstart3.Location = new System.Drawing.Point(95, 355);
            this.btnstart3.Name = "btnstart3";
            this.btnstart3.Size = new System.Drawing.Size(89, 49);
            this.btnstart3.TabIndex = 18;
            this.btnstart3.Text = "Start";
            this.btnstart3.UseVisualStyleBackColor = true;
            this.btnstart3.Click += new System.EventHandler(this.btnstart3_Click);
            // 
            // txtevent3
            // 
            this.txtevent3.Location = new System.Drawing.Point(95, 318);
            this.txtevent3.Name = "txtevent3";
            this.txtevent3.Size = new System.Drawing.Size(470, 22);
            this.txtevent3.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(34, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Event";
            // 
            // txtpath3
            // 
            this.txtpath3.Location = new System.Drawing.Point(95, 280);
            this.txtpath3.Name = "txtpath3";
            this.txtpath3.Size = new System.Drawing.Size(470, 22);
            this.txtpath3.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(34, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Path";
            // 
            // btnremove2
            // 
            this.btnremove2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnremove2.Location = new System.Drawing.Point(338, 220);
            this.btnremove2.Name = "btnremove2";
            this.btnremove2.Size = new System.Drawing.Size(89, 51);
            this.btnremove2.TabIndex = 13;
            this.btnremove2.Text = "Remove";
            this.btnremove2.UseVisualStyleBackColor = true;
            // 
            // btnedit2
            // 
            this.btnedit2.Location = new System.Drawing.Point(216, 220);
            this.btnedit2.Name = "btnedit2";
            this.btnedit2.Size = new System.Drawing.Size(89, 51);
            this.btnedit2.TabIndex = 12;
            this.btnedit2.Text = "Edit";
            this.btnedit2.UseVisualStyleBackColor = true;
            // 
            // btnstart2
            // 
            this.btnstart2.Location = new System.Drawing.Point(95, 220);
            this.btnstart2.Name = "btnstart2";
            this.btnstart2.Size = new System.Drawing.Size(89, 51);
            this.btnstart2.TabIndex = 11;
            this.btnstart2.Text = "Start";
            this.btnstart2.UseVisualStyleBackColor = true;
            this.btnstart2.Click += new System.EventHandler(this.btnstart2_Click);
            // 
            // txtevent2
            // 
            this.txtevent2.Location = new System.Drawing.Point(95, 183);
            this.txtevent2.Name = "txtevent2";
            this.txtevent2.Size = new System.Drawing.Size(470, 22);
            this.txtevent2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Event";
            // 
            // txtpath2
            // 
            this.txtpath2.Location = new System.Drawing.Point(95, 145);
            this.txtpath2.Name = "txtpath2";
            this.txtpath2.Size = new System.Drawing.Size(470, 22);
            this.txtpath2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(34, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Path";
            // 
            // btnremove1
            // 
            this.btnremove1.Location = new System.Drawing.Point(338, 95);
            this.btnremove1.Name = "btnremove1";
            this.btnremove1.Size = new System.Drawing.Size(89, 44);
            this.btnremove1.TabIndex = 6;
            this.btnremove1.Text = "Remove";
            this.btnremove1.UseVisualStyleBackColor = true;
            // 
            // btnedt1
            // 
            this.btnedt1.Location = new System.Drawing.Point(216, 95);
            this.btnedt1.Name = "btnedt1";
            this.btnedt1.Size = new System.Drawing.Size(89, 44);
            this.btnedt1.TabIndex = 5;
            this.btnedt1.Text = "Edit";
            this.btnedt1.UseVisualStyleBackColor = true;
            // 
            // btnstart1
            // 
            this.btnstart1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnstart1.Location = new System.Drawing.Point(95, 95);
            this.btnstart1.Name = "btnstart1";
            this.btnstart1.Size = new System.Drawing.Size(89, 44);
            this.btnstart1.TabIndex = 4;
            this.btnstart1.Text = "Start";
            this.btnstart1.UseVisualStyleBackColor = true;
            this.btnstart1.Click += new System.EventHandler(this.btnstart1_Click);
            // 
            // txtevent1
            // 
            this.txtevent1.Location = new System.Drawing.Point(95, 49);
            this.txtevent1.Name = "txtevent1";
            this.txtevent1.Size = new System.Drawing.Size(470, 22);
            this.txtevent1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Event";
            // 
            // txtpath1
            // 
            this.txtpath1.Location = new System.Drawing.Point(95, 11);
            this.txtpath1.Name = "txtpath1";
            this.txtpath1.Size = new System.Drawing.Size(470, 22);
            this.txtpath1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path";
            // 
            // tmrEditNotify
            // 
            this.tmrEditNotify.Enabled = true;
            this.tmrEditNotify.Tick += new System.EventHandler(this.tmrEditNotify_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(674, 745);
            this.Controls.Add(this.panelwatchlist);
            this.Controls.Add(this.panelconfig);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Watcher";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelconfig.ResumeLayout(false);
            this.panelconfig.PerformLayout();
            this.panelwatchlist.ResumeLayout(false);
            this.panelwatchlist.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.TextBox txtfoldertowatch;
        private System.Windows.Forms.Button btnftowatch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Setupmenu;
        private System.Windows.Forms.Label lblwatch;
        private System.Windows.Forms.Label lblbatch;
        private System.Windows.Forms.ToolStripMenuItem onlineActivitiesToolStripMenuItem;
        private System.Windows.Forms.Panel panelconfig;
        private System.Windows.Forms.Panel panelwatchlist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnremove5;
        private System.Windows.Forms.Button btnedt5;
        private System.Windows.Forms.Button btnstart5;
        private System.Windows.Forms.TextBox txtevent5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtpath5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnremove4;
        private System.Windows.Forms.Button btnedit4;
        private System.Windows.Forms.Button btnstart4;
        private System.Windows.Forms.TextBox txtevent4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtpath4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnremove3;
        private System.Windows.Forms.Button btnedit3;
        private System.Windows.Forms.Button btnstart3;
        private System.Windows.Forms.TextBox txtevent3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpath3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnremove2;
        private System.Windows.Forms.Button btnedit2;
        private System.Windows.Forms.Button btnstart2;
        private System.Windows.Forms.TextBox txtevent2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpath2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnremove1;
        private System.Windows.Forms.Button btnedt1;
        private System.Windows.Forms.TextBox txtevent1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpath1;
        private System.Windows.Forms.TextBox txtbatchfile;
        private System.Windows.Forms.Button btnbatch;
        private System.Windows.Forms.ListBox lstnotification;
        private System.Windows.Forms.Timer tmrEditNotify;
        private System.Windows.Forms.Button btnstart1;
    }
}

