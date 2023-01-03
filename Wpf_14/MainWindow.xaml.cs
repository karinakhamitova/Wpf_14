using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProductName = "Микроволновка",
                ProductCost = 3000,
                ProductImage = "Data/микроволновка.png",
                ProductType = ProductTypes.Electronics
            });
            products.Add(new Product()
            {
                ProductName = "Бургер",
                ProductCost = 200,
                ProductImage = "Data/бургер.png",
                ProductType = ProductTypes.Food
            });
            products.Add(new Product()
            {
                ProductName = "Вентилятор",
                ProductCost = 7200,
                ProductImage = "Data/вентилятор.png",
                ProductType = ProductTypes.Electronics
            });
            products.Add(new Product()
            {
                ProductName = "Курица",
                ProductCost = 220,
                ProductImage = "Data/курица.png",
                ProductType = ProductTypes.Food
            });
            products.Add(new Product()
            {
                ProductName = "Носки",
                ProductCost = 400,
                ProductImage = "Data/носки.png",
                ProductType = ProductTypes.Clothes
            });
            products.Add(new Product()
            {
                ProductName = "Свитер",
                ProductCost = 5500,
                ProductImage = "Data/свитер.png",
                ProductType = ProductTypes.Clothes
            });
            products.Add(new Product()
            {
                ProductName = "Шапка",
                ProductCost = 800,
                ProductImage = "Data/шапка.png",
                ProductType = ProductTypes.Clothes
            });
            lstBox.ItemsSource=products;

        }
    }
}
