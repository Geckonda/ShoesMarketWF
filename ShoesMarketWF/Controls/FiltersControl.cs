using ShoesMarketWF.Abstractions;
using ShoesMarketWF.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesMarketWF.Controls
{
    public partial class FiltersControl : UserControl
    {
        private readonly IBaseRepository<ProductEntity> _productRepository;
        private Action<List<ProductEntity>> LoadProducts;


        public FiltersControl(IBaseRepository<ProductEntity> productRepository, Action<List<ProductEntity>> loadProducts)
        {
            InitializeComponent();
            _productRepository = productRepository;
            LoadProducts = loadProducts;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var products = _productRepository.GetAll() ?? new();
            products = products.Where(x => x.Name == searchTextBox.Text).ToList();
            LoadProducts(products);
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            var products = _productRepository.GetAll() ?? new();
            LoadProducts(products);
        }
    }
}

