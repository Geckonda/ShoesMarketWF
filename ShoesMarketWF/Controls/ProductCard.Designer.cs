namespace ShoesMarketWF.Controls
{
    partial class ProductCard
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductCard));
            productImg = new PictureBox();
            productName = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            productDescription = new Label();
            productManufacturer = new Label();
            productPrice = new Label();
            productAmount = new Label();
            productDiscount = new Label();
            productSupplier = new Label();
            ((System.ComponentModel.ISupportInitialize)productImg).BeginInit();
            SuspendLayout();
            // 
            // productImg
            // 
            productImg.ErrorImage = (Image)resources.GetObject("productImg.ErrorImage");
            productImg.Location = new Point(3, 3);
            productImg.Name = "productImg";
            productImg.Size = new Size(150, 150);
            productImg.SizeMode = PictureBoxSizeMode.StretchImage;
            productImg.TabIndex = 0;
            productImg.TabStop = false;
            // 
            // productName
            // 
            productName.AutoSize = true;
            productName.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            productName.Location = new Point(159, 3);
            productName.Name = "productName";
            productName.Size = new Size(74, 17);
            productName.TabIndex = 1;
            productName.Text = "Название";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 19);
            label1.Name = "label1";
            label1.Size = new Size(89, 16);
            label1.TabIndex = 2;
            label1.Text = "Описание товара:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 35);
            label2.Name = "label2";
            label2.Size = new Size(83, 16);
            label2.TabIndex = 3;
            label2.Text = "Производитель:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(160, 51);
            label3.Name = "label3";
            label3.Size = new Size(62, 16);
            label3.TabIndex = 4;
            label3.Text = "Поставщик:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(160, 67);
            label4.Name = "label4";
            label4.Size = new Size(32, 16);
            label4.TabIndex = 5;
            label4.Text = "Цена:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(160, 99);
            label6.Name = "label6";
            label6.Size = new Size(111, 16);
            label6.TabIndex = 7;
            label6.Text = "Количество на складе:";
            // 
            // productDescription
            // 
            productDescription.AutoSize = true;
            productDescription.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productDescription.Location = new Point(255, 19);
            productDescription.Name = "productDescription";
            productDescription.Size = new Size(16, 17);
            productDescription.TabIndex = 8;
            productDescription.Text = "+";
            // 
            // productManufacturer
            // 
            productManufacturer.AutoSize = true;
            productManufacturer.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productManufacturer.Location = new Point(248, 36);
            productManufacturer.Name = "productManufacturer";
            productManufacturer.Size = new Size(16, 17);
            productManufacturer.TabIndex = 9;
            productManufacturer.Text = "+";
            // 
            // productPrice
            // 
            productPrice.AutoSize = true;
            productPrice.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productPrice.Location = new Point(198, 66);
            productPrice.Name = "productPrice";
            productPrice.Size = new Size(16, 17);
            productPrice.TabIndex = 10;
            productPrice.Text = "+";
            // 
            // productAmount
            // 
            productAmount.AutoSize = true;
            productAmount.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productAmount.Location = new Point(277, 98);
            productAmount.Name = "productAmount";
            productAmount.Size = new Size(16, 17);
            productAmount.TabIndex = 11;
            productAmount.Text = "+";
            // 
            // productDiscount
            // 
            productDiscount.BackColor = Color.Red;
            productDiscount.Dock = DockStyle.Right;
            productDiscount.Font = new Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            productDiscount.ForeColor = Color.White;
            productDiscount.Location = new Point(871, 0);
            productDiscount.Name = "productDiscount";
            productDiscount.Size = new Size(75, 156);
            productDiscount.TabIndex = 12;
            productDiscount.Text = "%";
            productDiscount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // productSupplier
            // 
            productSupplier.AutoSize = true;
            productSupplier.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productSupplier.Location = new Point(228, 51);
            productSupplier.Name = "productSupplier";
            productSupplier.Size = new Size(16, 17);
            productSupplier.TabIndex = 13;
            productSupplier.Text = "+";
            // 
            // ProductCard
            // 
            AutoScaleDimensions = new SizeF(6F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(productSupplier);
            Controls.Add(productDiscount);
            Controls.Add(productAmount);
            Controls.Add(productPrice);
            Controls.Add(productManufacturer);
            Controls.Add(productDescription);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(productName);
            Controls.Add(productImg);
            Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Name = "ProductCard";
            Size = new Size(946, 156);
            ((System.ComponentModel.ISupportInitialize)productImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox productImg;
        private Label productName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label productDescription;
        private Label productManufacturer;
        private Label productPrice;
        private Label productAmount;
        private Label productDiscount;
        private Label productSupplier;
    }
}
