namespace MiniProject
{
    partial class CheckIfSellerExists
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label SellerNameLabel;
        private System.Windows.Forms.TextBox SellerNameTextBox;
        private System.Windows.Forms.Button CheckButton;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckIfSellerExists));
            this.SellerNameLabel = new System.Windows.Forms.Label();
            this.SellerNameTextBox = new System.Windows.Forms.TextBox();
            this.CheckButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SellerNameLabel
            // 
            this.SellerNameLabel.AutoSize = true;
            this.SellerNameLabel.Location = new System.Drawing.Point(141, 9);
            this.SellerNameLabel.Name = "SellerNameLabel";
            this.SellerNameLabel.Size = new System.Drawing.Size(82, 16);
            this.SellerNameLabel.TabIndex = 0;
            this.SellerNameLabel.Text = "Seller Name";
            // 
            // SellerNameTextBox
            // 
            this.SellerNameTextBox.Location = new System.Drawing.Point(99, 30);
            this.SellerNameTextBox.Name = "SellerNameTextBox";
            this.SellerNameTextBox.Size = new System.Drawing.Size(165, 22);
            this.SellerNameTextBox.TabIndex = 1;
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(144, 56);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(75, 23);
            this.CheckButton.TabIndex = 2;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MiniProject.Properties.Resources._4f032aef_ac1e_428b_b0eb_9cc88d8e8079;
            this.pictureBox1.Location = new System.Drawing.Point(306, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // CheckIfSellerExists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 94);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.SellerNameTextBox);
            this.Controls.Add(this.SellerNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CheckIfSellerExists";
            this.Text = "Check If Seller Exists";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
    }
}