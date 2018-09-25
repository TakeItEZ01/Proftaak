namespace Test_TESSA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TestPic = new System.Windows.Forms.PictureBox();
            this.buttonTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TestPic)).BeginInit();
            this.SuspendLayout();
            // 
            // TestPic
            // 
            this.TestPic.ErrorImage = ((System.Drawing.Image)(resources.GetObject("TestPic.ErrorImage")));
            this.TestPic.Image = ((System.Drawing.Image)(resources.GetObject("TestPic.Image")));
            this.TestPic.InitialImage = ((System.Drawing.Image)(resources.GetObject("TestPic.InitialImage")));
            this.TestPic.Location = new System.Drawing.Point(652, 56);
            this.TestPic.Name = "TestPic";
            this.TestPic.Size = new System.Drawing.Size(85, 77);
            this.TestPic.TabIndex = 0;
            this.TestPic.TabStop = false;
            this.TestPic.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(691, 337);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 23);
            this.buttonTest.TabIndex = 1;
            this.buttonTest.Text = "button1";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.TestPic);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TestPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox TestPic;
        private System.Windows.Forms.Button buttonTest;
    }
}

