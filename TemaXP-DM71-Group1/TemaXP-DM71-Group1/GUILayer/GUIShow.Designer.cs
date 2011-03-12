namespace TemaXP_DM71_Group1.GUILayer
{
    partial class GUIShow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbShow = new System.Windows.Forms.ComboBox();
            this.cmbCinema = new System.Windows.Forms.ComboBox();
            this.cmbMovieStartTime = new System.Windows.Forms.ComboBox();
            this.cmbMovie = new System.Windows.Forms.ComboBox();
            this.dtpMovieDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(55, 242);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Opret";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Opdater";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(353, 73);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Slet";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Starttidspunkt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Film";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Vælg Forestilling";
            // 
            // cmbShow
            // 
            this.cmbShow.FormattingEnabled = true;
            this.cmbShow.Location = new System.Drawing.Point(142, 46);
            this.cmbShow.Name = "cmbShow";
            this.cmbShow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbShow.Size = new System.Drawing.Size(286, 21);
            this.cmbShow.TabIndex = 8;
            // 
            // cmbCinema
            // 
            this.cmbCinema.FormattingEnabled = true;
            this.cmbCinema.Items.AddRange(new object[] {
            "Sal 1",
            "Sal 2"});
            this.cmbCinema.Location = new System.Drawing.Point(142, 210);
            this.cmbCinema.Name = "cmbCinema";
            this.cmbCinema.Size = new System.Drawing.Size(288, 21);
            this.cmbCinema.TabIndex = 9;
            // 
            // cmbMovieStartTime
            // 
            this.cmbMovieStartTime.FormattingEnabled = true;
            this.cmbMovieStartTime.Location = new System.Drawing.Point(142, 156);
            this.cmbMovieStartTime.Name = "cmbMovieStartTime";
            this.cmbMovieStartTime.Size = new System.Drawing.Size(288, 21);
            this.cmbMovieStartTime.TabIndex = 11;
            // 
            // cmbMovie
            // 
            this.cmbMovie.FormattingEnabled = true;
            this.cmbMovie.Location = new System.Drawing.Point(142, 183);
            this.cmbMovie.Name = "cmbMovie";
            this.cmbMovie.Size = new System.Drawing.Size(288, 21);
            this.cmbMovie.TabIndex = 12;
            // 
            // dtpMovieDate
            // 
            this.dtpMovieDate.Location = new System.Drawing.Point(142, 130);
            this.dtpMovieDate.MinDate = new System.DateTime(2011, 3, 11, 0, 0, 0, 0);
            this.dtpMovieDate.Name = "dtpMovieDate";
            this.dtpMovieDate.Size = new System.Drawing.Size(288, 20);
            this.dtpMovieDate.TabIndex = 13;
            // 
            // GUIShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpMovieDate);
            this.Controls.Add(this.cmbMovie);
            this.Controls.Add(this.cmbMovieStartTime);
            this.Controls.Add(this.cmbCinema);
            this.Controls.Add(this.cmbShow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCreate);
            this.Name = "GUIShow";
            this.Size = new System.Drawing.Size(572, 435);
            this.Enter += new System.EventHandler(this.Show_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbShow;
        private System.Windows.Forms.ComboBox cmbCinema;
        private System.Windows.Forms.ComboBox cmbMovieStartTime;
        private System.Windows.Forms.ComboBox cmbMovie;
        private System.Windows.Forms.DateTimePicker dtpMovieDate;
    }
}
