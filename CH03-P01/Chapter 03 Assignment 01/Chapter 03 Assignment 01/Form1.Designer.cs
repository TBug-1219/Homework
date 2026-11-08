namespace Chapter_03_Assignment_01
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
            this.bigCatExhibit = new System.Windows.Forms.Label();
            this.infoBox = new System.Windows.Forms.GroupBox();
            this.calculateBox = new System.Windows.Forms.GroupBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.tigersNum = new System.Windows.Forms.Label();
            this.LionsNum = new System.Windows.Forms.Label();
            this.totalNum = new System.Windows.Forms.Label();
            this.tigersText = new System.Windows.Forms.TextBox();
            this.lionsText = new System.Windows.Forms.TextBox();
            this.totalText = new System.Windows.Forms.TextBox();
            this.pergentagesLabel = new System.Windows.Forms.Label();
            this.tigersPercentage = new System.Windows.Forms.Label();
            this.lionsPercentage = new System.Windows.Forms.Label();
            this.tigersPerText = new System.Windows.Forms.TextBox();
            this.lionsPerText = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.infoBox.SuspendLayout();
            this.calculateBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // bigCatExhibit
            // 
            this.bigCatExhibit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigCatExhibit.Location = new System.Drawing.Point(208, 9);
            this.bigCatExhibit.Name = "bigCatExhibit";
            this.bigCatExhibit.Size = new System.Drawing.Size(375, 62);
            this.bigCatExhibit.TabIndex = 0;
            this.bigCatExhibit.Text = "Big Cat Exhibit";
            this.bigCatExhibit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoBox
            // 
            this.infoBox.Controls.Add(this.totalText);
            this.infoBox.Controls.Add(this.lionsText);
            this.infoBox.Controls.Add(this.tigersText);
            this.infoBox.Controls.Add(this.totalNum);
            this.infoBox.Controls.Add(this.LionsNum);
            this.infoBox.Controls.Add(this.tigersNum);
            this.infoBox.Controls.Add(this.instructionLabel);
            this.infoBox.Controls.Add(this.infoLabel);
            this.infoBox.Location = new System.Drawing.Point(29, 74);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(316, 232);
            this.infoBox.TabIndex = 1;
            this.infoBox.TabStop = false;
            // 
            // calculateBox
            // 
            this.calculateBox.Controls.Add(this.lionsPerText);
            this.calculateBox.Controls.Add(this.tigersPerText);
            this.calculateBox.Controls.Add(this.lionsPercentage);
            this.calculateBox.Controls.Add(this.tigersPercentage);
            this.calculateBox.Controls.Add(this.pergentagesLabel);
            this.calculateBox.Location = new System.Drawing.Point(444, 74);
            this.calculateBox.Name = "calculateBox";
            this.calculateBox.Size = new System.Drawing.Size(316, 232);
            this.calculateBox.TabIndex = 2;
            this.calculateBox.TabStop = false;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(72, 18);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(157, 25);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Tigers/Lions Info";
            this.infoLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.Location = new System.Drawing.Point(15, 52);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(295, 39);
            this.instructionLabel.TabIndex = 1;
            this.instructionLabel.Text = "Enter the number of tigers and lions in their corresponding textbox.";
            // 
            // tigersNum
            // 
            this.tigersNum.AutoSize = true;
            this.tigersNum.Location = new System.Drawing.Point(15, 105);
            this.tigersNum.Name = "tigersNum";
            this.tigersNum.Size = new System.Drawing.Size(52, 16);
            this.tigersNum.TabIndex = 2;
            this.tigersNum.Text = "Tigers: ";
            this.tigersNum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LionsNum
            // 
            this.LionsNum.AutoSize = true;
            this.LionsNum.Location = new System.Drawing.Point(19, 137);
            this.LionsNum.Name = "LionsNum";
            this.LionsNum.Size = new System.Drawing.Size(45, 16);
            this.LionsNum.TabIndex = 3;
            this.LionsNum.Text = "Lions: ";
            this.LionsNum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // totalNum
            // 
            this.totalNum.AutoSize = true;
            this.totalNum.Location = new System.Drawing.Point(16, 169);
            this.totalNum.Name = "totalNum";
            this.totalNum.Size = new System.Drawing.Size(44, 16);
            this.totalNum.TabIndex = 4;
            this.totalNum.Text = "Total: ";
            this.totalNum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tigersText
            // 
            this.tigersText.Location = new System.Drawing.Point(77, 99);
            this.tigersText.Name = "tigersText";
            this.tigersText.Size = new System.Drawing.Size(100, 22);
            this.tigersText.TabIndex = 5;
            // 
            // lionsText
            // 
            this.lionsText.Location = new System.Drawing.Point(77, 132);
            this.lionsText.Name = "lionsText";
            this.lionsText.Size = new System.Drawing.Size(100, 22);
            this.lionsText.TabIndex = 6;
            // 
            // totalText
            // 
            this.totalText.Location = new System.Drawing.Point(77, 169);
            this.totalText.Name = "totalText";
            this.totalText.Size = new System.Drawing.Size(100, 22);
            this.totalText.TabIndex = 7;
            // 
            // pergentagesLabel
            // 
            this.pergentagesLabel.AutoSize = true;
            this.pergentagesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pergentagesLabel.Location = new System.Drawing.Point(96, 18);
            this.pergentagesLabel.Name = "pergentagesLabel";
            this.pergentagesLabel.Size = new System.Drawing.Size(122, 25);
            this.pergentagesLabel.TabIndex = 0;
            this.pergentagesLabel.Text = "Percentages";
            // 
            // tigersPercentage
            // 
            this.tigersPercentage.AutoSize = true;
            this.tigersPercentage.Location = new System.Drawing.Point(37, 99);
            this.tigersPercentage.Name = "tigersPercentage";
            this.tigersPercentage.Size = new System.Drawing.Size(52, 16);
            this.tigersPercentage.TabIndex = 1;
            this.tigersPercentage.Text = "Tigers: ";
            this.tigersPercentage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lionsPercentage
            // 
            this.lionsPercentage.AutoSize = true;
            this.lionsPercentage.Location = new System.Drawing.Point(44, 140);
            this.lionsPercentage.Name = "lionsPercentage";
            this.lionsPercentage.Size = new System.Drawing.Size(45, 16);
            this.lionsPercentage.TabIndex = 2;
            this.lionsPercentage.Text = "Lions: ";
            this.lionsPercentage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tigersPerText
            // 
            this.tigersPerText.Location = new System.Drawing.Point(118, 93);
            this.tigersPerText.Name = "tigersPerText";
            this.tigersPerText.Size = new System.Drawing.Size(100, 22);
            this.tigersPerText.TabIndex = 3;
            // 
            // lionsPerText
            // 
            this.lionsPerText.Location = new System.Drawing.Point(118, 137);
            this.lionsPerText.Name = "lionsPerText";
            this.lionsPerText.Size = new System.Drawing.Size(100, 22);
            this.lionsPerText.TabIndex = 4;
            // 
            // Calculate
            // 
            this.Calculate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Calculate.Location = new System.Drawing.Point(97, 335);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(128, 54);
            this.Calculate.TabIndex = 3;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = false;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Clear.Location = new System.Drawing.Point(325, 335);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(128, 54);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Exit.Location = new System.Drawing.Point(553, 335);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(128, 54);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.calculateBox);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.bigCatExhibit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.infoBox.ResumeLayout(false);
            this.infoBox.PerformLayout();
            this.calculateBox.ResumeLayout(false);
            this.calculateBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label bigCatExhibit;
        private System.Windows.Forms.GroupBox infoBox;
        private System.Windows.Forms.Label LionsNum;
        private System.Windows.Forms.Label tigersNum;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.GroupBox calculateBox;
        private System.Windows.Forms.TextBox totalText;
        private System.Windows.Forms.TextBox lionsText;
        private System.Windows.Forms.TextBox tigersText;
        private System.Windows.Forms.Label totalNum;
        private System.Windows.Forms.TextBox lionsPerText;
        private System.Windows.Forms.TextBox tigersPerText;
        private System.Windows.Forms.Label lionsPercentage;
        private System.Windows.Forms.Label tigersPercentage;
        private System.Windows.Forms.Label pergentagesLabel;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Exit;
    }
}

