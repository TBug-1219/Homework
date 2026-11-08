namespace Chapter_04_Assignment_02
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
            this.titleLabelBox = new System.Windows.Forms.Label();
            this.trainingListBox = new System.Windows.Forms.ListBox();
            this.locationListBox = new System.Windows.Forms.ListBox();
            this.registrationLabel = new System.Windows.Forms.Label();
            this.lodgingLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.registrationCost = new System.Windows.Forms.Label();
            this.lodgingCost = new System.Windows.Forms.Label();
            this.totalCost = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabelBox
            // 
            this.titleLabelBox.AutoSize = true;
            this.titleLabelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabelBox.Location = new System.Drawing.Point(125, 18);
            this.titleLabelBox.Name = "titleLabelBox";
            this.titleLabelBox.Size = new System.Drawing.Size(266, 32);
            this.titleLabelBox.TabIndex = 0;
            this.titleLabelBox.Text = "Training Workshops";
            // 
            // trainingListBox
            // 
            this.trainingListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainingListBox.FormattingEnabled = true;
            this.trainingListBox.ItemHeight = 25;
            this.trainingListBox.Items.AddRange(new object[] {
            "Handling Stress",
            "Time Management",
            "Supervision Skills",
            "Negotiation",
            "How to Interview"});
            this.trainingListBox.Location = new System.Drawing.Point(41, 67);
            this.trainingListBox.Name = "trainingListBox";
            this.trainingListBox.Size = new System.Drawing.Size(202, 179);
            this.trainingListBox.TabIndex = 1;
            // 
            // locationListBox
            // 
            this.locationListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationListBox.FormattingEnabled = true;
            this.locationListBox.ItemHeight = 25;
            this.locationListBox.Items.AddRange(new object[] {
            "Austin",
            "Chicago",
            "Dallas",
            "Orlando",
            "Pheonix",
            "Raleigh"});
            this.locationListBox.Location = new System.Drawing.Point(267, 67);
            this.locationListBox.Name = "locationListBox";
            this.locationListBox.Size = new System.Drawing.Size(202, 179);
            this.locationListBox.TabIndex = 2;
            // 
            // registrationLabel
            // 
            this.registrationLabel.AutoSize = true;
            this.registrationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationLabel.Location = new System.Drawing.Point(139, 266);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(104, 20);
            this.registrationLabel.TabIndex = 3;
            this.registrationLabel.Text = "Registration:";
            // 
            // lodgingLabel
            // 
            this.lodgingLabel.AutoSize = true;
            this.lodgingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lodgingLabel.Location = new System.Drawing.Point(170, 301);
            this.lodgingLabel.Name = "lodgingLabel";
            this.lodgingLabel.Size = new System.Drawing.Size(73, 20);
            this.lodgingLabel.TabIndex = 4;
            this.lodgingLabel.Text = "Lodging:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(192, 337);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(51, 20);
            this.totalLabel.TabIndex = 5;
            this.totalLabel.Text = "Total:";
            // 
            // registrationCost
            // 
            this.registrationCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registrationCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationCost.Location = new System.Drawing.Point(249, 263);
            this.registrationCost.Name = "registrationCost";
            this.registrationCost.Size = new System.Drawing.Size(100, 23);
            this.registrationCost.TabIndex = 6;
            // 
            // lodgingCost
            // 
            this.lodgingCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lodgingCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lodgingCost.Location = new System.Drawing.Point(249, 300);
            this.lodgingCost.Name = "lodgingCost";
            this.lodgingCost.Size = new System.Drawing.Size(100, 23);
            this.lodgingCost.TabIndex = 7;
            // 
            // totalCost
            // 
            this.totalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCost.Location = new System.Drawing.Point(249, 337);
            this.totalCost.Name = "totalCost";
            this.totalCost.Size = new System.Drawing.Size(100, 23);
            this.totalCost.TabIndex = 8;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(105, 381);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(103, 42);
            this.calculateButton.TabIndex = 9;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(288, 381);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(103, 42);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalCost);
            this.Controls.Add(this.lodgingCost);
            this.Controls.Add(this.registrationCost);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.lodgingLabel);
            this.Controls.Add(this.registrationLabel);
            this.Controls.Add(this.locationListBox);
            this.Controls.Add(this.trainingListBox);
            this.Controls.Add(this.titleLabelBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabelBox;
        private System.Windows.Forms.ListBox trainingListBox;
        private System.Windows.Forms.ListBox locationListBox;
        private System.Windows.Forms.Label registrationLabel;
        private System.Windows.Forms.Label lodgingLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label registrationCost;
        private System.Windows.Forms.Label lodgingCost;
        private System.Windows.Forms.Label totalCost;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
    }
}

