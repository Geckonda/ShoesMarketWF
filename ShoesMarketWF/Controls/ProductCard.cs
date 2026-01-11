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
        public ProductCard(ProductEntity entity)
        {
            InitializeComponent();
            InitCard(entity);
        }

        private void InitCard(ProductEntity entity)
        {
            productName.Text = entity.Name;
            productDescription.Text = entity.Description;
            productManufacturer.Text = entity.Manufacturer;
            productPrice.Text = entity.Price.ToString();
            productSupplier.Text = entity.Supplier;
            productDiscount.Text = entity.Discount + "%";
            productAmount.Text = entity.Amount.ToString();

            LoadProductImage(entity.Photo ?? "picture.png");
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

    }
}
