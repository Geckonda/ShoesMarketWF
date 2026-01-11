using ShoesMarketWF.Abstractions;
using ShoesMarketWF.Controls;
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

namespace ShoesMarketWF
{
    public partial class MainForm : Form
    {
        private readonly IBaseRepository<ProductEntity> _productRepository;

        private List<ProductCard> productCards = new List<ProductCard>();
        public MainForm(IBaseRepository<ProductEntity> productRepository)
        {
            InitializeComponent();
            _productRepository = productRepository;
            //filterControl1.ApplyRole(Program.CurrentRole);

            //SetupUI();
            LoadProducts();
        }
        //private void SetupUI()
        //{
        //    flowPanel = new FlowLayoutPanel
        //    {
        //        Dock = DockStyle.Fill,
        //        AutoScroll = true,
        //        WrapContents = true,
        //        Padding = new Padding(10),
        //        BackColor = Color.White
        //    };

        //    this.Controls.Add(flowPanel);
        //}

        private void LoadProducts()
        {
            // Очищаем предыдущие карточки
            foreach (var card in productCards)
            {
                card.Dispose();
            }
            productCards.Clear();
            flowPanel.Controls.Clear();

            // Получаем данные о товарах 
            var products = _productRepository.GetAll() ?? new();

            // Создаем карточки для каждого товара
            foreach (var product in products)
            {
                var card = new ProductCard(product);

                // Добавляем на панель
                flowPanel.Controls.Add(card);
                productCards.Add(card);
            }
        }
    }
}
