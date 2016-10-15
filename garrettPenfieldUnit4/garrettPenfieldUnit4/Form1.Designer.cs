namespace garrettPenfieldUnit4
{
    partial class timeCalculator
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.secondsInput = new System.Windows.Forms.TextBox();
            this.inputSecondsLabel = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.daysLabel = new System.Windows.Forms.Label();
            this.secondsResult = new System.Windows.Forms.Label();
            this.minutesResult = new System.Windows.Forms.Label();
            this.hoursResult = new System.Windows.Forms.Label();
            this.daysResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(49, 233);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(80, 23);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(171, 233);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "&Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(293, 233);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // secondsInput
            // 
            this.secondsInput.Location = new System.Drawing.Point(268, 45);
            this.secondsInput.Name = "secondsInput";
            this.secondsInput.Size = new System.Drawing.Size(100, 22);
            this.secondsInput.TabIndex = 1;
            // 
            // inputSecondsLabel
            // 
            this.inputSecondsLabel.AutoSize = true;
            this.inputSecondsLabel.Location = new System.Drawing.Point(46, 48);
            this.inputSecondsLabel.Name = "inputSecondsLabel";
            this.inputSecondsLabel.Size = new System.Drawing.Size(168, 17);
            this.inputSecondsLabel.TabIndex = 0;
            this.inputSecondsLabel.Text = "Input Number of Seconds";
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Location = new System.Drawing.Point(46, 79);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(63, 17);
            this.secondsLabel.TabIndex = 0;
            this.secondsLabel.Text = "Seconds";
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Location = new System.Drawing.Point(46, 110);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(57, 17);
            this.minutesLabel.TabIndex = 0;
            this.minutesLabel.Text = "Minutes";
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(46, 141);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(46, 17);
            this.hoursLabel.TabIndex = 0;
            this.hoursLabel.Text = "Hours";
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Location = new System.Drawing.Point(46, 172);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(40, 17);
            this.daysLabel.TabIndex = 0;
            this.daysLabel.Text = "Days";
            // 
            // secondsResult
            // 
            this.secondsResult.AutoSize = true;
            this.secondsResult.Location = new System.Drawing.Point(265, 79);
            this.secondsResult.Name = "secondsResult";
            this.secondsResult.Size = new System.Drawing.Size(16, 17);
            this.secondsResult.TabIndex = 0;
            this.secondsResult.Text = "0";
            // 
            // minutesResult
            // 
            this.minutesResult.AutoSize = true;
            this.minutesResult.Location = new System.Drawing.Point(265, 110);
            this.minutesResult.Name = "minutesResult";
            this.minutesResult.Size = new System.Drawing.Size(16, 17);
            this.minutesResult.TabIndex = 0;
            this.minutesResult.Text = "0";
            // 
            // hoursResult
            // 
            this.hoursResult.AutoSize = true;
            this.hoursResult.Location = new System.Drawing.Point(265, 141);
            this.hoursResult.Name = "hoursResult";
            this.hoursResult.Size = new System.Drawing.Size(16, 17);
            this.hoursResult.TabIndex = 0;
            this.hoursResult.Text = "0";
            // 
            // daysResult
            // 
            this.daysResult.AutoSize = true;
            this.daysResult.Location = new System.Drawing.Point(265, 172);
            this.daysResult.Name = "daysResult";
            this.daysResult.Size = new System.Drawing.Size(16, 17);
            this.daysResult.TabIndex = 0;
            this.daysResult.Text = "0";
            // 
            // timeCalculator
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(415, 291);
            this.Controls.Add(this.daysResult);
            this.Controls.Add(this.hoursResult);
            this.Controls.Add(this.minutesResult);
            this.Controls.Add(this.secondsResult);
            this.Controls.Add(this.daysLabel);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.minutesLabel);
            this.Controls.Add(this.secondsLabel);
            this.Controls.Add(this.inputSecondsLabel);
            this.Controls.Add(this.secondsInput);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.calculateButton);
            this.Name = "timeCalculator";
            this.Text = "Time Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox secondsInput;
        private System.Windows.Forms.Label inputSecondsLabel;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.Label secondsResult;
        private System.Windows.Forms.Label minutesResult;
        private System.Windows.Forms.Label hoursResult;
        private System.Windows.Forms.Label daysResult;
    }
}

