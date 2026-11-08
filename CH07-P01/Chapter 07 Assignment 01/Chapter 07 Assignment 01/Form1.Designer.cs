namespace Chapter_07_Assignment_01
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
            this.salesListBox = new System.Windows.Forms.ListBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalLabelBox = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.averageLabelBox = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // salesListBox
            // 
            this.salesListBox.FormattingEnabled = true;
            this.salesListBox.ItemHeight = 16;
            this.salesListBox.Location = new System.Drawing.Point(29, 12);
            this.salesListBox.Name = "salesListBox";
            this.salesListBox.Size = new System.Drawing.Size(352, 244);
            this.salesListBox.TabIndex = 0;
            // 
            // totalLabel
            // 
            this.totalLabel.Location = new System.Drawing.Point(131, 290);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(44, 23);
            this.totalLabel.TabIndex = 1;
            this.totalLabel.Text = "Total: ";
            // 
            // totalLabelBox
            // 
            this.totalLabelBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabelBox.Location = new System.Drawing.Point(200, 290);
            this.totalLabelBox.Name = "totalLabelBox";
            this.totalLabelBox.Size = new System.Drawing.Size(100, 23);
            this.totalLabelBox.TabIndex = 2;
            // 
            // averageLabel
            // 
            this.averageLabel.Location = new System.Drawing.Point(117, 333);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(68, 23);
            this.averageLabel.TabIndex = 3;
            this.averageLabel.Text = "Average: ";
            // 
            // averageLabelBox
            // 
            this.averageLabelBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageLabelBox.Location = new System.Drawing.Point(200, 332);
            this.averageLabelBox.Name = "averageLabelBox";
            this.averageLabelBox.Size = new System.Drawing.Size(100, 23);
            this.averageLabelBox.TabIndex = 4;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(76, 379);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(109, 40);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(223, 379);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(109, 40);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.averageLabelBox);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.totalLabelBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.salesListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox salesListBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalLabelBox;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label averageLabelBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
    }
}

