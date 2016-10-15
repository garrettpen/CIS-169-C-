namespace garrettPenfieldUnit3
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
            this.foodChargeInput = new System.Windows.Forms.TextBox();
            this.foodChargeLabel = new System.Windows.Forms.Label();
            this.tipDisplay = new System.Windows.Forms.Label();
            this.salesTaxDisplay = new System.Windows.Forms.Label();
            this.tipLabel = new System.Windows.Forms.Label();
            this.salesTaxLabel = new System.Windows.Forms.Label();
            this.totalDisplay = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // foodChargeInput
            // 
            this.foodChargeInput.Location = new System.Drawing.Point(179, 35);
            this.foodChargeInput.Name = "foodChargeInput";
            this.foodChargeInput.Size = new System.Drawing.Size(60, 22);
            this.foodChargeInput.TabIndex = 1;
            // 
            // foodChargeLabel
            // 
            this.foodChargeLabel.AutoSize = true;
            this.foodChargeLabel.Location = new System.Drawing.Point(36, 38);
            this.foodChargeLabel.Name = "foodChargeLabel";
            this.foodChargeLabel.Size = new System.Drawing.Size(128, 17);
            this.foodChargeLabel.TabIndex = 0;
            this.foodChargeLabel.Text = "Enter Food Charge";
            // 
            // tipDisplay
            // 
            this.tipDisplay.AutoSize = true;
            this.tipDisplay.Location = new System.Drawing.Point(176, 74);
            this.tipDisplay.Name = "tipDisplay";
            this.tipDisplay.Size = new System.Drawing.Size(52, 17);
            this.tipDisplay.TabIndex = 0;
            this.tipDisplay.Text = "$00.00";
            // 
            // salesTaxDisplay
            // 
            this.salesTaxDisplay.AutoSize = true;
            this.salesTaxDisplay.Location = new System.Drawing.Point(176, 108);
            this.salesTaxDisplay.Name = "salesTaxDisplay";
            this.salesTaxDisplay.Size = new System.Drawing.Size(52, 17);
            this.salesTaxDisplay.TabIndex = 0;
            this.salesTaxDisplay.Text = "$00.00";
            // 
            // tipLabel
            // 
            this.tipLabel.AutoSize = true;
            this.tipLabel.Location = new System.Drawing.Point(52, 72);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.Size = new System.Drawing.Size(112, 17);
            this.tipLabel.TabIndex = 0;
            this.tipLabel.Text = "Tip Amount 15%";
            // 
            // salesTaxLabel
            // 
            this.salesTaxLabel.AutoSize = true;
            this.salesTaxLabel.Location = new System.Drawing.Point(70, 109);
            this.salesTaxLabel.Name = "salesTaxLabel";
            this.salesTaxLabel.Size = new System.Drawing.Size(94, 17);
            this.salesTaxLabel.TabIndex = 0;
            this.salesTaxLabel.Text = "Sales Tax 7%";
            // 
            // totalDisplay
            // 
            this.totalDisplay.AutoSize = true;
            this.totalDisplay.Location = new System.Drawing.Point(176, 142);
            this.totalDisplay.Name = "totalDisplay";
            this.totalDisplay.Size = new System.Drawing.Size(52, 17);
            this.totalDisplay.TabIndex = 0;
            this.totalDisplay.Text = "$00.00";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(124, 142);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(40, 17);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.Text = "Total";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(39, 176);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(87, 23);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(164, 176);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(325, 235);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.totalDisplay);
            this.Controls.Add(this.salesTaxLabel);
            this.Controls.Add(this.tipLabel);
            this.Controls.Add(this.salesTaxDisplay);
            this.Controls.Add(this.tipDisplay);
            this.Controls.Add(this.foodChargeLabel);
            this.Controls.Add(this.foodChargeInput);
            this.Name = "Form1";
            this.Text = "Meal Price Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox foodChargeInput;
        private System.Windows.Forms.Label foodChargeLabel;
        private System.Windows.Forms.Label tipDisplay;
        private System.Windows.Forms.Label salesTaxDisplay;
        private System.Windows.Forms.Label tipLabel;
        private System.Windows.Forms.Label salesTaxLabel;
        private System.Windows.Forms.Label totalDisplay;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
    }
}

