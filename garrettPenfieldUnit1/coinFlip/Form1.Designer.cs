namespace coinFlip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.showHeadsButton = new System.Windows.Forms.Button();
            this.showTailsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.headsPicture = new System.Windows.Forms.PictureBox();
            this.tailsPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.headsPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailsPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // showHeadsButton
            // 
            this.showHeadsButton.Location = new System.Drawing.Point(24, 348);
            this.showHeadsButton.Name = "showHeadsButton";
            this.showHeadsButton.Size = new System.Drawing.Size(121, 54);
            this.showHeadsButton.TabIndex = 0;
            this.showHeadsButton.Text = "Show Heads";
            this.showHeadsButton.UseVisualStyleBackColor = true;
            this.showHeadsButton.Click += new System.EventHandler(this.showHeadsButton_Click);
            // 
            // showTailsButton
            // 
            this.showTailsButton.Location = new System.Drawing.Point(187, 348);
            this.showTailsButton.Name = "showTailsButton";
            this.showTailsButton.Size = new System.Drawing.Size(121, 54);
            this.showTailsButton.TabIndex = 3;
            this.showTailsButton.Text = "Show Tails";
            this.showTailsButton.UseVisualStyleBackColor = true;
            this.showTailsButton.Click += new System.EventHandler(this.showTailsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(348, 348);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(121, 54);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click_1);
            // 
            // headsPicture
            // 
            this.headsPicture.Image = ((System.Drawing.Image)(resources.GetObject("headsPicture.Image")));
            this.headsPicture.Location = new System.Drawing.Point(0, 0);
            this.headsPicture.Name = "headsPicture";
            this.headsPicture.Size = new System.Drawing.Size(200, 200);
            this.headsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.headsPicture.TabIndex = 5;
            this.headsPicture.TabStop = false;
            this.headsPicture.Visible = false;
            // 
            // tailsPicture
            // 
            this.tailsPicture.Image = ((System.Drawing.Image)(resources.GetObject("tailsPicture.Image")));
            this.tailsPicture.Location = new System.Drawing.Point(290, 0);
            this.tailsPicture.Name = "tailsPicture";
            this.tailsPicture.Size = new System.Drawing.Size(200, 200);
            this.tailsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tailsPicture.TabIndex = 6;
            this.tailsPicture.TabStop = false;
            this.tailsPicture.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 417);
            this.Controls.Add(this.tailsPicture);
            this.Controls.Add(this.headsPicture);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.showTailsButton);
            this.Controls.Add(this.showHeadsButton);
            this.Name = "Form1";
            this.Text = "Coin Flipper";
            ((System.ComponentModel.ISupportInitialize)(this.headsPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailsPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showHeadsButton;
        private System.Windows.Forms.Button showTailsButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox headsPicture;
        private System.Windows.Forms.PictureBox tailsPicture;
    }
}

