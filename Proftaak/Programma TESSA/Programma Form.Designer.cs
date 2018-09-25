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
            this.Ham = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ham)).BeginInit();
            this.SuspendLayout();
            // 
            // Ham
            // 
            this.Ham.AccessibleName = "Ham";
            this.Ham.Location = new System.Drawing.Point(336, 162);
            this.Ham.Name = "Ham";
            this.Ham.Size = new System.Drawing.Size(122, 73);
            this.Ham.TabIndex = 0;
            this.Ham.TabStop = false;
            this.Ham.Click += new System.EventHandler(this.Ham_Click);
            // 
            // TESSA
            // 
            this.AccessibleName = "TESSA";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ham);
            this.Name = "TESSA";
            this.Text = "TESSA";
            ((System.ComponentModel.ISupportInitialize)(this.Ham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Ham;
    }
}

