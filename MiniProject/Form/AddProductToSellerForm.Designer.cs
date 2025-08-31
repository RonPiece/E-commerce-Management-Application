using System;
using System.Linq;
using System.Windows.Forms;

namespace MiniProject
{
    public partial class AddProductToSellerForm : Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductToSellerForm));
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ProductPriceLabel = new System.Windows.Forms.Label();
            this.ProductCategoryLabel = new System.Windows.Forms.Label();
            this.SpecialPackageLabel = new System.Windows.Forms.Label();
            this.ExtraPriceLabel = new System.Windows.Forms.Label();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.ProductPriceTextBox = new System.Windows.Forms.TextBox();
            this.ExtraPriceTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CategoryRadioButton1 = new System.Windows.Forms.RadioButton();
            this.CategoryRadioButton2 = new System.Windows.Forms.RadioButton();
            this.CategoryRadioButton3 = new System.Windows.Forms.RadioButton();
            this.CategoryRadioButton4 = new System.Windows.Forms.RadioButton();
            this.ExtraPriceSpecialPackageLabel = new System.Windows.Forms.Label();
            this.SpecialPackageCheckBox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(14, 204);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(93, 16);
            this.ProductNameLabel.TabIndex = 1;
            this.ProductNameLabel.Text = "Product Name";
            // 
            // ProductPriceLabel
            // 
            this.ProductPriceLabel.AutoSize = true;
            this.ProductPriceLabel.Location = new System.Drawing.Point(14, 257);
            this.ProductPriceLabel.Name = "ProductPriceLabel";
            this.ProductPriceLabel.Size = new System.Drawing.Size(87, 16);
            this.ProductPriceLabel.TabIndex = 2;
            this.ProductPriceLabel.Text = "Product Price";
            // 
            // ProductCategoryLabel
            // 
            this.ProductCategoryLabel.AutoSize = true;
            this.ProductCategoryLabel.Location = new System.Drawing.Point(255, 204);
            this.ProductCategoryLabel.Name = "ProductCategoryLabel";
            this.ProductCategoryLabel.Size = new System.Drawing.Size(111, 16);
            this.ProductCategoryLabel.TabIndex = 3;
            this.ProductCategoryLabel.Text = "Product Category";
            // 
            // SpecialPackageLabel
            // 
            this.SpecialPackageLabel.AutoSize = true;
            this.SpecialPackageLabel.Location = new System.Drawing.Point(434, 204);
            this.SpecialPackageLabel.Name = "SpecialPackageLabel";
            this.SpecialPackageLabel.Size = new System.Drawing.Size(111, 16);
            this.SpecialPackageLabel.TabIndex = 4;
            this.SpecialPackageLabel.Text = "Special Package";
            // 
            // ExtraPriceLabel
            // 
            this.ExtraPriceLabel.AutoSize = true;
            this.ExtraPriceLabel.Location = new System.Drawing.Point(26, 320);
            this.ExtraPriceLabel.Name = "ExtraPriceLabel";
            this.ExtraPriceLabel.Size = new System.Drawing.Size(73, 16);
            this.ExtraPriceLabel.TabIndex = 11;
            this.ExtraPriceLabel.Text = "Extra Price";
            this.ExtraPriceLabel.Visible = false;
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Location = new System.Drawing.Point(17, 224);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(165, 22);
            this.ProductNameTextBox.TabIndex = 6;
            // 
            // ProductPriceTextBox
            // 
            this.ProductPriceTextBox.Location = new System.Drawing.Point(17, 276);
            this.ProductPriceTextBox.Name = "ProductPriceTextBox";
            this.ProductPriceTextBox.Size = new System.Drawing.Size(165, 22);
            this.ProductPriceTextBox.TabIndex = 7;
            // 
            // ExtraPriceTextBox
            // 
            this.ExtraPriceTextBox.Location = new System.Drawing.Point(437, 276);
            this.ExtraPriceTextBox.Name = "ExtraPriceTextBox";
            this.ExtraPriceTextBox.Size = new System.Drawing.Size(165, 22);
            this.ExtraPriceTextBox.TabIndex = 14;
            this.ExtraPriceTextBox.Visible = false;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(212, 359);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(182, 79);
            this.SubmitButton.TabIndex = 15;
            this.SubmitButton.Text = "Submit Product Information";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CategoryRadioButton1
            // 
            this.CategoryRadioButton1.AutoSize = true;
            this.CategoryRadioButton1.Location = new System.Drawing.Point(258, 223);
            this.CategoryRadioButton1.Name = "CategoryRadioButton1";
            this.CategoryRadioButton1.Size = new System.Drawing.Size(54, 20);
            this.CategoryRadioButton1.TabIndex = 8;
            this.CategoryRadioButton1.TabStop = true;
            this.CategoryRadioButton1.Text = "Kids";
            this.CategoryRadioButton1.UseVisualStyleBackColor = true;
            // 
            // CategoryRadioButton2
            // 
            this.CategoryRadioButton2.AutoSize = true;
            this.CategoryRadioButton2.Location = new System.Drawing.Point(258, 249);
            this.CategoryRadioButton2.Name = "CategoryRadioButton2";
            this.CategoryRadioButton2.Size = new System.Drawing.Size(94, 20);
            this.CategoryRadioButton2.TabIndex = 9;
            this.CategoryRadioButton2.TabStop = true;
            this.CategoryRadioButton2.Text = "Electronics";
            this.CategoryRadioButton2.UseVisualStyleBackColor = true;
            // 
            // CategoryRadioButton3
            // 
            this.CategoryRadioButton3.AutoSize = true;
            this.CategoryRadioButton3.Location = new System.Drawing.Point(258, 275);
            this.CategoryRadioButton3.Name = "CategoryRadioButton3";
            this.CategoryRadioButton3.Size = new System.Drawing.Size(62, 20);
            this.CategoryRadioButton3.TabIndex = 10;
            this.CategoryRadioButton3.TabStop = true;
            this.CategoryRadioButton3.Text = "Office";
            this.CategoryRadioButton3.UseVisualStyleBackColor = true;
            // 
            // CategoryRadioButton4
            // 
            this.CategoryRadioButton4.AutoSize = true;
            this.CategoryRadioButton4.Location = new System.Drawing.Point(258, 301);
            this.CategoryRadioButton4.Name = "CategoryRadioButton4";
            this.CategoryRadioButton4.Size = new System.Drawing.Size(76, 20);
            this.CategoryRadioButton4.TabIndex = 11;
            this.CategoryRadioButton4.TabStop = true;
            this.CategoryRadioButton4.Text = "Clothing";
            this.CategoryRadioButton4.UseVisualStyleBackColor = true;
            // 
            // ExtraPriceSpecialPackageLabel
            // 
            this.ExtraPriceSpecialPackageLabel.AutoSize = true;
            this.ExtraPriceSpecialPackageLabel.Location = new System.Drawing.Point(434, 257);
            this.ExtraPriceSpecialPackageLabel.Name = "ExtraPriceSpecialPackageLabel";
            this.ExtraPriceSpecialPackageLabel.Size = new System.Drawing.Size(196, 16);
            this.ExtraPriceSpecialPackageLabel.TabIndex = 13;
            this.ExtraPriceSpecialPackageLabel.Text = "Extra Price for Special Package";
            this.ExtraPriceSpecialPackageLabel.Visible = false;
            // 
            // SpecialPackageCheckBox
            // 
            this.SpecialPackageCheckBox.AutoSize = true;
            this.SpecialPackageCheckBox.Location = new System.Drawing.Point(437, 224);
            this.SpecialPackageCheckBox.Name = "SpecialPackageCheckBox";
            this.SpecialPackageCheckBox.Size = new System.Drawing.Size(85, 20);
            this.SpecialPackageCheckBox.TabIndex = 16;
            this.SpecialPackageCheckBox.Text = "Required";
            this.SpecialPackageCheckBox.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MiniProject.Properties.Resources._4f032aef_ac1e_428b_b0eb_9cc88d8e8079;
            this.pictureBox1.Location = new System.Drawing.Point(212, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // AddProductToSellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SpecialPackageCheckBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.ExtraPriceTextBox);
            this.Controls.Add(this.ExtraPriceSpecialPackageLabel);
            this.Controls.Add(this.CategoryRadioButton4);
            this.Controls.Add(this.CategoryRadioButton3);
            this.Controls.Add(this.CategoryRadioButton2);
            this.Controls.Add(this.CategoryRadioButton1);
            this.Controls.Add(this.ProductPriceTextBox);
            this.Controls.Add(this.ProductNameTextBox);
            this.Controls.Add(this.SpecialPackageLabel);
            this.Controls.Add(this.ProductCategoryLabel);
            this.Controls.Add(this.ProductPriceLabel);
            this.Controls.Add(this.ProductNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProductToSellerForm";
            this.Text = "Add Product To Seller";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.Label ProductPriceLabel;
        private System.Windows.Forms.Label ProductCategoryLabel;
        private System.Windows.Forms.Label SpecialPackageLabel;
        private System.Windows.Forms.Label ExtraPriceLabel;
        private System.Windows.Forms.TextBox ProductNameTextBox;
        private System.Windows.Forms.TextBox ProductPriceTextBox;
        private System.Windows.Forms.RadioButton CategoryRadioButton1;
        private System.Windows.Forms.RadioButton CategoryRadioButton2;
        private System.Windows.Forms.RadioButton CategoryRadioButton3;
        private System.Windows.Forms.RadioButton CategoryRadioButton4;
        private System.Windows.Forms.Label ExtraPriceSpecialPackageLabel;
        private System.Windows.Forms.TextBox ExtraPriceTextBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.CheckBox SpecialPackageCheckBox;
        private PictureBox pictureBox1;
    }
}