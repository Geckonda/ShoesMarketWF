using ShoesMarketWF.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesMarketWF.Controls
{
    public partial class ProductCard : UserControl
    {

        private Action<int> DeleteProduct;

        private int _productId;
        public ProductCard(ProductEntity entity, Action<int> deleteProduct)
        {
            InitializeComponent();
            InitCard(entity);
            DeleteProduct = deleteProduct;
        }

        private void InitCard(ProductEntity entity)
        {
            _productId = entity.Id;
            productName.Text = entity.Name;
            productDescription.Text = entity.Description;
            productManufacturer.Text = entity.Manufacturer;
            productSupplier.Text = entity.Supplier;
            productDiscount.Text = entity.Discount + "%";
            productAmount.Text = entity.Amount.ToString();

            LoadProductImage(entity.Photo ?? "picture.png");

            // Скидка
            if (entity.Discount > 0)
            {
                productPrice.Text = entity.Price.ToString();
                productPrice.Font = new Font(productPrice.Font, FontStyle.Strikeout);
                productPriceWithDiscount.ForeColor = Color.Red;
                productPriceWithDiscount.Text = (entity.Price - entity.Price * 0.01 * entity.Discount).ToString();
            }
            productPrice.Text = entity.Price.ToString();

            // Кнопки редактировать / удалить

            if(Program.CurrentUser != null
                && Program.CurrentUser.Role == "Администратор")
            {
                editBtn.Visible = true;
                deleteBtn.Visible = true;
            }
        }

        private void LoadProductImage(string imageName)
        {
            try
            {
                string path = Path.Combine("Assets", imageName);

                if (File.Exists(path))
                {
                    using (var tempImage = new Bitmap(path))
                    {
                        productImg.Image = new Bitmap(tempImage);
                    }
                    return;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить?",
                "Удаление товара",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DeleteProduct(_productId);
            }
        }
    }
}
