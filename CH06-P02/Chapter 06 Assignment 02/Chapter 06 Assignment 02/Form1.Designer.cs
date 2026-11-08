namespace Chapter_06_Assignment_02
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
            this.oilLubeBox = new System.Windows.Forms.GroupBox();
            this.flushesBox = new System.Windows.Forms.GroupBox();
            this.miscBox = new System.Windows.Forms.GroupBox();
            this.partsLaborBox = new System.Windows.Forms.GroupBox();
            this.summaryBox = new System.Windows.Forms.GroupBox();
            this.oilChangeCheck = new System.Windows.Forms.CheckBox();
            this.lubeJobCheck = new System.Windows.Forms.CheckBox();
            this.radiatorFlushBox = new System.Windows.Forms.CheckBox();
            this.transmissionFlushCheck = new System.Windows.Forms.CheckBox();
            this.inspectionCheck = new System.Windows.Forms.CheckBox();
            this.replaceMufflerCheck = new System.Windows.Forms.CheckBox();
            this.tireRotationCheck = new System.Windows.Forms.CheckBox();
            this.partsLabel = new System.Windows.Forms.Label();
            this.laborLabel = new System.Windows.Forms.Label();
            this.partsText = new System.Windows.Forms.TextBox();
            this.laborText = new System.Windows.Forms.TextBox();
            this.serviceLaborBox = new System.Windows.Forms.Label();
            this.partsBox = new System.Windows.Forms.Label();
            this.taxBox = new System.Windows.Forms.Label();
            this.totalBox = new System.Windows.Forms.Label();
            this.serviceLaborLabelBox = new System.Windows.Forms.Label();
            this.partsLabelBox = new System.Windows.Forms.Label();
            this.taxLabelBox = new System.Windows.Forms.Label();
            this.totalFeesLabelBox = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.oilLubeBox.SuspendLayout();
            this.flushesBox.SuspendLayout();
            this.miscBox.SuspendLayout();
            this.partsLaborBox.SuspendLayout();
            this.summaryBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // oilLubeBox
            // 
            this.oilLubeBox.Controls.Add(this.lubeJobCheck);
            this.oilLubeBox.Controls.Add(this.oilChangeCheck);
            this.oilLubeBox.Location = new System.Drawing.Point(17, 12);
            this.oilLubeBox.Name = "oilLubeBox";
            this.oilLubeBox.Size = new System.Drawing.Size(247, 145);
            this.oilLubeBox.TabIndex = 0;
            this.oilLubeBox.TabStop = false;
            this.oilLubeBox.Text = "Oil and Lube";
            // 
            // flushesBox
            // 
            this.flushesBox.Controls.Add(this.transmissionFlushCheck);
            this.flushesBox.Controls.Add(this.radiatorFlushBox);
            this.flushesBox.Location = new System.Drawing.Point(270, 12);
            this.flushesBox.Name = "flushesBox";
            this.flushesBox.Size = new System.Drawing.Size(247, 145);
            this.flushesBox.TabIndex = 0;
            this.flushesBox.TabStop = false;
            this.flushesBox.Text = "Flushes";
            // 
            // miscBox
            // 
            this.miscBox.Controls.Add(this.tireRotationCheck);
            this.miscBox.Controls.Add(this.replaceMufflerCheck);
            this.miscBox.Controls.Add(this.inspectionCheck);
            this.miscBox.Location = new System.Drawing.Point(17, 177);
            this.miscBox.Name = "miscBox";
            this.miscBox.Size = new System.Drawing.Size(247, 145);
            this.miscBox.TabIndex = 0;
            this.miscBox.TabStop = false;
            this.miscBox.Text = "Misc";
            this.miscBox.Enter += new System.EventHandler(this.miscBox_Enter);
            // 
            // partsLaborBox
            // 
            this.partsLaborBox.Controls.Add(this.laborText);
            this.partsLaborBox.Controls.Add(this.partsText);
            this.partsLaborBox.Controls.Add(this.laborLabel);
            this.partsLaborBox.Controls.Add(this.partsLabel);
            this.partsLaborBox.Location = new System.Drawing.Point(270, 177);
            this.partsLaborBox.Name = "partsLaborBox";
            this.partsLaborBox.Size = new System.Drawing.Size(247, 145);
            this.partsLaborBox.TabIndex = 0;
            this.partsLaborBox.TabStop = false;
            this.partsLaborBox.Text = "Parts and Labor";
            this.partsLaborBox.Enter += new System.EventHandler(this.partsLaborBox_Enter);
            // 
            // summaryBox
            // 
            this.summaryBox.Controls.Add(this.totalFeesLabelBox);
            this.summaryBox.Controls.Add(this.taxLabelBox);
            this.summaryBox.Controls.Add(this.partsLabelBox);
            this.summaryBox.Controls.Add(this.serviceLaborLabelBox);
            this.summaryBox.Controls.Add(this.totalBox);
            this.summaryBox.Controls.Add(this.taxBox);
            this.summaryBox.Controls.Add(this.partsBox);
            this.summaryBox.Controls.Add(this.serviceLaborBox);
            this.summaryBox.Location = new System.Drawing.Point(17, 340);
            this.summaryBox.Name = "summaryBox";
            this.summaryBox.Size = new System.Drawing.Size(500, 158);
            this.summaryBox.TabIndex = 0;
            this.summaryBox.TabStop = false;
            this.summaryBox.Text = "Summary";
            // 
            // oilChangeCheck
            // 
            this.oilChangeCheck.AutoSize = true;
            this.oilChangeCheck.Location = new System.Drawing.Point(22, 41);
            this.oilChangeCheck.Name = "oilChangeCheck";
            this.oilChangeCheck.Size = new System.Drawing.Size(127, 20);
            this.oilChangeCheck.TabIndex = 0;
            this.oilChangeCheck.Text = "Oil Change ($50)";
            this.oilChangeCheck.UseVisualStyleBackColor = true;
            // 
            // lubeJobCheck
            // 
            this.lubeJobCheck.AutoSize = true;
            this.lubeJobCheck.Location = new System.Drawing.Point(22, 78);
            this.lubeJobCheck.Name = "lubeJobCheck";
            this.lubeJobCheck.Size = new System.Drawing.Size(117, 20);
            this.lubeJobCheck.TabIndex = 1;
            this.lubeJobCheck.Text = "Lube Job ($40)";
            this.lubeJobCheck.UseVisualStyleBackColor = true;
            // 
            // radiatorFlushBox
            // 
            this.radiatorFlushBox.AutoSize = true;
            this.radiatorFlushBox.Location = new System.Drawing.Point(27, 41);
            this.radiatorFlushBox.Name = "radiatorFlushBox";
            this.radiatorFlushBox.Size = new System.Drawing.Size(155, 20);
            this.radiatorFlushBox.TabIndex = 0;
            this.radiatorFlushBox.Text = "Radiator Flush ($100)";
            this.radiatorFlushBox.UseVisualStyleBackColor = true;
            // 
            // transmissionFlushCheck
            // 
            this.transmissionFlushCheck.AutoSize = true;
            this.transmissionFlushCheck.Location = new System.Drawing.Point(27, 78);
            this.transmissionFlushCheck.Name = "transmissionFlushCheck";
            this.transmissionFlushCheck.Size = new System.Drawing.Size(184, 20);
            this.transmissionFlushCheck.TabIndex = 1;
            this.transmissionFlushCheck.Text = "Transmission Flush ($120)";
            this.transmissionFlushCheck.UseVisualStyleBackColor = true;
            // 
            // inspectionCheck
            // 
            this.inspectionCheck.AutoSize = true;
            this.inspectionCheck.Location = new System.Drawing.Point(22, 21);
            this.inspectionCheck.Name = "inspectionCheck";
            this.inspectionCheck.Size = new System.Drawing.Size(122, 20);
            this.inspectionCheck.TabIndex = 0;
            this.inspectionCheck.Text = "Inspection ($35)";
            this.inspectionCheck.UseVisualStyleBackColor = true;
            // 
            // replaceMufflerCheck
            // 
            this.replaceMufflerCheck.AutoSize = true;
            this.replaceMufflerCheck.Location = new System.Drawing.Point(22, 62);
            this.replaceMufflerCheck.Name = "replaceMufflerCheck";
            this.replaceMufflerCheck.Size = new System.Drawing.Size(162, 20);
            this.replaceMufflerCheck.TabIndex = 1;
            this.replaceMufflerCheck.Text = "Replace Muffler ($150)";
            this.replaceMufflerCheck.UseVisualStyleBackColor = true;
            // 
            // tireRotationCheck
            // 
            this.tireRotationCheck.AutoSize = true;
            this.tireRotationCheck.Location = new System.Drawing.Point(22, 105);
            this.tireRotationCheck.Name = "tireRotationCheck";
            this.tireRotationCheck.Size = new System.Drawing.Size(138, 20);
            this.tireRotationCheck.TabIndex = 2;
            this.tireRotationCheck.Text = "Tire Rotation ($25)";
            this.tireRotationCheck.UseVisualStyleBackColor = true;
            this.tireRotationCheck.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Location = new System.Drawing.Point(80, 44);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(41, 16);
            this.partsLabel.TabIndex = 0;
            this.partsLabel.Text = "Parts:";
            // 
            // laborLabel
            // 
            this.laborLabel.AutoSize = true;
            this.laborLabel.Location = new System.Drawing.Point(29, 84);
            this.laborLabel.Name = "laborLabel";
            this.laborLabel.Size = new System.Drawing.Size(92, 16);
            this.laborLabel.TabIndex = 1;
            this.laborLabel.Text = "Labor (Hours):";
            // 
            // partsText
            // 
            this.partsText.Location = new System.Drawing.Point(127, 41);
            this.partsText.Name = "partsText";
            this.partsText.Size = new System.Drawing.Size(100, 22);
            this.partsText.TabIndex = 2;
            // 
            // laborText
            // 
            this.laborText.Location = new System.Drawing.Point(127, 78);
            this.laborText.Name = "laborText";
            this.laborText.Size = new System.Drawing.Size(100, 22);
            this.laborText.TabIndex = 3;
            this.laborText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // serviceLaborBox
            // 
            this.serviceLaborBox.AutoSize = true;
            this.serviceLaborBox.Location = new System.Drawing.Point(124, 26);
            this.serviceLaborBox.Name = "serviceLaborBox";
            this.serviceLaborBox.Size = new System.Drawing.Size(123, 16);
            this.serviceLaborBox.TabIndex = 0;
            this.serviceLaborBox.Text = "Service and Labor: ";
            // 
            // partsBox
            // 
            this.partsBox.AutoSize = true;
            this.partsBox.Location = new System.Drawing.Point(203, 54);
            this.partsBox.Name = "partsBox";
            this.partsBox.Size = new System.Drawing.Size(44, 16);
            this.partsBox.TabIndex = 1;
            this.partsBox.Text = "Parts: ";
            // 
            // taxBox
            // 
            this.taxBox.AutoSize = true;
            this.taxBox.Location = new System.Drawing.Point(152, 82);
            this.taxBox.Name = "taxBox";
            this.taxBox.Size = new System.Drawing.Size(95, 16);
            this.taxBox.TabIndex = 2;
            this.taxBox.Text = "Tax (on parts): ";
            // 
            // totalBox
            // 
            this.totalBox.AutoSize = true;
            this.totalBox.Location = new System.Drawing.Point(169, 110);
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(78, 16);
            this.totalBox.TabIndex = 3;
            this.totalBox.Text = "Total Fees: ";
            // 
            // serviceLaborLabelBox
            // 
            this.serviceLaborLabelBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serviceLaborLabelBox.Location = new System.Drawing.Point(253, 25);
            this.serviceLaborLabelBox.Name = "serviceLaborLabelBox";
            this.serviceLaborLabelBox.Size = new System.Drawing.Size(100, 23);
            this.serviceLaborLabelBox.TabIndex = 4;
            // 
            // partsLabelBox
            // 
            this.partsLabelBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.partsLabelBox.Location = new System.Drawing.Point(253, 53);
            this.partsLabelBox.Name = "partsLabelBox";
            this.partsLabelBox.Size = new System.Drawing.Size(100, 23);
            this.partsLabelBox.TabIndex = 5;
            // 
            // taxLabelBox
            // 
            this.taxLabelBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxLabelBox.Location = new System.Drawing.Point(253, 81);
            this.taxLabelBox.Name = "taxLabelBox";
            this.taxLabelBox.Size = new System.Drawing.Size(100, 23);
            this.taxLabelBox.TabIndex = 6;
            // 
            // totalFeesLabelBox
            // 
            this.totalFeesLabelBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalFeesLabelBox.Location = new System.Drawing.Point(253, 109);
            this.totalFeesLabelBox.Name = "totalFeesLabelBox";
            this.totalFeesLabelBox.Size = new System.Drawing.Size(100, 23);
            this.totalFeesLabelBox.TabIndex = 7;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(102, 523);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(82, 23);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(220, 523);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(338, 523);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 573);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.flushesBox);
            this.Controls.Add(this.miscBox);
            this.Controls.Add(this.partsLaborBox);
            this.Controls.Add(this.summaryBox);
            this.Controls.Add(this.oilLubeBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.oilLubeBox.ResumeLayout(false);
            this.oilLubeBox.PerformLayout();
            this.flushesBox.ResumeLayout(false);
            this.flushesBox.PerformLayout();
            this.miscBox.ResumeLayout(false);
            this.miscBox.PerformLayout();
            this.partsLaborBox.ResumeLayout(false);
            this.partsLaborBox.PerformLayout();
            this.summaryBox.ResumeLayout(false);
            this.summaryBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox oilLubeBox;
        private System.Windows.Forms.CheckBox lubeJobCheck;
        private System.Windows.Forms.CheckBox oilChangeCheck;
        private System.Windows.Forms.GroupBox flushesBox;
        private System.Windows.Forms.GroupBox miscBox;
        private System.Windows.Forms.GroupBox partsLaborBox;
        private System.Windows.Forms.GroupBox summaryBox;
        private System.Windows.Forms.CheckBox transmissionFlushCheck;
        private System.Windows.Forms.CheckBox radiatorFlushBox;
        private System.Windows.Forms.CheckBox tireRotationCheck;
        private System.Windows.Forms.CheckBox replaceMufflerCheck;
        private System.Windows.Forms.CheckBox inspectionCheck;
        private System.Windows.Forms.Label laborLabel;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.TextBox laborText;
        private System.Windows.Forms.TextBox partsText;
        private System.Windows.Forms.Label totalFeesLabelBox;
        private System.Windows.Forms.Label taxLabelBox;
        private System.Windows.Forms.Label partsLabelBox;
        private System.Windows.Forms.Label serviceLaborLabelBox;
        private System.Windows.Forms.Label totalBox;
        private System.Windows.Forms.Label taxBox;
        private System.Windows.Forms.Label partsBox;
        private System.Windows.Forms.Label serviceLaborBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

