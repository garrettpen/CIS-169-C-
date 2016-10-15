namespace garrettPenfieldUnit6
{
    partial class hospitalChargesForm
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
            this.calculateTotal = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.daysInHospitalLabel = new System.Windows.Forms.Label();
            this.daysInHospitalInput = new System.Windows.Forms.TextBox();
            this.totalMedicationInput = new System.Windows.Forms.TextBox();
            this.totalSurgicalChargesInput = new System.Windows.Forms.TextBox();
            this.totalLabFeesInput = new System.Windows.Forms.TextBox();
            this.totalMedicationLabel = new System.Windows.Forms.Label();
            this.totalSurgicalChargesLabel = new System.Windows.Forms.Label();
            this.totalLabFeesLabel = new System.Windows.Forms.Label();
            this.totalRehabFeesInput = new System.Windows.Forms.TextBox();
            this.totalRehabFeesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateTotal
            // 
            this.calculateTotal.Location = new System.Drawing.Point(280, 204);
            this.calculateTotal.Name = "calculateTotal";
            this.calculateTotal.Size = new System.Drawing.Size(86, 23);
            this.calculateTotal.TabIndex = 6;
            this.calculateTotal.Text = "&Calculate";
            this.calculateTotal.UseVisualStyleBackColor = true;
            this.calculateTotal.Click += new System.EventHandler(this.calculateTotal_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(280, 255);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(86, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // daysInHospitalLabel
            // 
            this.daysInHospitalLabel.AutoSize = true;
            this.daysInHospitalLabel.Location = new System.Drawing.Point(26, 51);
            this.daysInHospitalLabel.Name = "daysInHospitalLabel";
            this.daysInHospitalLabel.Size = new System.Drawing.Size(221, 17);
            this.daysInHospitalLabel.TabIndex = 2;
            this.daysInHospitalLabel.Text = "Number of Days Spent in Hospital";
            // 
            // daysInHospitalInput
            // 
            this.daysInHospitalInput.Location = new System.Drawing.Point(266, 48);
            this.daysInHospitalInput.Name = "daysInHospitalInput";
            this.daysInHospitalInput.Size = new System.Drawing.Size(100, 22);
            this.daysInHospitalInput.TabIndex = 1;
            // 
            // totalMedicationInput
            // 
            this.totalMedicationInput.Location = new System.Drawing.Point(266, 77);
            this.totalMedicationInput.Name = "totalMedicationInput";
            this.totalMedicationInput.Size = new System.Drawing.Size(100, 22);
            this.totalMedicationInput.TabIndex = 2;
            // 
            // totalSurgicalChargesInput
            // 
            this.totalSurgicalChargesInput.Location = new System.Drawing.Point(266, 106);
            this.totalSurgicalChargesInput.Name = "totalSurgicalChargesInput";
            this.totalSurgicalChargesInput.Size = new System.Drawing.Size(100, 22);
            this.totalSurgicalChargesInput.TabIndex = 3;
            // 
            // totalLabFeesInput
            // 
            this.totalLabFeesInput.Location = new System.Drawing.Point(266, 135);
            this.totalLabFeesInput.Name = "totalLabFeesInput";
            this.totalLabFeesInput.Size = new System.Drawing.Size(100, 22);
            this.totalLabFeesInput.TabIndex = 4;
            // 
            // totalMedicationLabel
            // 
            this.totalMedicationLabel.AutoSize = true;
            this.totalMedicationLabel.Location = new System.Drawing.Point(62, 80);
            this.totalMedicationLabel.Name = "totalMedicationLabel";
            this.totalMedicationLabel.Size = new System.Drawing.Size(185, 17);
            this.totalMedicationLabel.TabIndex = 7;
            this.totalMedicationLabel.Text = "Total of Medication Charges";
            // 
            // totalSurgicalChargesLabel
            // 
            this.totalSurgicalChargesLabel.AutoSize = true;
            this.totalSurgicalChargesLabel.Location = new System.Drawing.Point(79, 109);
            this.totalSurgicalChargesLabel.Name = "totalSurgicalChargesLabel";
            this.totalSurgicalChargesLabel.Size = new System.Drawing.Size(168, 17);
            this.totalSurgicalChargesLabel.TabIndex = 8;
            this.totalSurgicalChargesLabel.Text = "Total of Surgical Charges";
            // 
            // totalLabFeesLabel
            // 
            this.totalLabFeesLabel.AutoSize = true;
            this.totalLabFeesLabel.Location = new System.Drawing.Point(144, 138);
            this.totalLabFeesLabel.Name = "totalLabFeesLabel";
            this.totalLabFeesLabel.Size = new System.Drawing.Size(103, 17);
            this.totalLabFeesLabel.TabIndex = 9;
            this.totalLabFeesLabel.Text = "Total Lab Fees";
            this.totalLabFeesLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // totalRehabFeesInput
            // 
            this.totalRehabFeesInput.Location = new System.Drawing.Point(266, 164);
            this.totalRehabFeesInput.Name = "totalRehabFeesInput";
            this.totalRehabFeesInput.Size = new System.Drawing.Size(100, 22);
            this.totalRehabFeesInput.TabIndex = 5;
            // 
            // totalRehabFeesLabel
            // 
            this.totalRehabFeesLabel.AutoSize = true;
            this.totalRehabFeesLabel.Location = new System.Drawing.Point(70, 167);
            this.totalRehabFeesLabel.Name = "totalRehabFeesLabel";
            this.totalRehabFeesLabel.Size = new System.Drawing.Size(177, 17);
            this.totalRehabFeesLabel.TabIndex = 11;
            this.totalRehabFeesLabel.Text = "Total Physical Rehab Fees";
            // 
            // hospitalChargesForm
            // 
            this.AcceptButton = this.calculateTotal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(410, 290);
            this.Controls.Add(this.totalRehabFeesLabel);
            this.Controls.Add(this.totalRehabFeesInput);
            this.Controls.Add(this.totalLabFeesLabel);
            this.Controls.Add(this.totalSurgicalChargesLabel);
            this.Controls.Add(this.totalMedicationLabel);
            this.Controls.Add(this.totalLabFeesInput);
            this.Controls.Add(this.totalSurgicalChargesInput);
            this.Controls.Add(this.totalMedicationInput);
            this.Controls.Add(this.daysInHospitalInput);
            this.Controls.Add(this.daysInHospitalLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateTotal);
            this.Name = "hospitalChargesForm";
            this.Text = "Hospital Charges";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateTotal;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label daysInHospitalLabel;
        private System.Windows.Forms.TextBox daysInHospitalInput;
        private System.Windows.Forms.TextBox totalMedicationInput;
        private System.Windows.Forms.TextBox totalSurgicalChargesInput;
        private System.Windows.Forms.TextBox totalLabFeesInput;
        private System.Windows.Forms.Label totalMedicationLabel;
        private System.Windows.Forms.Label totalSurgicalChargesLabel;
        private System.Windows.Forms.Label totalLabFeesLabel;
        private System.Windows.Forms.TextBox totalRehabFeesInput;
        private System.Windows.Forms.Label totalRehabFeesLabel;
    }
}

