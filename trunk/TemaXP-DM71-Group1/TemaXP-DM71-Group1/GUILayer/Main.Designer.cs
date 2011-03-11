namespace TemaXP_DM71_Group1
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.FrontpageTab = new System.Windows.Forms.TabPage();
            this.ShowsTab = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.MovieTab = new System.Windows.Forms.TabPage();
            this.movie1 = new TemaXP_DM71_Group1.GUILayer.Movie();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.PlaytimeTab = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.ShowsTab.SuspendLayout();
            this.MovieTab.SuspendLayout();
            this.PlaytimeTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(12, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 431);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.FrontpageTab);
            this.tabControl1.Controls.Add(this.ShowsTab);
            this.tabControl1.Controls.Add(this.MovieTab);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.PlaytimeTab);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.ItemSize = new System.Drawing.Size(25, 100);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(761, 431);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            // 
            // FrontpageTab
            // 
            this.FrontpageTab.Location = new System.Drawing.Point(141, 4);
            this.FrontpageTab.Name = "FrontpageTab";
            this.FrontpageTab.Padding = new System.Windows.Forms.Padding(3);
            this.FrontpageTab.Size = new System.Drawing.Size(616, 423);
            this.FrontpageTab.TabIndex = 0;
            this.FrontpageTab.Text = "Forside";
            this.FrontpageTab.UseVisualStyleBackColor = true;
            // 
            // ShowsTab
            // 
            this.ShowsTab.Controls.Add(this.dateTimePicker1);
            this.ShowsTab.Controls.Add(this.comboBox4);
            this.ShowsTab.Controls.Add(this.comboBox3);
            this.ShowsTab.Controls.Add(this.comboBox2);
            this.ShowsTab.Controls.Add(this.comboBox1);
            this.ShowsTab.Controls.Add(this.label14);
            this.ShowsTab.Controls.Add(this.label13);
            this.ShowsTab.Controls.Add(this.label12);
            this.ShowsTab.Controls.Add(this.label11);
            this.ShowsTab.Controls.Add(this.label10);
            this.ShowsTab.Controls.Add(this.button7);
            this.ShowsTab.Controls.Add(this.button6);
            this.ShowsTab.Controls.Add(this.button5);
            this.ShowsTab.Location = new System.Drawing.Point(141, 4);
            this.ShowsTab.Name = "ShowsTab";
            this.ShowsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ShowsTab.Size = new System.Drawing.Size(616, 423);
            this.ShowsTab.TabIndex = 1;
            this.ShowsTab.Text = "Forestillinger";
            this.ShowsTab.UseVisualStyleBackColor = true;
            this.ShowsTab.Enter += new System.EventHandler(this.ShowsTab_Enter);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(193, 167);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.Value = new System.DateTime(2011, 3, 10, 12, 25, 24, 0);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(193, 253);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(200, 19);
            this.comboBox4.TabIndex = 11;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(193, 227);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(200, 19);
            this.comboBox3.TabIndex = 10;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(193, 199);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 19);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(193, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 19);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 174);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Dato";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 202);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Starttidspunkt";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 227);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Film";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Sal";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(193, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Vælg forestilling";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(0, 94);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 2;
            this.button7.Text = "Slet";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(3, 65);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 1;
            this.button6.Text = "Opdater";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 36);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "Opret";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // MovieTab
            // 
            this.MovieTab.Controls.Add(this.movie1);
            this.MovieTab.Location = new System.Drawing.Point(141, 4);
            this.MovieTab.Name = "MovieTab";
            this.MovieTab.Padding = new System.Windows.Forms.Padding(3);
            this.MovieTab.Size = new System.Drawing.Size(616, 423);
            this.MovieTab.TabIndex = 2;
            this.MovieTab.Text = "Film";
            this.MovieTab.UseVisualStyleBackColor = true;
            // 
            // movie1
            // 
            this.movie1.Location = new System.Drawing.Point(3, 3);
            this.movie1.Name = "movie1";
            this.movie1.Size = new System.Drawing.Size(610, 417);
            this.movie1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(141, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(616, 423);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // PlaytimeTab
            // 
            this.PlaytimeTab.Controls.Add(this.listBox1);
            this.PlaytimeTab.Location = new System.Drawing.Point(141, 4);
            this.PlaytimeTab.Name = "PlaytimeTab";
            this.PlaytimeTab.Padding = new System.Windows.Forms.Padding(3);
            this.PlaytimeTab.Size = new System.Drawing.Size(616, 423);
            this.PlaytimeTab.TabIndex = 5;
            this.PlaytimeTab.Text = "Spilletider";
            this.PlaytimeTab.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 11;
            this.listBox1.Items.AddRange(new object[] {
            "Tits"});
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(610, 417);
            this.listBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(13, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(759, 100);
            this.panel2.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "KinoKæk";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ShowsTab.ResumeLayout(false);
            this.ShowsTab.PerformLayout();
            this.MovieTab.ResumeLayout(false);
            this.PlaytimeTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ShowsTab;
        private System.Windows.Forms.TabPage FrontpageTab;
        private System.Windows.Forms.TabPage MovieTab;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage PlaytimeTab;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private GUILayer.Movie movie1;
    }
}

