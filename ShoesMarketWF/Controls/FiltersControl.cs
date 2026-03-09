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

        // Метод для загрузки товаров в кталоге (Делегат)
        private Action<List<ProductEntity>> LoadProducts;


        // Сделать так. чтобы фильтры работали вместе
        private List<ProductEntity> _filtredProducts;

        public FiltersControl(IBaseRepository<ProductEntity> productRepository, Action<List<ProductEntity>> loadProducts)
        {
            InitializeComponent();
            _productRepository = productRepository;
            LoadProducts = loadProducts;

            // Default для сортировки
            sortComboBox.SelectedIndex = 0;

            // Default для фильтрации
            var categories = _productRepository.GetAll()
                .Select(x => x.Category)
                .Distinct()
                .ToList() ?? new List<string>();

            // Точно добавляем одну
            filterComboBox.Items.Add("Все");
            filterComboBox.SelectedIndex = 0;

            if (categories.Any())
                filterComboBox.Items.AddRange(categories.ToArray());
        }



        private void resetBtn_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = "";
            var products = _productRepository.GetAll() ?? new();
            LoadProducts(products);
        }

        // Общий метод для применения всех фильтров
        private void ApplyFilters()
        {
            // Получаем все продукты из репозитория
            var allProducts = _productRepository.GetAll() ?? new List<ProductEntity>();

            // Применяем фильтрацию по категории
            var filteredProducts = allProducts;

            // Фильтр по категории
            if (filterComboBox.SelectedIndex != 0 && filterComboBox.SelectedItem != null)
            {
                var selectedCategory = filterComboBox.SelectedItem.ToString();
                filteredProducts = filteredProducts.Where(x => x.Category == selectedCategory).ToList();
            }

            // Фильтр по поисковому тексту
            if (!string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                var searchText = searchTextBox.Text;
                filteredProducts = filteredProducts.Where(x =>
                    x.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase)
                    || x.Manufacturer.Contains(searchText, StringComparison.OrdinalIgnoreCase)
                    || x.Supplier.Contains(searchText, StringComparison.OrdinalIgnoreCase)
                    || x.Description.Contains(searchText, StringComparison.OrdinalIgnoreCase)
                    ).ToList(); // Игнориреут регистры
            }

            // Применяем сортировку
            if (sortComboBox.SelectedIndex == 1) // По убыванию цены
            {
                filteredProducts = filteredProducts.OrderByDescending(x => x.Price).ToList();
            }
            else if (sortComboBox.SelectedIndex == 2) // По возрастанию цены
            {
                filteredProducts = filteredProducts.OrderBy(x => x.Price).ToList();
            }

            // Загружаем результат
            LoadProducts(filteredProducts.ToList());
        }

        // Теперь вызываем этот метод из всех обработчиков
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void sortComboBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void filterComboBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }
    }
}

