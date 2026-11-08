namespace NumericData
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
            this.readValuesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // readValuesButton
            // 
            this.readValuesButton.Location = new System.Drawing.Point(29, 25);
            this.readValuesButton.Name = "readValuesButton";
            this.readValuesButton.Size = new System.Drawing.Size(75, 40);
            this.readValuesButton.TabIndex = 0;
            this.readValuesButton.Text = "Read Values";
            this.readValuesButton.UseVisualStyleBackColor = true;
            this.readValuesButton.Click += new System.EventHandler(this.readValuesButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(110, 25);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 40);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 90);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.readValuesButton);
            this.Name = "Form1";
            this.Text = "Numeric Data";
            this.ResumeLayout(false);

        }

        #endregion

        private Button readValuesButton;
        private Button exitButton;
    }
}