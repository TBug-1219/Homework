namespace Chapter_06_Assignment_01
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
            this.formLabel = new System.Windows.Forms.Label();
            this.wholesaleLabel = new System.Windows.Forms.Label();
            this.markupLabel = new System.Windows.Forms.Label();
            this.wholesaleText = new System.Windows.Forms.TextBox();
            this.markupText = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.retailPriceLabel = new System.Windows.Forms.Label();
            this.priceNumLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // formLabel
            // 
            this.formLabel.AutoSize = true;
            this.formLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formLabel.Location = new System.Drawing.Point(181, 23);
            this.formLabel.Name = "formLabel";
            this.formLabel.Size = new System.Drawing.Size(183, 32);
            this.formLabel.TabIndex = 0;
            this.formLabel.Text = "Retail Pricing";
            // 
            // wholesaleLabel
            // 
            this.wholesaleLabel.AutoSize = true;
            this.wholesaleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wholesaleLabel.Location = new System.Drawing.Point(80, 94);
            this.wholesaleLabel.Name = "wholesaleLabel";
            this.wholesaleLabel.Size = new System.Drawing.Size(157, 25);
            this.wholesaleLabel.TabIndex = 1;
            this.wholesaleLabel.Text = "Wholesale Cost:";
            // 
            // markupLabel
            // 
            this.markupLabel.AutoSize = true;
            this.markupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markupLabel.Location = new System.Drawing.Point(48, 162);
            this.markupLabel.Name = "markupLabel";
            this.markupLabel.Size = new System.Drawing.Size(189, 25);
            this.markupLabel.TabIndex = 2;
            this.markupLabel.Text = "Markup Percentage:";
            // 
            // wholesaleText
            // 
            this.wholesaleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wholesaleText.Location = new System.Drawing.Point(264, 91);
            this.wholesaleText.Name = "wholesaleText";
            this.wholesaleText.Size = new System.Drawing.Size(172, 30);
            this.wholesaleText.TabIndex = 3;
            // 
            // markupText
            // 
            this.markupText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markupText.Location = new System.Drawing.Point(264, 162);
            this.markupText.Name = "markupText";
            this.markupText.Size = new System.Drawing.Size(172, 30);
            this.markupText.TabIndex = 4;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(199, 222);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(149, 50);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(199, 393);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(149, 50);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // retailPriceLabel
            // 
            this.retailPriceLabel.AutoSize = true;
            this.retailPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retailPriceLabel.Location = new System.Drawing.Point(122, 315);
            this.retailPriceLabel.Name = "retailPriceLabel";
            this.retailPriceLabel.Size = new System.Drawing.Size(115, 25);
            this.retailPriceLabel.TabIndex = 7;
            this.retailPriceLabel.Text = "Retail Price:";
            // 
            // priceNumLabel
            // 
            this.priceNumLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.priceNumLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceNumLabel.Location = new System.Drawing.Point(264, 315);
            this.priceNumLabel.Name = "priceNumLabel";
            this.priceNumLabel.Size = new System.Drawing.Size(172, 32);
            this.priceNumLabel.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 487);
            this.Controls.Add(this.priceNumLabel);
            this.Controls.Add(this.retailPriceLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.markupText);
            this.Controls.Add(this.wholesaleText);
            this.Controls.Add(this.markupLabel);
            this.Controls.Add(this.wholesaleLabel);
            this.Controls.Add(this.formLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label formLabel;
        private System.Windows.Forms.Label wholesaleLabel;
        private System.Windows.Forms.Label markupLabel;
        private System.Windows.Forms.TextBox wholesaleText;
        private System.Windows.Forms.TextBox markupText;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label retailPriceLabel;
        private System.Windows.Forms.Label priceNumLabel;
    }
}

