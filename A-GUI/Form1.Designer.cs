﻿
namespace A_GUI
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notificationlabel = new System.Windows.Forms.Label();
            this.toppanel = new System.Windows.Forms.Panel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.settingsbutton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.toplabel = new System.Windows.Forms.Label();
            this.topicon = new System.Windows.Forms.PictureBox();
            this.minimizebutton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.maximizebutton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.closebutton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.resizebox = new Guna.UI2.WinForms.Guna2ResizeBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2CheckBox3 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CheckBox2 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.notificationpanel = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topicon)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.notificationpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // notificationlabel
            // 
            this.notificationlabel.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.notificationlabel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.notificationlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.notificationlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.notificationlabel.Location = new System.Drawing.Point(3, 4);
            this.notificationlabel.Name = "notificationlabel";
            this.notificationlabel.Size = new System.Drawing.Size(97, 17);
            this.notificationlabel.TabIndex = 1;
            this.notificationlabel.Text = "Success/Error";
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(230)))), ((int)(((byte)(134)))));
            this.toppanel.Controls.Add(this.guna2ImageButton1);
            this.toppanel.Controls.Add(this.settingsbutton);
            this.toppanel.Controls.Add(this.toplabel);
            this.toppanel.Controls.Add(this.topicon);
            this.toppanel.Controls.Add(this.minimizebutton);
            this.toppanel.Controls.Add(this.maximizebutton);
            this.toppanel.Controls.Add(this.closebutton);
            this.guna2Transition1.SetDecoration(this.toppanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(850, 29);
            this.toppanel.TabIndex = 1;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2Transition1.SetDecoration(this.guna2ImageButton1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ImageButton1.HoverState.Image = global::A_GUI.Properties.Resources.outline_new_releases_black_24dp;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = global::A_GUI.Properties.Resources.outline_new_releases_black_24dp;
            this.guna2ImageButton1.Location = new System.Drawing.Point(682, 3);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(29, 23);
            this.guna2ImageButton1.TabIndex = 7;
            this.guna2HtmlToolTip1.SetToolTip(this.guna2ImageButton1, "You can download it on github!\r\n<br>\r\ngithub.com/I-Am-Zee/Advanced-GUI-Winforms-A" +
        "pp\r\n");
            this.guna2ImageButton1.Visible = false;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click_1);
            // 
            // settingsbutton
            // 
            this.settingsbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsbutton.CheckedState.Parent = this.settingsbutton;
            this.guna2Transition1.SetDecoration(this.settingsbutton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.settingsbutton.HoverState.Image = global::A_GUI.Properties.Resources.baseline_settings_black_24dp;
            this.settingsbutton.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.settingsbutton.HoverState.Parent = this.settingsbutton;
            this.settingsbutton.Image = global::A_GUI.Properties.Resources.baseline_settings_black_24dp;
            this.settingsbutton.Location = new System.Drawing.Point(709, 3);
            this.settingsbutton.Name = "settingsbutton";
            this.settingsbutton.PressedState.Parent = this.settingsbutton;
            this.settingsbutton.Size = new System.Drawing.Size(29, 23);
            this.settingsbutton.TabIndex = 5;
            this.settingsbutton.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // toplabel
            // 
            this.toplabel.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.toplabel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.toplabel.Location = new System.Drawing.Point(36, 8);
            this.toplabel.Name = "toplabel";
            this.toplabel.Size = new System.Drawing.Size(108, 13);
            this.toplabel.TabIndex = 4;
            this.toplabel.Text = "Advanced GUI Editor";
            // 
            // topicon
            // 
            this.guna2Transition1.SetDecoration(this.topicon, Guna.UI2.AnimatorNS.DecorationType.None);
            this.topicon.Image = global::A_GUI.Properties.Resources._83636;
            this.topicon.Location = new System.Drawing.Point(3, 3);
            this.topicon.Name = "topicon";
            this.topicon.Size = new System.Drawing.Size(31, 23);
            this.topicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topicon.TabIndex = 3;
            this.topicon.TabStop = false;
            // 
            // minimizebutton
            // 
            this.minimizebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizebutton.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2Transition1.SetDecoration(this.minimizebutton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.minimizebutton.FillColor = System.Drawing.Color.Transparent;
            this.minimizebutton.HoverState.Parent = this.minimizebutton;
            this.minimizebutton.IconColor = System.Drawing.Color.Black;
            this.minimizebutton.Location = new System.Drawing.Point(736, 3);
            this.minimizebutton.Name = "minimizebutton";
            this.minimizebutton.ShadowDecoration.Parent = this.minimizebutton;
            this.minimizebutton.Size = new System.Drawing.Size(37, 23);
            this.minimizebutton.TabIndex = 2;
            // 
            // maximizebutton
            // 
            this.maximizebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizebutton.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2Transition1.SetDecoration(this.maximizebutton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.maximizebutton.FillColor = System.Drawing.Color.Transparent;
            this.maximizebutton.HoverState.Parent = this.maximizebutton;
            this.maximizebutton.IconColor = System.Drawing.Color.Black;
            this.maximizebutton.Location = new System.Drawing.Point(773, 3);
            this.maximizebutton.Name = "maximizebutton";
            this.maximizebutton.ShadowDecoration.Parent = this.maximizebutton;
            this.maximizebutton.Size = new System.Drawing.Size(37, 23);
            this.maximizebutton.TabIndex = 1;
            // 
            // closebutton
            // 
            this.closebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Transition1.SetDecoration(this.closebutton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.closebutton.FillColor = System.Drawing.Color.Transparent;
            this.closebutton.HoverState.Parent = this.closebutton;
            this.closebutton.IconColor = System.Drawing.Color.Black;
            this.closebutton.Location = new System.Drawing.Point(810, 3);
            this.closebutton.Name = "closebutton";
            this.closebutton.ShadowDecoration.Parent = this.closebutton;
            this.closebutton.Size = new System.Drawing.Size(37, 23);
            this.closebutton.TabIndex = 0;
            // 
            // resizebox
            // 
            this.resizebox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resizebox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(47)))));
            this.guna2Transition1.SetDecoration(this.resizebox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.resizebox.FillColor = System.Drawing.Color.White;
            this.resizebox.ForeColor = System.Drawing.Color.Empty;
            this.resizebox.Location = new System.Drawing.Point(831, 480);
            this.resizebox.Name = "resizebox";
            this.resizebox.Size = new System.Drawing.Size(20, 20);
            this.resizebox.TabIndex = 2;
            this.resizebox.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.toppanel;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panel2.Controls.Add(this.guna2CheckBox3);
            this.panel2.Controls.Add(this.guna2CheckBox2);
            this.panel2.Controls.Add(this.guna2CheckBox1);
            this.guna2Transition1.SetDecoration(this.panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 73);
            this.panel2.TabIndex = 7;
            // 
            // guna2CheckBox3
            // 
            this.guna2CheckBox3.Animated = true;
            this.guna2CheckBox3.AutoSize = true;
            this.guna2CheckBox3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(230)))), ((int)(((byte)(134)))));
            this.guna2CheckBox3.CheckedState.BorderRadius = 2;
            this.guna2CheckBox3.CheckedState.BorderThickness = 1;
            this.guna2CheckBox3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.guna2CheckBox3.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(230)))), ((int)(((byte)(134)))));
            this.guna2Transition1.SetDecoration(this.guna2CheckBox3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2CheckBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(230)))), ((int)(((byte)(134)))));
            this.guna2CheckBox3.Location = new System.Drawing.Point(6, 50);
            this.guna2CheckBox3.Name = "guna2CheckBox3";
            this.guna2CheckBox3.Size = new System.Drawing.Size(113, 17);
            this.guna2CheckBox3.TabIndex = 10;
            this.guna2CheckBox3.Text = "Check for updates";
            this.guna2CheckBox3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(230)))), ((int)(((byte)(134)))));
            this.guna2CheckBox3.UncheckedState.BorderRadius = 2;
            this.guna2CheckBox3.UncheckedState.BorderThickness = 1;
            this.guna2CheckBox3.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.guna2CheckBox3.UseVisualStyleBackColor = true;
            this.guna2CheckBox3.CheckedChanged += new System.EventHandler(this.guna2CheckBox3_CheckedChanged);
            // 
            // guna2CheckBox2
            // 
            this.guna2CheckBox2.Animated = true;
            this.guna2CheckBox2.AutoSize = true;
            this.guna2CheckBox2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(230)))), ((int)(((byte)(134)))));
            this.guna2CheckBox2.CheckedState.BorderRadius = 2;
            this.guna2CheckBox2.CheckedState.BorderThickness = 1;
            this.guna2CheckBox2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.guna2CheckBox2.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(230)))), ((int)(((byte)(134)))));
            this.guna2Transition1.SetDecoration(this.guna2CheckBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2CheckBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(230)))), ((int)(((byte)(134)))));
            this.guna2CheckBox2.Location = new System.Drawing.Point(6, 28);
            this.guna2CheckBox2.Name = "guna2CheckBox2";
            this.guna2CheckBox2.Size = new System.Drawing.Size(178, 17);
            this.guna2CheckBox2.TabIndex = 9;
            this.guna2CheckBox2.Text = "Auto-Save files to projects folder";
            this.guna2CheckBox2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(230)))), ((int)(((byte)(134)))));
            this.guna2CheckBox2.UncheckedState.BorderRadius = 2;
            this.guna2CheckBox2.UncheckedState.BorderThickness = 1;
            this.guna2CheckBox2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.guna2CheckBox2.UseVisualStyleBackColor = true;
            this.guna2CheckBox2.CheckedChanged += new System.EventHandler(this.guna2CheckBox2_CheckedChanged);
            // 
            // guna2CheckBox1
            // 
            this.guna2CheckBox1.Animated = true;
            this.guna2CheckBox1.AutoSize = true;
            this.guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(230)))), ((int)(((byte)(134)))));
            this.guna2CheckBox1.CheckedState.BorderRadius = 2;
            this.guna2CheckBox1.CheckedState.BorderThickness = 1;
            this.guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.guna2CheckBox1.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(230)))), ((int)(((byte)(134)))));
            this.guna2Transition1.SetDecoration(this.guna2CheckBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2CheckBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(230)))), ((int)(((byte)(134)))));
            this.guna2CheckBox1.Location = new System.Drawing.Point(6, 7);
            this.guna2CheckBox1.Name = "guna2CheckBox1";
            this.guna2CheckBox1.Size = new System.Drawing.Size(148, 17);
            this.guna2CheckBox1.TabIndex = 6;
            this.guna2CheckBox1.Text = "Use development website";
            this.guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(230)))), ((int)(((byte)(134)))));
            this.guna2CheckBox1.UncheckedState.BorderRadius = 2;
            this.guna2CheckBox1.UncheckedState.BorderThickness = 1;
            this.guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.guna2CheckBox1.UseVisualStyleBackColor = true;
            this.guna2CheckBox1.CheckedChanged += new System.EventHandler(this.guna2CheckBox1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(230)))), ((int)(((byte)(134)))));
            this.panel1.Controls.Add(this.panel2);
            this.guna2Transition1.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(617, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 79);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 15;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 15;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 15;
            this.guna2Elipse4.TargetControl = this.panel1;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 15;
            this.guna2Elipse5.TargetControl = this.panel2;
            // 
            // guna2HtmlToolTip1
            // 
            this.guna2HtmlToolTip1.AllowLinksHandling = true;
            this.guna2HtmlToolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.guna2HtmlToolTip1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(230)))), ((int)(((byte)(134)))));
            this.guna2HtmlToolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(230)))), ((int)(((byte)(134)))));
            this.guna2HtmlToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            this.guna2HtmlToolTip1.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(230)))), ((int)(((byte)(134)))));
            this.guna2HtmlToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.guna2HtmlToolTip1.ToolTipTitle = "Update Available";
            // 
            // notificationpanel
            // 
            this.notificationpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(230)))), ((int)(((byte)(134)))));
            this.notificationpanel.Controls.Add(this.guna2Button1);
            this.notificationpanel.Controls.Add(this.notificationlabel);
            this.guna2Transition1.SetDecoration(this.notificationpanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.notificationpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.notificationpanel.Location = new System.Drawing.Point(0, 475);
            this.notificationpanel.Name = "notificationpanel";
            this.notificationpanel.Size = new System.Drawing.Size(850, 25);
            this.notificationpanel.TabIndex = 4;
            this.notificationpanel.Visible = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Transition1.SetDecoration(this.guna2Button1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(827, 3);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(20, 19);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Text = "X";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.guna2Transition1.DefaultAnimation = animation1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.notificationpanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.resizebox);
            this.Controls.Add(this.toppanel);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topicon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.notificationpanel.ResumeLayout(false);
            this.notificationpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label notificationlabel;
        private System.Windows.Forms.Panel toppanel;
        private Guna.UI2.WinForms.Guna2ResizeBox resizebox;
        private Guna.UI2.WinForms.Guna2ControlBox minimizebutton;
        private Guna.UI2.WinForms.Guna2ControlBox maximizebutton;
        private Guna.UI2.WinForms.Guna2ControlBox closebutton;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.PictureBox topicon;
        private System.Windows.Forms.Label toplabel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ImageButton settingsbutton;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox3;
        public System.Windows.Forms.Panel notificationpanel;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
    }
}

