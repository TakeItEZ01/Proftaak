namespace Programma_TESSA
{
    partial class TESSA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TESSA));
            this.Ham = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Ham
            // 
            this.Ham.AccessibleName = "Ham";
            this.Ham.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ham.BackgroundImage")));
            this.Ham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ham.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Ham.Location = new System.Drawing.Point(118, 57);
            this.Ham.Name = "Ham";
            this.Ham.Size = new System.Drawing.Size(153, 123);
            this.Ham.TabIndex = 0;
            this.Ham.TabStop = false;
            this.Ham.Click += new System.EventHandler(this.Ham_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(350, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // TESSA
            // 
            this.AccessibleName = "TESSA";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Ham);
            this.Name = "TESSA";
            this.Text = "TESSA";
            ((System.ComponentModel.ISupportInitialize)(this.Ham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Ham;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

