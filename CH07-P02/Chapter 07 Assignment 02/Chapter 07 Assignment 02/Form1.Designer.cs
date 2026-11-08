namespace Chapter_07_Assignment_02
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.totalCorrectLabel = new System.Windows.Forms.Label();
            this.correctAnswers = new System.Windows.Forms.Label();
            this.totalIncorrectLabel = new System.Windows.Forms.Label();
            this.incorrectAnswers = new System.Windows.Forms.Label();
            this.incorrectAnswerNumbers = new System.Windows.Forms.ListBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(125, 30);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(182, 32);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Driving Exam";
            // 
            // totalCorrectLabel
            // 
            this.totalCorrectLabel.AutoSize = true;
            this.totalCorrectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCorrectLabel.Location = new System.Drawing.Point(37, 100);
            this.totalCorrectLabel.Name = "totalCorrectLabel";
            this.totalCorrectLabel.Size = new System.Drawing.Size(212, 25);
            this.totalCorrectLabel.TabIndex = 1;
            this.totalCorrectLabel.Text = "Total Correct Answers:";
            // 
            // correctAnswers
            // 
            this.correctAnswers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.correctAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctAnswers.Location = new System.Drawing.Point(274, 102);
            this.correctAnswers.Name = "correctAnswers";
            this.correctAnswers.Size = new System.Drawing.Size(100, 23);
            this.correctAnswers.TabIndex = 2;
            // 
            // totalIncorrectLabel
            // 
            this.totalIncorrectLabel.AutoSize = true;
            this.totalIncorrectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalIncorrectLabel.Location = new System.Drawing.Point(26, 185);
            this.totalIncorrectLabel.Name = "totalIncorrectLabel";
            this.totalIncorrectLabel.Size = new System.Drawing.Size(223, 25);
            this.totalIncorrectLabel.TabIndex = 3;
            this.totalIncorrectLabel.Text = "Total Incorrect Answers:";
            // 
            // incorrectAnswers
            // 
            this.incorrectAnswers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.incorrectAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrectAnswers.Location = new System.Drawing.Point(274, 185);
            this.incorrectAnswers.Name = "incorrectAnswers";
            this.incorrectAnswers.Size = new System.Drawing.Size(100, 23);
            this.incorrectAnswers.TabIndex = 4;
            // 
            // incorrectAnswerNumbers
            // 
            this.incorrectAnswerNumbers.FormattingEnabled = true;
            this.incorrectAnswerNumbers.ItemHeight = 16;
            this.incorrectAnswerNumbers.Location = new System.Drawing.Point(42, 260);
            this.incorrectAnswerNumbers.Name = "incorrectAnswerNumbers";
            this.incorrectAnswerNumbers.Size = new System.Drawing.Size(343, 212);
            this.incorrectAnswerNumbers.TabIndex = 5;
            // 
            // checkButton
            // 
            this.checkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkButton.Location = new System.Drawing.Point(52, 507);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(148, 45);
            this.checkButton.TabIndex = 6;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(225, 507);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(148, 45);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 592);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.incorrectAnswerNumbers);
            this.Controls.Add(this.incorrectAnswers);
            this.Controls.Add(this.totalIncorrectLabel);
            this.Controls.Add(this.correctAnswers);
            this.Controls.Add(this.totalCorrectLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label totalCorrectLabel;
        private System.Windows.Forms.Label correctAnswers;
        private System.Windows.Forms.Label totalIncorrectLabel;
        private System.Windows.Forms.Label incorrectAnswers;
        private System.Windows.Forms.ListBox incorrectAnswerNumbers;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button exitButton;
    }
}

