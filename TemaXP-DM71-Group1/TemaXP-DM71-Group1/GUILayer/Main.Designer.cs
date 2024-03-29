﻿namespace TemaXP_DM71_Group1
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
            this.guiShow1 = new TemaXP_DM71_Group1.GUILayer.GUIShow();
            this.MovieTab = new System.Windows.Forms.TabPage();
            this.movie1 = new TemaXP_DM71_Group1.GUILayer.GUIMovie();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.guiCinema1 = new TemaXP_DM71_Group1.GUILayer.GUICinema();
            this.PlaytimeTab = new System.Windows.Forms.TabPage();
            this.guiPlaytime1 = new TemaXP_DM71_Group1.GUILayer.GUIPlaytime();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.guiBooking1 = new TemaXP_DM71_Group1.GUILayer.GUIBooking();
            this.pLogo = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.ShowsTab.SuspendLayout();
            this.MovieTab.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.PlaytimeTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.ItemSize = new System.Drawing.Size(25, 100);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(761, 431);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            // 
            // FrontpageTab
            // 
            this.FrontpageTab.Location = new System.Drawing.Point(169, 4);
            this.FrontpageTab.Name = "FrontpageTab";
            this.FrontpageTab.Padding = new System.Windows.Forms.Padding(3);
            this.FrontpageTab.Size = new System.Drawing.Size(588, 423);
            this.FrontpageTab.TabIndex = 0;
            this.FrontpageTab.Text = "Forside";
            this.FrontpageTab.UseVisualStyleBackColor = true;
            // 
            // ShowsTab
            // 
            this.ShowsTab.Controls.Add(this.guiShow1);
            this.ShowsTab.Location = new System.Drawing.Point(169, 4);
            this.ShowsTab.Name = "ShowsTab";
            this.ShowsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ShowsTab.Size = new System.Drawing.Size(588, 423);
            this.ShowsTab.TabIndex = 1;
            this.ShowsTab.Text = "Forestillinger";
            this.ShowsTab.UseVisualStyleBackColor = true;
            this.ShowsTab.Click += new System.EventHandler(this.ShowsTab_Click);
            this.ShowsTab.Enter += new System.EventHandler(this.ShowsTab_Enter);
            // 
            // guiShow1
            // 
            this.guiShow1.Location = new System.Drawing.Point(0, 0);
            this.guiShow1.Name = "guiShow1";
            this.guiShow1.Size = new System.Drawing.Size(619, 424);
            this.guiShow1.TabIndex = 0;
            // 
            // MovieTab
            // 
            this.MovieTab.Controls.Add(this.movie1);
            this.MovieTab.Location = new System.Drawing.Point(169, 4);
            this.MovieTab.Name = "MovieTab";
            this.MovieTab.Padding = new System.Windows.Forms.Padding(3);
            this.MovieTab.Size = new System.Drawing.Size(588, 423);
            this.MovieTab.TabIndex = 2;
            this.MovieTab.Text = "Film";
            this.MovieTab.UseVisualStyleBackColor = true;
            // 
            // movie1
            // 
            this.movie1.Location = new System.Drawing.Point(0, 0);
            this.movie1.Name = "movie1";
            this.movie1.Size = new System.Drawing.Size(616, 423);
            this.movie1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.guiCinema1);
            this.tabPage3.Location = new System.Drawing.Point(169, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(588, 423);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Sale";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // guiCinema1
            // 
            this.guiCinema1.Location = new System.Drawing.Point(2, 3);
            this.guiCinema1.Name = "guiCinema1";
            this.guiCinema1.Size = new System.Drawing.Size(611, 414);
            this.guiCinema1.TabIndex = 0;
            // 
            // PlaytimeTab
            // 
            this.PlaytimeTab.Controls.Add(this.guiPlaytime1);
            this.PlaytimeTab.Location = new System.Drawing.Point(169, 4);
            this.PlaytimeTab.Name = "PlaytimeTab";
            this.PlaytimeTab.Padding = new System.Windows.Forms.Padding(3);
            this.PlaytimeTab.Size = new System.Drawing.Size(588, 423);
            this.PlaytimeTab.TabIndex = 5;
            this.PlaytimeTab.Text = "Spilletider";
            this.PlaytimeTab.UseVisualStyleBackColor = true;
            // 
            // guiPlaytime1
            // 
            this.guiPlaytime1.Location = new System.Drawing.Point(4, 3);
            this.guiPlaytime1.Name = "guiPlaytime1";
            this.guiPlaytime1.Size = new System.Drawing.Size(606, 414);
            this.guiPlaytime1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.guiBooking1);
            this.tabPage1.Location = new System.Drawing.Point(169, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(588, 423);
            this.tabPage1.TabIndex = 6;
            this.tabPage1.Text = "Book";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // guiBooking1
            // 
            this.guiBooking1.Location = new System.Drawing.Point(0, 0);
            this.guiBooking1.Name = "guiBooking1";
            this.guiBooking1.Size = new System.Drawing.Size(591, 423);
            this.guiBooking1.TabIndex = 0;
            // 
            // pLogo
            // 
            this.pLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pLogo.BackgroundImage")));
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(785, 100);
            this.pLogo.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.pLogo);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "KinoErKæk";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ShowsTab.ResumeLayout(false);
            this.MovieTab.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.PlaytimeTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pLogo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ShowsTab;
        private System.Windows.Forms.TabPage FrontpageTab;
        private System.Windows.Forms.TabPage MovieTab;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage PlaytimeTab;
        private GUILayer.GUIShow guiShow1;
        private GUILayer.GUIMovie movie1;
        private GUILayer.GUIPlaytime guiPlaytime1;
        private GUILayer.GUICinema guiCinema1;
        private System.Windows.Forms.TabPage tabPage1;
        private GUILayer.GUIBooking guiBooking1;
    }
}

