using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace FacilityCW
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialCard7 = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialDivider4 = new MaterialSkin.Controls.MaterialDivider();
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.TpZombieToLocChk = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.TimescaleChk = new MaterialSkin.Controls.MaterialCheckbox();
            this.ZNumerics = new System.Windows.Forms.NumericUpDown();
            this.YNumerics = new System.Windows.Forms.NumericUpDown();
            this.XNumerics = new System.Windows.Forms.NumericUpDown();
            this.ZLbl = new MaterialSkin.Controls.MaterialLabel();
            this.YLbl = new MaterialSkin.Controls.MaterialLabel();
            this.XLbl = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.PlayerSpeedChk = new MaterialSkin.Controls.MaterialCheckbox();
            this.PlayerSpeedNumeric = new System.Windows.Forms.NumericUpDown();
            this.PlayerSpeedTrk = new System.Windows.Forms.TrackBar();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.WeaponNumeric = new System.Windows.Forms.NumericUpDown();
            this.EXPModifierChk = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialLabel35 = new MaterialSkin.Controls.MaterialLabel();
            this.WeaponTrkBar = new System.Windows.Forms.TrackBar();
            this.PlayerNumeric = new System.Windows.Forms.NumericUpDown();
            this.PlayerTrkBar = new System.Windows.Forms.TrackBar();
            this.materialLabel25 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider7 = new MaterialSkin.Controls.MaterialDivider();
            this.UnlimitedCashChk = new MaterialSkin.Controls.MaterialCheckbox();
            this.ZombiesLeftLbl = new MaterialSkin.Controls.MaterialLabel();
            this.btnOnOff = new MaterialSkin.Controls.MaterialButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.materialDivider6 = new MaterialSkin.Controls.MaterialDivider();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.ZombieTPchk = new MaterialSkin.Controls.MaterialCheckbox();
            this.InstaKillChk = new MaterialSkin.Controls.MaterialCheckbox();
            this.AmmoChk = new MaterialSkin.Controls.MaterialCheckbox();
            this.GodModeChk = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialDivider5 = new MaterialSkin.Controls.MaterialDivider();
            this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.menuIconList = new System.Windows.Forms.ImageList(this.components);
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.item1ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.subItem1ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.subItem2ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.disabledItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item2ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.item3ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.materialCard7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.materialCard2.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.materialCard5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZNumerics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YNumerics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XNumerics)).BeginInit();
            this.materialCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerSpeedNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerSpeedTrk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeaponNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeaponTrkBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerTrkBar)).BeginInit();
            this.materialCard3.SuspendLayout();
            this.materialCard6.SuspendLayout();
            this.materialContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage7);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.menuIconList;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1031, 555);
            this.materialTabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.materialCard7);
            this.tabPage1.ImageKey = "round_bookmark_white_24dp.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1023, 520);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            // 
            // materialCard7
            // 
            this.materialCard7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard7.Controls.Add(this.pictureBox1);
            this.materialCard7.Controls.Add(this.materialDivider4);
            this.materialCard7.Controls.Add(this.materialButton4);
            this.materialCard7.Controls.Add(this.materialCard2);
            this.materialCard7.Controls.Add(this.materialLabel9);
            this.materialCard7.Depth = 0;
            this.materialCard7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard7.Location = new System.Drawing.Point(177, 60);
            this.materialCard7.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard7.Name = "materialCard7";
            this.materialCard7.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard7.Size = new System.Drawing.Size(661, 401);
            this.materialCard7.TabIndex = 40;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(412, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // materialDivider4
            // 
            this.materialDivider4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider4.Depth = 0;
            this.materialDivider4.Location = new System.Drawing.Point(17, 350);
            this.materialDivider4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider4.Name = "materialDivider4";
            this.materialDivider4.Size = new System.Drawing.Size(627, 2);
            this.materialDivider4.TabIndex = 40;
            this.materialDivider4.Text = "materialDivider4";
            // 
            // materialButton4
            // 
            this.materialButton4.AutoSize = false;
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.Depth = 0;
            this.materialButton4.DrawShadows = true;
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = null;
            this.materialButton4.Location = new System.Drawing.Point(17, 362);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.Size = new System.Drawing.Size(628, 32);
            this.materialButton4.TabIndex = 39;
            this.materialButton4.Text = "Okay, bring me to action!";
            this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton4.UseAccentColor = false;
            this.materialButton4.UseVisualStyleBackColor = true;
            this.materialButton4.Click += new System.EventHandler(this.materialButton4_Click);
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.materialLabel6);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(-8, 11);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(177, 43);
            this.materialCard2.TabIndex = 38;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.HighEmphasis = true;
            this.materialLabel6.Location = new System.Drawing.Point(17, 13);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(95, 19);
            this.materialLabel6.TabIndex = 37;
            this.materialLabel6.Text = "FACILITY:CW";
            this.materialLabel6.UseAccent = true;
            // 
            // materialLabel9
            // 
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(30, 100);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(614, 287);
            this.materialLabel9.TabIndex = 0;
            this.materialLabel9.Text = "Pasted stuff for some P2C.\r\n\r\n- Was not selling it was asked to make the tool\r\n- " +
    "No support fully pasted\r\n- HF\r\n\r\n____________________\r\n\r\nHave fun.\r\n- Sehyn";
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.White;
            this.tabPage7.Controls.Add(this.materialCard5);
            this.tabPage7.ImageKey = "round_build_white_24dp.png";
            this.tabPage7.Location = new System.Drawing.Point(4, 31);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1023, 520);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Settings";
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.TpZombieToLocChk);
            this.materialCard5.Controls.Add(this.materialButton1);
            this.materialCard5.Controls.Add(this.TimescaleChk);
            this.materialCard5.Controls.Add(this.ZNumerics);
            this.materialCard5.Controls.Add(this.YNumerics);
            this.materialCard5.Controls.Add(this.XNumerics);
            this.materialCard5.Controls.Add(this.ZLbl);
            this.materialCard5.Controls.Add(this.YLbl);
            this.materialCard5.Controls.Add(this.XLbl);
            this.materialCard5.Controls.Add(this.materialCard4);
            this.materialCard5.Controls.Add(this.materialDivider7);
            this.materialCard5.Controls.Add(this.UnlimitedCashChk);
            this.materialCard5.Controls.Add(this.ZombiesLeftLbl);
            this.materialCard5.Controls.Add(this.btnOnOff);
            this.materialCard5.Controls.Add(this.textBox1);
            this.materialCard5.Controls.Add(this.materialDivider6);
            this.materialCard5.Controls.Add(this.materialCard3);
            this.materialCard5.Controls.Add(this.ZombieTPchk);
            this.materialCard5.Controls.Add(this.InstaKillChk);
            this.materialCard5.Controls.Add(this.AmmoChk);
            this.materialCard5.Controls.Add(this.GodModeChk);
            this.materialCard5.Controls.Add(this.materialDivider5);
            this.materialCard5.Controls.Add(this.materialCard6);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(14, 17);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(967, 489);
            this.materialCard5.TabIndex = 2;
            // 
            // TpZombieToLocChk
            // 
            this.TpZombieToLocChk.AutoSize = true;
            this.TpZombieToLocChk.Depth = 0;
            this.TpZombieToLocChk.Location = new System.Drawing.Point(18, 423);
            this.TpZombieToLocChk.Margin = new System.Windows.Forms.Padding(0);
            this.TpZombieToLocChk.MouseLocation = new System.Drawing.Point(-1, -1);
            this.TpZombieToLocChk.MouseState = MaterialSkin.MouseState.HOVER;
            this.TpZombieToLocChk.Name = "TpZombieToLocChk";
            this.TpZombieToLocChk.Ripple = true;
            this.TpZombieToLocChk.Size = new System.Drawing.Size(225, 37);
            this.TpZombieToLocChk.TabIndex = 35;
            this.TpZombieToLocChk.Text = "TP Zombie to spawn stairs";
            this.TpZombieToLocChk.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(18, 394);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(240, 23);
            this.materialButton1.TabIndex = 34;
            this.materialButton1.Text = "GET POS";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click_2);
            // 
            // TimescaleChk
            // 
            this.TimescaleChk.AutoSize = true;
            this.TimescaleChk.Depth = 0;
            this.TimescaleChk.Location = new System.Drawing.Point(18, 313);
            this.TimescaleChk.Margin = new System.Windows.Forms.Padding(0);
            this.TimescaleChk.MouseLocation = new System.Drawing.Point(-1, -1);
            this.TimescaleChk.MouseState = MaterialSkin.MouseState.HOVER;
            this.TimescaleChk.Name = "TimescaleChk";
            this.TimescaleChk.Ripple = true;
            this.TimescaleChk.Size = new System.Drawing.Size(154, 37);
            this.TimescaleChk.TabIndex = 33;
            this.TimescaleChk.Text = "Timescale (safe)";
            this.TimescaleChk.UseVisualStyleBackColor = true;
            // 
            // ZNumerics
            // 
            this.ZNumerics.DecimalPlaces = 10;
            this.ZNumerics.Location = new System.Drawing.Point(994, 361);
            this.ZNumerics.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ZNumerics.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.ZNumerics.Name = "ZNumerics";
            this.ZNumerics.Size = new System.Drawing.Size(120, 20);
            this.ZNumerics.TabIndex = 32;
            this.ZNumerics.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ZNumerics.Visible = false;
            // 
            // YNumerics
            // 
            this.YNumerics.DecimalPlaces = 10;
            this.YNumerics.Location = new System.Drawing.Point(994, 335);
            this.YNumerics.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.YNumerics.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.YNumerics.Name = "YNumerics";
            this.YNumerics.Size = new System.Drawing.Size(120, 20);
            this.YNumerics.TabIndex = 31;
            this.YNumerics.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.YNumerics.Visible = false;
            // 
            // XNumerics
            // 
            this.XNumerics.DecimalPlaces = 10;
            this.XNumerics.Location = new System.Drawing.Point(994, 308);
            this.XNumerics.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.XNumerics.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.XNumerics.Name = "XNumerics";
            this.XNumerics.Size = new System.Drawing.Size(120, 20);
            this.XNumerics.TabIndex = 30;
            this.XNumerics.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.XNumerics.Visible = false;
            // 
            // ZLbl
            // 
            this.ZLbl.AutoSize = true;
            this.ZLbl.Depth = 0;
            this.ZLbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ZLbl.Location = new System.Drawing.Point(973, 360);
            this.ZLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.ZLbl.Name = "ZLbl";
            this.ZLbl.Size = new System.Drawing.Size(15, 19);
            this.ZLbl.TabIndex = 29;
            this.ZLbl.Text = "Z:";
            this.ZLbl.Visible = false;
            // 
            // YLbl
            // 
            this.YLbl.AutoSize = true;
            this.YLbl.Depth = 0;
            this.YLbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.YLbl.Location = new System.Drawing.Point(973, 335);
            this.YLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.YLbl.Name = "YLbl";
            this.YLbl.Size = new System.Drawing.Size(15, 19);
            this.YLbl.TabIndex = 28;
            this.YLbl.Text = "Y:";
            this.YLbl.Visible = false;
            // 
            // XLbl
            // 
            this.XLbl.AutoSize = true;
            this.XLbl.Depth = 0;
            this.XLbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.XLbl.Location = new System.Drawing.Point(973, 309);
            this.XLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.XLbl.Name = "XLbl";
            this.XLbl.Size = new System.Drawing.Size(15, 19);
            this.XLbl.TabIndex = 27;
            this.XLbl.Text = "X:";
            this.XLbl.Visible = false;
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.PlayerSpeedChk);
            this.materialCard4.Controls.Add(this.PlayerSpeedNumeric);
            this.materialCard4.Controls.Add(this.PlayerSpeedTrk);
            this.materialCard4.Controls.Add(this.materialLabel2);
            this.materialCard4.Controls.Add(this.WeaponNumeric);
            this.materialCard4.Controls.Add(this.EXPModifierChk);
            this.materialCard4.Controls.Add(this.materialLabel35);
            this.materialCard4.Controls.Add(this.WeaponTrkBar);
            this.materialCard4.Controls.Add(this.PlayerNumeric);
            this.materialCard4.Controls.Add(this.PlayerTrkBar);
            this.materialCard4.Controls.Add(this.materialLabel25);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(318, 251);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(632, 234);
            this.materialCard4.TabIndex = 26;
            // 
            // PlayerSpeedChk
            // 
            this.PlayerSpeedChk.AutoSize = true;
            this.PlayerSpeedChk.Depth = 0;
            this.PlayerSpeedChk.Location = new System.Drawing.Point(299, 14);
            this.PlayerSpeedChk.Margin = new System.Windows.Forms.Padding(0);
            this.PlayerSpeedChk.MouseLocation = new System.Drawing.Point(-1, -1);
            this.PlayerSpeedChk.MouseState = MaterialSkin.MouseState.HOVER;
            this.PlayerSpeedChk.Name = "PlayerSpeedChk";
            this.PlayerSpeedChk.Ripple = true;
            this.PlayerSpeedChk.Size = new System.Drawing.Size(127, 37);
            this.PlayerSpeedChk.TabIndex = 29;
            this.PlayerSpeedChk.Text = "Player Speed";
            this.PlayerSpeedChk.UseVisualStyleBackColor = true;
            this.PlayerSpeedChk.CheckedChanged += new System.EventHandler(this.PlayerSpeedChk_CheckedChanged);
            // 
            // PlayerSpeedNumeric
            // 
            this.PlayerSpeedNumeric.DecimalPlaces = 2;
            this.PlayerSpeedNumeric.Location = new System.Drawing.Point(299, 128);
            this.PlayerSpeedNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PlayerSpeedNumeric.Name = "PlayerSpeedNumeric";
            this.PlayerSpeedNumeric.Size = new System.Drawing.Size(240, 20);
            this.PlayerSpeedNumeric.TabIndex = 27;
            this.PlayerSpeedNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PlayerSpeedNumeric.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // PlayerSpeedTrk
            // 
            this.PlayerSpeedTrk.Location = new System.Drawing.Point(290, 97);
            this.PlayerSpeedTrk.Maximum = 100;
            this.PlayerSpeedTrk.Minimum = 1;
            this.PlayerSpeedTrk.Name = "PlayerSpeedTrk";
            this.PlayerSpeedTrk.Size = new System.Drawing.Size(245, 45);
            this.PlayerSpeedTrk.TabIndex = 26;
            this.PlayerSpeedTrk.Value = 1;
            this.PlayerSpeedTrk.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(296, 75);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(97, 19);
            this.materialLabel2.TabIndex = 28;
            this.materialLabel2.Text = "Player Speed:";
            // 
            // WeaponNumeric
            // 
            this.WeaponNumeric.DecimalPlaces = 2;
            this.WeaponNumeric.Location = new System.Drawing.Point(14, 128);
            this.WeaponNumeric.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.WeaponNumeric.Name = "WeaponNumeric";
            this.WeaponNumeric.Size = new System.Drawing.Size(240, 20);
            this.WeaponNumeric.TabIndex = 21;
            this.WeaponNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.WeaponNumeric.ValueChanged += new System.EventHandler(this.WeaponNumeric_ValueChanged);
            // 
            // EXPModifierChk
            // 
            this.EXPModifierChk.AutoSize = true;
            this.EXPModifierChk.Depth = 0;
            this.EXPModifierChk.Location = new System.Drawing.Point(5, 14);
            this.EXPModifierChk.Margin = new System.Windows.Forms.Padding(0);
            this.EXPModifierChk.MouseLocation = new System.Drawing.Point(-1, -1);
            this.EXPModifierChk.MouseState = MaterialSkin.MouseState.HOVER;
            this.EXPModifierChk.Name = "EXPModifierChk";
            this.EXPModifierChk.Ripple = true;
            this.EXPModifierChk.Size = new System.Drawing.Size(131, 37);
            this.EXPModifierChk.TabIndex = 10;
            this.EXPModifierChk.Text = "EXP - Modifer";
            this.EXPModifierChk.UseVisualStyleBackColor = true;
            this.EXPModifierChk.CheckedChanged += new System.EventHandler(this.EXPModifierChk_CheckedChanged);
            // 
            // materialLabel35
            // 
            this.materialLabel35.AutoSize = true;
            this.materialLabel35.Depth = 0;
            this.materialLabel35.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel35.Location = new System.Drawing.Point(11, 154);
            this.materialLabel35.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel35.Name = "materialLabel35";
            this.materialLabel35.Size = new System.Drawing.Size(82, 19);
            this.materialLabel35.TabIndex = 25;
            this.materialLabel35.Text = "Player EXP:";
            // 
            // WeaponTrkBar
            // 
            this.WeaponTrkBar.Location = new System.Drawing.Point(5, 97);
            this.WeaponTrkBar.Maximum = 3000;
            this.WeaponTrkBar.Name = "WeaponTrkBar";
            this.WeaponTrkBar.Size = new System.Drawing.Size(245, 45);
            this.WeaponTrkBar.TabIndex = 20;
            this.WeaponTrkBar.Value = 100;
            this.WeaponTrkBar.Scroll += new System.EventHandler(this.WeaponTrkBar_Scroll);
            // 
            // PlayerNumeric
            // 
            this.PlayerNumeric.DecimalPlaces = 2;
            this.PlayerNumeric.Location = new System.Drawing.Point(14, 207);
            this.PlayerNumeric.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.PlayerNumeric.Name = "PlayerNumeric";
            this.PlayerNumeric.Size = new System.Drawing.Size(240, 20);
            this.PlayerNumeric.TabIndex = 24;
            this.PlayerNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.PlayerNumeric.ValueChanged += new System.EventHandler(this.PlayerNumeric_ValueChanged);
            // 
            // PlayerTrkBar
            // 
            this.PlayerTrkBar.Location = new System.Drawing.Point(5, 176);
            this.PlayerTrkBar.Maximum = 3000;
            this.PlayerTrkBar.Name = "PlayerTrkBar";
            this.PlayerTrkBar.Size = new System.Drawing.Size(245, 45);
            this.PlayerTrkBar.TabIndex = 23;
            this.PlayerTrkBar.Value = 100;
            this.PlayerTrkBar.Scroll += new System.EventHandler(this.PlayerTrkBar_Scroll);
            // 
            // materialLabel25
            // 
            this.materialLabel25.AutoSize = true;
            this.materialLabel25.Depth = 0;
            this.materialLabel25.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel25.Location = new System.Drawing.Point(11, 75);
            this.materialLabel25.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel25.Name = "materialLabel25";
            this.materialLabel25.Size = new System.Drawing.Size(96, 19);
            this.materialLabel25.TabIndex = 22;
            this.materialLabel25.Text = "Weapon EXP:";
            // 
            // materialDivider7
            // 
            this.materialDivider7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider7.Depth = 0;
            this.materialDivider7.Location = new System.Drawing.Point(309, 245);
            this.materialDivider7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider7.Name = "materialDivider7";
            this.materialDivider7.Size = new System.Drawing.Size(658, 2);
            this.materialDivider7.TabIndex = 19;
            this.materialDivider7.Text = "materialDivider7";
            // 
            // UnlimitedCashChk
            // 
            this.UnlimitedCashChk.AutoSize = true;
            this.UnlimitedCashChk.Depth = 0;
            this.UnlimitedCashChk.Location = new System.Drawing.Point(18, 276);
            this.UnlimitedCashChk.Margin = new System.Windows.Forms.Padding(0);
            this.UnlimitedCashChk.MouseLocation = new System.Drawing.Point(-1, -1);
            this.UnlimitedCashChk.MouseState = MaterialSkin.MouseState.HOVER;
            this.UnlimitedCashChk.Name = "UnlimitedCashChk";
            this.UnlimitedCashChk.Ripple = true;
            this.UnlimitedCashChk.Size = new System.Drawing.Size(140, 37);
            this.UnlimitedCashChk.TabIndex = 18;
            this.UnlimitedCashChk.Text = "Unlimited cash";
            this.UnlimitedCashChk.UseVisualStyleBackColor = true;
            this.UnlimitedCashChk.CheckedChanged += new System.EventHandler(this.UnlimitedCashChk_CheckedChanged);
            // 
            // ZombiesLeftLbl
            // 
            this.ZombiesLeftLbl.AutoSize = true;
            this.ZombiesLeftLbl.Depth = 0;
            this.ZombiesLeftLbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ZombiesLeftLbl.Location = new System.Drawing.Point(842, 56);
            this.ZombiesLeftLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.ZombiesLeftLbl.Name = "ZombiesLeftLbl";
            this.ZombiesLeftLbl.Size = new System.Drawing.Size(108, 19);
            this.ZombiesLeftLbl.TabIndex = 17;
            this.ZombiesLeftLbl.Text = "Zombies left: X";
            // 
            // btnOnOff
            // 
            this.btnOnOff.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOnOff.Depth = 0;
            this.btnOnOff.DrawShadows = true;
            this.btnOnOff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOnOff.HighEmphasis = true;
            this.btnOnOff.Icon = null;
            this.btnOnOff.Location = new System.Drawing.Point(18, 86);
            this.btnOnOff.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOnOff.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(106, 36);
            this.btnOnOff.TabIndex = 16;
            this.btnOnOff.Text = "Hook Game";
            this.btnOnOff.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOnOff.UseAccentColor = false;
            this.btnOnOff.UseVisualStyleBackColor = true;
            this.btnOnOff.Click += new System.EventHandler(this.btnOnOff_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(318, 86);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(632, 153);
            this.textBox1.TabIndex = 15;
            // 
            // materialDivider6
            // 
            this.materialDivider6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider6.Depth = 0;
            this.materialDivider6.Location = new System.Drawing.Point(304, 78);
            this.materialDivider6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider6.Name = "materialDivider6";
            this.materialDivider6.Size = new System.Drawing.Size(680, 2);
            this.materialDivider6.TabIndex = 14;
            this.materialDivider6.Text = "materialDivider6";
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.materialLabel8);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(539, 11);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(250, 50);
            this.materialCard3.TabIndex = 13;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.HighEmphasis = true;
            this.materialLabel8.Location = new System.Drawing.Point(61, 17);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(119, 19);
            this.materialLabel8.TabIndex = 1;
            this.materialLabel8.Text = "Facility:CW - Log";
            this.materialLabel8.UseAccent = true;
            // 
            // ZombieTPchk
            // 
            this.ZombieTPchk.AutoSize = true;
            this.ZombieTPchk.Depth = 0;
            this.ZombieTPchk.Location = new System.Drawing.Point(18, 239);
            this.ZombieTPchk.Margin = new System.Windows.Forms.Padding(0);
            this.ZombieTPchk.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ZombieTPchk.MouseState = MaterialSkin.MouseState.HOVER;
            this.ZombieTPchk.Name = "ZombieTPchk";
            this.ZombieTPchk.Ripple = true;
            this.ZombieTPchk.Size = new System.Drawing.Size(240, 37);
            this.ZombieTPchk.TabIndex = 12;
            this.ZombieTPchk.Text = "Teleport Zombie to Crosshair";
            this.ZombieTPchk.UseVisualStyleBackColor = true;
            this.ZombieTPchk.CheckedChanged += new System.EventHandler(this.ZombieTPchk_CheckedChanged);
            // 
            // InstaKillChk
            // 
            this.InstaKillChk.AutoSize = true;
            this.InstaKillChk.Depth = 0;
            this.InstaKillChk.Location = new System.Drawing.Point(18, 202);
            this.InstaKillChk.Margin = new System.Windows.Forms.Padding(0);
            this.InstaKillChk.MouseLocation = new System.Drawing.Point(-1, -1);
            this.InstaKillChk.MouseState = MaterialSkin.MouseState.HOVER;
            this.InstaKillChk.Name = "InstaKillChk";
            this.InstaKillChk.Ripple = true;
            this.InstaKillChk.Size = new System.Drawing.Size(92, 37);
            this.InstaKillChk.TabIndex = 11;
            this.InstaKillChk.Text = "InstaKill";
            this.InstaKillChk.UseVisualStyleBackColor = true;
            this.InstaKillChk.CheckedChanged += new System.EventHandler(this.InstaKillChk_CheckedChanged);
            // 
            // AmmoChk
            // 
            this.AmmoChk.AutoSize = true;
            this.AmmoChk.Depth = 0;
            this.AmmoChk.Location = new System.Drawing.Point(18, 165);
            this.AmmoChk.Margin = new System.Windows.Forms.Padding(0);
            this.AmmoChk.MouseLocation = new System.Drawing.Point(-1, -1);
            this.AmmoChk.MouseState = MaterialSkin.MouseState.HOVER;
            this.AmmoChk.Name = "AmmoChk";
            this.AmmoChk.Ripple = true;
            this.AmmoChk.Size = new System.Drawing.Size(135, 37);
            this.AmmoChk.TabIndex = 9;
            this.AmmoChk.Text = "Infinite Ammo";
            this.AmmoChk.UseVisualStyleBackColor = true;
            this.AmmoChk.CheckedChanged += new System.EventHandler(this.AmmoChk_CheckedChanged);
            // 
            // GodModeChk
            // 
            this.GodModeChk.AutoSize = true;
            this.GodModeChk.Depth = 0;
            this.GodModeChk.Location = new System.Drawing.Point(18, 128);
            this.GodModeChk.Margin = new System.Windows.Forms.Padding(0);
            this.GodModeChk.MouseLocation = new System.Drawing.Point(-1, -1);
            this.GodModeChk.MouseState = MaterialSkin.MouseState.HOVER;
            this.GodModeChk.Name = "GodModeChk";
            this.GodModeChk.Ripple = true;
            this.GodModeChk.Size = new System.Drawing.Size(108, 37);
            this.GodModeChk.TabIndex = 8;
            this.GodModeChk.Text = "God Mode";
            this.GodModeChk.UseVisualStyleBackColor = true;
            this.GodModeChk.CheckedChanged += new System.EventHandler(this.GodModeChk_CheckedChanged);
            // 
            // materialDivider5
            // 
            this.materialDivider5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider5.Depth = 0;
            this.materialDivider5.Location = new System.Drawing.Point(304, 0);
            this.materialDivider5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider5.Name = "materialDivider5";
            this.materialDivider5.Size = new System.Drawing.Size(5, 489);
            this.materialDivider5.TabIndex = 7;
            this.materialDivider5.Text = "materialDivider5";
            // 
            // materialCard6
            // 
            this.materialCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard6.Controls.Add(this.materialLabel3);
            this.materialCard6.Depth = 0;
            this.materialCard6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard6.Location = new System.Drawing.Point(-9, 11);
            this.materialCard6.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard6.Name = "materialCard6";
            this.materialCard6.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard6.Size = new System.Drawing.Size(250, 50);
            this.materialCard6.TabIndex = 5;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.HighEmphasis = true;
            this.materialLabel3.Location = new System.Drawing.Point(16, 16);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(150, 19);
            this.materialLabel3.TabIndex = 1;
            this.materialLabel3.Text = "Facility:CW - Settings";
            this.materialLabel3.UseAccent = true;
            // 
            // menuIconList
            // 
            this.menuIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("menuIconList.ImageStream")));
            this.menuIconList.TransparentColor = System.Drawing.Color.Transparent;
            this.menuIconList.Images.SetKeyName(0, "round_assessment_white_24dp.png");
            this.menuIconList.Images.SetKeyName(1, "round_backup_white_24dp.png");
            this.menuIconList.Images.SetKeyName(2, "round_bluetooth_white_24dp.png");
            this.menuIconList.Images.SetKeyName(3, "round_bookmark_white_24dp.png");
            this.menuIconList.Images.SetKeyName(4, "round_build_white_24dp.png");
            this.menuIconList.Images.SetKeyName(5, "round_gps_fixed_white_24dp.png");
            this.menuIconList.Images.SetKeyName(6, "round_http_white_24dp.png");
            this.menuIconList.Images.SetKeyName(7, "round_report_problem_white_24dp.png");
            this.menuIconList.Images.SetKeyName(8, "round_swap_vert_white_24dp.png");
            this.menuIconList.Images.SetKeyName(9, "coin.bmp");
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item1ToolStripMenuItem,
            this.disabledItemToolStripMenuItem,
            this.item2ToolStripMenuItem,
            this.toolStripSeparator1,
            this.item3ToolStripMenuItem});
            this.materialContextMenuStrip1.Margin = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(166, 130);
            // 
            // item1ToolStripMenuItem
            // 
            this.item1ToolStripMenuItem.AutoSize = false;
            this.item1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subItem1ToolStripMenuItem,
            this.subItem2ToolStripMenuItem});
            this.item1ToolStripMenuItem.Name = "item1ToolStripMenuItem";
            this.item1ToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.item1ToolStripMenuItem.Text = "Item 1";
            // 
            // subItem1ToolStripMenuItem
            // 
            this.subItem1ToolStripMenuItem.AutoSize = false;
            this.subItem1ToolStripMenuItem.Name = "subItem1ToolStripMenuItem";
            this.subItem1ToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.subItem1ToolStripMenuItem.Text = "SubItem 1";
            // 
            // subItem2ToolStripMenuItem
            // 
            this.subItem2ToolStripMenuItem.AutoSize = false;
            this.subItem2ToolStripMenuItem.Name = "subItem2ToolStripMenuItem";
            this.subItem2ToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.subItem2ToolStripMenuItem.Text = "SubItem 2";
            // 
            // disabledItemToolStripMenuItem
            // 
            this.disabledItemToolStripMenuItem.AutoSize = false;
            this.disabledItemToolStripMenuItem.Enabled = false;
            this.disabledItemToolStripMenuItem.Name = "disabledItemToolStripMenuItem";
            this.disabledItemToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.disabledItemToolStripMenuItem.Text = "Disabled item";
            // 
            // item2ToolStripMenuItem
            // 
            this.item2ToolStripMenuItem.AutoSize = false;
            this.item2ToolStripMenuItem.Name = "item2ToolStripMenuItem";
            this.item2ToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.item2ToolStripMenuItem.Text = "Item 2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // item3ToolStripMenuItem
            // 
            this.item3ToolStripMenuItem.AutoSize = false;
            this.item3ToolStripMenuItem.Name = "item3ToolStripMenuItem";
            this.item3ToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.item3ToolStripMenuItem.Text = "Item 3";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1037, 622);
            this.ContextMenuStrip = this.materialContextMenuStrip1;
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facility:CW";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.materialCard7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.materialCard5.ResumeLayout(false);
            this.materialCard5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZNumerics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YNumerics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XNumerics)).EndInit();
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerSpeedNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerSpeedTrk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeaponNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeaponTrkBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerTrkBar)).EndInit();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.materialCard6.ResumeLayout(false);
            this.materialCard6.PerformLayout();
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialContextMenuStrip materialContextMenuStrip1;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item1ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem subItem1ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem subItem2ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item2ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem disabledItemToolStripMenuItem;
        private ImageList menuIconList;
        private TabPage tabPage7;
        private MaterialCard materialCard7;
        private MaterialDivider materialDivider4;
        private MaterialButton materialButton4;
        private MaterialCard materialCard2;
        private MaterialLabel materialLabel6;
        private MaterialLabel materialLabel9;
        private MaterialCard materialCard5;
        private MaterialCard materialCard3;
        private MaterialLabel materialLabel8;
        private MaterialCheckbox ZombieTPchk;
        private MaterialCheckbox InstaKillChk;
        private MaterialCheckbox EXPModifierChk;
        private MaterialCheckbox AmmoChk;
        private MaterialCheckbox GodModeChk;
        private MaterialDivider materialDivider5;
        private MaterialCard materialCard6;
        private MaterialLabel materialLabel3;
        private MaterialDivider materialDivider6;
        private TextBox textBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MaterialButton btnOnOff;
        private Timer timer1;
        private MaterialLabel ZombiesLeftLbl;
        private MaterialCheckbox UnlimitedCashChk;
        private MaterialCard materialCard4;
        private MaterialLabel materialLabel35;
        private TrackBar WeaponTrkBar;
        private NumericUpDown PlayerNumeric;
        private NumericUpDown WeaponNumeric;
        private TrackBar PlayerTrkBar;
        private MaterialLabel materialLabel25;
        private MaterialDivider materialDivider7;
        private MaterialLabel ZLbl;
        private MaterialLabel YLbl;
        private MaterialLabel XLbl;
        private NumericUpDown ZNumerics;
        private NumericUpDown YNumerics;
        private NumericUpDown XNumerics;
        private MaterialCheckbox TimescaleChk;
        private PictureBox pictureBox1;
        private NumericUpDown PlayerSpeedNumeric;
        private TrackBar PlayerSpeedTrk;
        private MaterialLabel materialLabel2;
        private MaterialCheckbox PlayerSpeedChk;
        private MaterialButton materialButton1;
        private MaterialCheckbox TpZombieToLocChk;
    }
}