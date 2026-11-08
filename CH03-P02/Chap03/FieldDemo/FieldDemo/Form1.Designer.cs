namespace FieldDemo
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
            this.showNameButton = new System.Windows.Forms.Button();
            this.dariusButton = new System.Windows.Forms.Button();
            this.carmenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showNameButton
            // 
            this.showNameButton.Location = new System.Drawing.Point(68, 21);
            this.showNameButton.Name = "showNameButton";
            this.showNameButton.Size = new System.Drawing.Size(93, 45);
            this.showNameButton.TabIndex = 0;
            this.showNameButton.Text = "Show Name";
            this.showNameButton.UseVisualStyleBackColor = true;
            this.showNameButton.Click += new System.EventHandler(this.showNameButton_Click);
            // 
            // dariusButton
            // 
            this.dariusButton.Location = new System.Drawing.Point(21, 72);
            this.dariusButton.Name = "dariusButton";
            this.dariusButton.Size = new System.Drawing.Size(93, 45);
            this.dariusButton.TabIndex = 1;
            this.dariusButton.Text = "Change Name to Darius";
            this.dariusButton.UseVisualStyleBackColor = true;
            this.dariusButton.Click += new System.EventHandler(this.dariusButton_Click);
            // 
            // carmenButton
            // 
            this.carmenButton.Location = new System.Drawing.Point(120, 72);
            this.carmenButton.Name = "carmenButton";
            this.carmenButton.Size = new System.Drawing.Size(93, 45);
            this.carmenButton.TabIndex = 2;
            this.carmenButton.Text = "Change Name to Carmen";
            this.carmenButton.UseVisualStyleBackColor = true;
            this.carmenButton.Click += new System.EventHandler(this.carmenButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 138);
            this.Controls.Add(this.carmenButton);
            this.Controls.Add(this.dariusButton);
            this.Controls.Add(this.showNameButton);
            this.Name = "Form1";
            this.Text = "Field Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private Button showNameButton;
        private Button dariusButton;
        private Button carmenButton;
    }
}