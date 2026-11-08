namespace Cat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.catPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.catPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // catPictureBox
            // 
            this.catPictureBox.Image = global::Cat.Properties.Resources.Cat;
            this.catPictureBox.Location = new System.Drawing.Point(12, 43);
            this.catPictureBox.Name = "catPictureBox";
            this.catPictureBox.Size = new System.Drawing.Size(190, 181);
            this.catPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.catPictureBox.TabIndex = 0;
            this.catPictureBox.TabStop = false;
            this.catPictureBox.Click += new System.EventHandler(this.catPictureBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click the Cat!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 232);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.catPictureBox);
            this.Name = "Form1";
            this.Text = "Cat";
            ((System.ComponentModel.ISupportInitialize)(this.catPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox catPictureBox;
        private Label label1;
    }
}