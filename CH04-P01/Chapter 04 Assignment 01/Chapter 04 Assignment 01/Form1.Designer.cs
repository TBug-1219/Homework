namespace Chapter_04_Assignment_01
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
            this.serendipityBooksellers = new System.Windows.Forms.Label();
            this.instructionsBox = new System.Windows.Forms.Label();
            this.numBox = new System.Windows.Forms.TextBox();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.ageCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // serendipityBooksellers
            // 
            this.serendipityBooksellers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serendipityBooksellers.Location = new System.Drawing.Point(240, 25);
            this.serendipityBooksellers.Name = "serendipityBooksellers";
            this.serendipityBooksellers.Size = new System.Drawing.Size(325, 62);
            this.serendipityBooksellers.TabIndex = 0;
            this.serendipityBooksellers.Text = "Serendipity Booksellers";
            // 
            // instructionsBox
            // 
            this.instructionsBox.AutoSize = true;
            this.instructionsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsBox.Location = new System.Drawing.Point(83, 112);
            this.instructionsBox.Name = "instructionsBox";
            this.instructionsBox.Size = new System.Drawing.Size(377, 20);
            this.instructionsBox.TabIndex = 1;
            this.instructionsBox.Text = "Enter the number of books purchased this month:";
            // 
            // numBox
            // 
            this.numBox.Location = new System.Drawing.Point(546, 112);
            this.numBox.Name = "numBox";
            this.numBox.Size = new System.Drawing.Size(100, 22);
            this.numBox.TabIndex = 2;
            // 
            // pointsLabel
            // 
            this.pointsLabel.BackColor = System.Drawing.SystemColors.Control;
            this.pointsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pointsLabel.Location = new System.Drawing.Point(226, 214);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(305, 61);
            this.pointsLabel.TabIndex = 3;
            this.pointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pointsLabel.UseCompatibleTextRendering = true;
            this.pointsLabel.Click += new System.EventHandler(this.pointsLabel_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(197, 314);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(123, 51);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(434, 314);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(117, 51);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ageCheck
            // 
            this.ageCheck.AutoSize = true;
            this.ageCheck.Location = new System.Drawing.Point(302, 161);
            this.ageCheck.Name = "ageCheck";
            this.ageCheck.Size = new System.Drawing.Size(158, 20);
            this.ageCheck.TabIndex = 6;
            this.ageCheck.Text = "Check if older than 55.";
            this.ageCheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ageCheck);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.numBox);
            this.Controls.Add(this.instructionsBox);
            this.Controls.Add(this.serendipityBooksellers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label serendipityBooksellers;
        private System.Windows.Forms.Label instructionsBox;
        private System.Windows.Forms.TextBox numBox;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.CheckBox ageCheck;
    }
}

