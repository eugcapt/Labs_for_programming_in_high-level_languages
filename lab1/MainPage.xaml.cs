using System;
using System.Collections.Generic;
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

namespace lab1
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ClientsButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Clients());
        }
        private void ProductsButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Products());
        }
        private void SuppilerButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Supplier());
        }
        private void profileButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Profile());
        }
    }
}
