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

                if(currentUser.Role == "Администратор" || currentUser.Role == "Модератор")
                {
                    orderBtn.Visible = true;
                }
                if (currentUser.Role == "Администратор")
                {
                    _filtersControl = new FiltersControl(_productRepository, LoadProducts);
                    this.infoFlowPanel.Controls.Add(_filtersControl);
                    addBtn.Visible = true;
                }
                    
            }
            else
            {
                _filtersControl = null!;
            }

            
        }


        private void LoadProducts(List<ProductEntity> products)
        {
            // Замораживаем отрисовку панели
            flowPanel.SuspendLayout();

            try
            {
                // Очищаем предыдущие карточки
                foreach (var card in productCards)
                {
                    card.Dispose();
                }
                productCards.Clear();
                flowPanel.Controls.Clear();

                // Создаем новые карточки
                foreach (var product in products)
                {
                    var card = new ProductCard(product, DeleteProduct);
                    flowPanel.Controls.Add(card);
                    productCards.Add(card);
                }
            }
            finally
            {
                // Возобновляем отрисовку и перерисовываем всё сразу
                flowPanel.ResumeLayout();
                flowPanel.PerformLayout(); // Принудительная перерисовка
            }
        }

        private void DeleteProduct(int id)
        {
            try
            {
                //_productRepository.Delete(id);
                MessageBox.Show("Удалил");

            }
            catch (Exception)
            {
                MessageBox.Show("при удалении что-то пошло не так", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void backToAuthBtn_Click(object sender, EventArgs e)
        {
            Program.ShowForm<AuthForm>();
            Program.CurrentUser = null;
        }
    }
}
