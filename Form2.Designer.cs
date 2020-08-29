namespace MovieApp
{
    partial class Form2
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
            this.pictureBoxCast = new System.Windows.Forms.PictureBox();
            this.txtBio = new System.Windows.Forms.RichTextBox();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCast)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCast
            // 
            this.pictureBoxCast.Location = new System.Drawing.Point(12, 22);
            this.pictureBoxCast.Name = "pictureBoxCast";
            this.pictureBoxCast.Size = new System.Drawing.Size(219, 297);
            this.pictureBoxCast.TabIndex = 0;
            this.pictureBoxCast.TabStop = false;
            // 
            // txtBio
            // 
            this.txtBio.Location = new System.Drawing.Point(258, 127);
            this.txtBio.Name = "txtBio";
            this.txtBio.Size = new System.Drawing.Size(474, 115);
            this.txtBio.TabIndex = 3;
            this.txtBio.Text = "";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblName.Location = new System.Drawing.Point(254, 91);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 24);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 355);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtBio);
            this.Controls.Add(this.pictureBoxCast);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCast;
        
        private System.Windows.Forms.RichTextBox txtBio;
        private System.Windows.Forms.Label lblName;
    }
}