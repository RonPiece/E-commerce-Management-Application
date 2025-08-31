namespace MiniProject
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AddSeller = new System.Windows.Forms.Button();
            this.AddBuyer = new System.Windows.Forms.Button();
            this.AddProdouctToSeller = new System.Windows.Forms.Button();
            this.AddProductToBuyer = new System.Windows.Forms.Button();
            this.ShowAllData = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddSeller
            // 
            this.AddSeller.Location = new System.Drawing.Point(271, 42);
            this.AddSeller.Name = "AddSeller";
            this.AddSeller.Size = new System.Drawing.Size(246, 83);
            this.AddSeller.TabIndex = 0;
            this.AddSeller.Text = "Add Seller";
            this.AddSeller.UseVisualStyleBackColor = true;
            this.AddSeller.Click += new System.EventHandler(this.AddSeller_Click);
            // 
            // AddBuyer
            // 
            this.AddBuyer.Location = new System.Drawing.Point(271, 131);
            this.AddBuyer.Name = "AddBuyer";
            this.AddBuyer.Size = new System.Drawing.Size(246, 74);
            this.AddBuyer.TabIndex = 1;
            this.AddBuyer.Text = "Add buyer";
            this.AddBuyer.UseVisualStyleBackColor = true;
            this.AddBuyer.Click += new System.EventHandler(this.AddBuyer_Click);
            // 
            // AddProdouctToSeller
            // 
            this.AddProdouctToSeller.Location = new System.Drawing.Point(271, 211);
            this.AddProdouctToSeller.Name = "AddProdouctToSeller";
            this.AddProdouctToSeller.Size = new System.Drawing.Size(246, 77);
            this.AddProdouctToSeller.TabIndex = 2;
            this.AddProdouctToSeller.Text = "Add Product to Seller";
            this.AddProdouctToSeller.UseVisualStyleBackColor = true;
            this.AddProdouctToSeller.Click += new System.EventHandler(this.AddProdouctToSeller_Click);
            // 
            // AddProductToBuyer
            // 
            this.AddProductToBuyer.Location = new System.Drawing.Point(271, 294);
            this.AddProductToBuyer.Name = "AddProductToBuyer";
            this.AddProductToBuyer.Size = new System.Drawing.Size(246, 60);
            this.AddProductToBuyer.TabIndex = 3;
            this.AddProductToBuyer.Text = "Add Product to buyer";
            this.AddProductToBuyer.UseVisualStyleBackColor = true;
            this.AddProductToBuyer.Click += new System.EventHandler(this.AddProductToBuyer_Click);
            // 
            // ShowAllData
            // 
            this.ShowAllData.Location = new System.Drawing.Point(271, 360);
            this.ShowAllData.Name = "ShowAllData";
            this.ShowAllData.Size = new System.Drawing.Size(246, 67);
            this.ShowAllData.TabIndex = 4;
            this.ShowAllData.Text = "Show All Data";
            this.ShowAllData.UseVisualStyleBackColor = true;
            this.ShowAllData.Click += new System.EventHandler(this.ShowAllData_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MiniProject.Properties.Resources._b1f40212_c047_4261_ad98_167c9d66dcf1;
            this.pictureBox2.Location = new System.Drawing.Point(534, 169);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(265, 258);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MiniProject.Properties.Resources._8be4edea_a3d4_4d20_8719_1cca23267bc3;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 258);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ShowAllData);
            this.Controls.Add(this.AddProductToBuyer);
            this.Controls.Add(this.AddProdouctToSeller);
            this.Controls.Add(this.AddBuyer);
            this.Controls.Add(this.AddSeller);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Main menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddSeller;
        private System.Windows.Forms.Button AddBuyer;
        private System.Windows.Forms.Button AddProdouctToSeller;
        private System.Windows.Forms.Button AddProductToBuyer;
        private System.Windows.Forms.Button ShowAllData;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

