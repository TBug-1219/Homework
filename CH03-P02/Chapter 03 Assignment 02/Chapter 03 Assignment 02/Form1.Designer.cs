namespace Chapter_03_Assignment_02
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
            this.pearBox = new System.Windows.Forms.PictureBox();
            this.appleBox = new System.Windows.Forms.PictureBox();
            this.orangeBox = new System.Windows.Forms.PictureBox();
            this.bananaBox = new System.Windows.Forms.PictureBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalNum = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pearBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appleBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bananaBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pearBox
            // 
            this.pearBox.Image = global::Chapter_03_Assignment_02.Properties.Resources.PearPrice;
            this.pearBox.Location = new System.Drawing.Point(243, 253);
            this.pearBox.Name = "pearBox";
            this.pearBox.Size = new System.Drawing.Size(129, 156);
            this.pearBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pearBox.TabIndex = 3;
            this.pearBox.TabStop = false;
            this.pearBox.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // appleBox
            // 
            this.appleBox.Image = global::Chapter_03_Assignment_02.Properties.Resources.ApplePrice;
            this.appleBox.Location = new System.Drawing.Point(243, 53);
            this.appleBox.Name = "appleBox";
            this.appleBox.Size = new System.Drawing.Size(129, 156);
            this.appleBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.appleBox.TabIndex = 2;
            this.appleBox.TabStop = false;
            this.appleBox.Click += new System.EventHandler(this.appleBox_Click);
            // 
            // orangeBox
            // 
            this.orangeBox.Image = global::Chapter_03_Assignment_02.Properties.Resources.OrangePrice;
            this.orangeBox.Location = new System.Drawing.Point(59, 253);
            this.orangeBox.Name = "orangeBox";
            this.orangeBox.Size = new System.Drawing.Size(129, 156);
            this.orangeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.orangeBox.TabIndex = 1;
            this.orangeBox.TabStop = false;
            this.orangeBox.Click += new System.EventHandler(this.orangeBox_Click);
            // 
            // bananaBox
            // 
            this.bananaBox.Image = global::Chapter_03_Assignment_02.Properties.Resources.BananaPrice;
            this.bananaBox.Location = new System.Drawing.Point(59, 53);
            this.bananaBox.Name = "bananaBox";
            this.bananaBox.Size = new System.Drawing.Size(129, 156);
            this.bananaBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bananaBox.TabIndex = 0;
            this.bananaBox.TabStop = false;
            this.bananaBox.Click += new System.EventHandler(this.bananaBox_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(470, 53);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(81, 36);
            this.totalLabel.TabIndex = 4;
            this.totalLabel.Text = "Total";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // totalNum
            // 
            this.totalNum.BackColor = System.Drawing.SystemColors.Control;
            this.totalNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalNum.Location = new System.Drawing.Point(445, 113);
            this.totalNum.Name = "totalNum";
            this.totalNum.Size = new System.Drawing.Size(129, 35);
            this.totalNum.TabIndex = 5;
            this.totalNum.Text = "0.00";
            this.totalNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalNum.UseWaitCursor = true;
            this.totalNum.Click += new System.EventHandler(this.label2_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(463, 286);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(98, 36);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(463, 347);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(98, 34);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 452);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.totalNum);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.pearBox);
            this.Controls.Add(this.appleBox);
            this.Controls.Add(this.orangeBox);
            this.Controls.Add(this.bananaBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pearBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appleBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bananaBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bananaBox;
        private System.Windows.Forms.PictureBox orangeBox;
        private System.Windows.Forms.PictureBox appleBox;
        private System.Windows.Forms.PictureBox pearBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalNum;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
    }
}

