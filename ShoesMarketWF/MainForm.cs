using Microsoft.Extensions.DependencyInjection;
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

        private FiltersControl _filtersControl;

        private List<ProductCard> productCards = new List<ProductCard>();
        public MainForm(IBaseRepository<ProductEntity> productRepository)
        {
            InitializeComponent();
            _productRepository = productRepository;


            CustomInitForm();

            var products = _productRepository.GetAll() ?? new();
            LoadProducts(products);
        }

        public void CustomInitForm()
        {
            // Приветствие
            var currentUser = Program.CurrentUser;
            if (currentUser != null)
            {
                welcomeLabel.Text = $"Добро пожаловать, {currentUser.Surname} {currentUser.Name}! ({currentUser.Role})";

                if (currentUser.Role == "Администратор")
                {
                    _filtersControl = new FiltersControl(_productRepository, LoadProducts);
                    this.infoFlowPanel.Controls.Add(_filtersControl);
                }
                    
            }
            else
            {
                _filtersControl = null!;
            }

            
        }

        private void LoadProducts(List<ProductEntity> products)
        {
            // Очищаем предыдущие карточки
            foreach (var card in productCards)
            {
                card.Dispose();
            }
            productCards.Clear();
            flowPanel.Controls.Clear();

            // Получаем данные о товарах 

            // Создаем карточки для каждого товара
            foreach (var product in products)
            {
                var card = new ProductCard(product);

                // Добавляем на панель
                flowPanel.Controls.Add(card);
                productCards.Add(card);
            }
        }

        private void backToAuthBtn_Click(object sender, EventArgs e)
        {
            Program.ShowForm<AuthForm>();
            Program.CurrentUser = null;
            this.Close(); // Закрываем текущую
        }
    }
}
