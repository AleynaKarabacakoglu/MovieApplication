namespace MovieApp
{
    partial class Form1
    {
       
       
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstMovies = new System.Windows.Forms.ListBox();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstCast = new System.Windows.Forms.ListBox();
            this.pictureBoxMovie = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lstDirector = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lstWriter = new System.Windows.Forms.ListBox();
            this.lblDirectors = new System.Windows.Forms.Label();
            this.lblWriters = new System.Windows.Forms.Label();
            this.lblMovie = new System.Windows.Forms.Label();
            this.lblStars = new System.Windows.Forms.Label();
            this.lstStars = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // lstMovies
            // 
            this.lstMovies.FormattingEnabled = true;
            this.lstMovies.Location = new System.Drawing.Point(58, 119);
            this.lstMovies.Name = "lstMovies";
            this.lstMovies.Size = new System.Drawing.Size(124, 108);
            this.lstMovies.TabIndex = 0;
            this.lstMovies.Visible = false;
            this.lstMovies.SelectedIndexChanged += new System.EventHandler(this.lstMovies_SelectedIndexChanged);
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(58, 35);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(124, 20);
            this.txtMovieName.TabIndex = 1;
            this.txtMovieName.Text = "pianist";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(237, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(127, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lstCast
            // 
            this.lstCast.FormattingEnabled = true;
            this.lstCast.Location = new System.Drawing.Point(658, 304);
            this.lstCast.Name = "lstCast";
            this.lstCast.Size = new System.Drawing.Size(127, 108);
            this.lstCast.TabIndex = 5;
            this.lstCast.Visible = false;
            // 
            // pictureBoxMovie
            // 
            this.pictureBoxMovie.Location = new System.Drawing.Point(393, 32);
            this.pictureBoxMovie.Name = "pictureBoxMovie";
            this.pictureBoxMovie.Size = new System.Drawing.Size(239, 380);
            this.pictureBoxMovie.TabIndex = 6;
            this.pictureBoxMovie.TabStop = false;
            this.pictureBoxMovie.Visible = false;
            // 
            // lstDirector
            // 
            this.lstDirector.FormattingEnabled = true;
            this.lstDirector.Location = new System.Drawing.Point(58, 293);
            this.lstDirector.Name = "lstDirector";
            this.lstDirector.Size = new System.Drawing.Size(120, 108);
            this.lstDirector.TabIndex = 7;
            this.lstDirector.Visible = false;
            this.lstDirector.SelectedIndexChanged += new System.EventHandler(this.lstDirector_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(658, 234);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 56);
            this.listBox1.TabIndex = 8;
            this.listBox1.Visible = false;
            // 
            // lstWriter
            // 
            this.lstWriter.FormattingEnabled = true;
            this.lstWriter.Location = new System.Drawing.Point(237, 293);
            this.lstWriter.Name = "lstWriter";
            this.lstWriter.Size = new System.Drawing.Size(127, 108);
            this.lstWriter.TabIndex = 9;
            this.lstWriter.Visible = false;
            this.lstWriter.SelectedIndexChanged += new System.EventHandler(this.lstWriter_SelectedIndexChanged);
            // 
            // lblDirectors
            // 
            this.lblDirectors.AutoSize = true;
            this.lblDirectors.Location = new System.Drawing.Point(55, 277);
            this.lblDirectors.Name = "lblDirectors";
            this.lblDirectors.Size = new System.Drawing.Size(49, 13);
            this.lblDirectors.TabIndex = 10;
            this.lblDirectors.Text = "Directors";
            this.lblDirectors.Visible = false;
            // 
            // lblWriters
            // 
            this.lblWriters.AutoSize = true;
            this.lblWriters.Location = new System.Drawing.Point(234, 277);
            this.lblWriters.Name = "lblWriters";
            this.lblWriters.Size = new System.Drawing.Size(40, 13);
            this.lblWriters.TabIndex = 11;
            this.lblWriters.Text = "Writers";
            this.lblWriters.Visible = false;
            // 
            // lblMovie
            // 
            this.lblMovie.AutoSize = true;
            this.lblMovie.Location = new System.Drawing.Point(58, 100);
            this.lblMovie.Name = "lblMovie";
            this.lblMovie.Size = new System.Drawing.Size(41, 13);
            this.lblMovie.TabIndex = 12;
            this.lblMovie.Text = "Movies";
            this.lblMovie.Visible = false;
            // 
            // lblStars
            // 
            this.lblStars.AutoSize = true;
            this.lblStars.Location = new System.Drawing.Point(237, 100);
            this.lblStars.Name = "lblStars";
            this.lblStars.Size = new System.Drawing.Size(31, 13);
            this.lblStars.TabIndex = 13;
            this.lblStars.Text = "Stars";
            this.lblStars.Visible = false;
            // 
            // lstStars
            // 
            this.lstStars.FormattingEnabled = true;
            this.lstStars.Location = new System.Drawing.Point(234, 119);
            this.lstStars.Name = "lstStars";
            this.lstStars.Size = new System.Drawing.Size(130, 108);
            this.lstStars.TabIndex = 14;
            this.lstStars.Visible = false;
            this.lstStars.SelectedIndexChanged += new System.EventHandler(this.lstStars_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 442);
            this.Controls.Add(this.lstStars);
            this.Controls.Add(this.lblStars);
            this.Controls.Add(this.lblMovie);
            this.Controls.Add(this.lblWriters);
            this.Controls.Add(this.lblDirectors);
            this.Controls.Add(this.lstWriter);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lstDirector);
            this.Controls.Add(this.pictureBoxMovie);
            this.Controls.Add(this.lstCast);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtMovieName);
            this.Controls.Add(this.lstMovies);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMovies;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lstCast;
        private System.Windows.Forms.PictureBox pictureBoxMovie;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox lstDirector;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox lstWriter;
        private System.Windows.Forms.Label lblDirectors;
        private System.Windows.Forms.Label lblWriters;
        private System.Windows.Forms.Label lblMovie;
        private System.Windows.Forms.Label lblStars;
        private System.Windows.Forms.ListBox lstStars;
    }
}

