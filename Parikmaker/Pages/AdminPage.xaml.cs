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
using Parikmaker.DB;

namespace Parikmaker
{
    /// <summary>
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        List<Cashbox> Cashboxes = db.connection.Cashbox.ToList();
        public AdminPage()
        {
            InitializeComponent();
            CashboxTable.ItemsSource = Cashboxes;

            decimal profit = 0;
            foreach (var cash in Cashboxes)
            {
                profit += cash.Haircut.Price;
            }
            tbFullProfit.Text = $"Выручка: {profit}";
        }

        private void btnClients_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.ClientTablePage());
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.AddCashboxPage());
        }

        private void btnHaircuts_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.HaircutTablePage());
        }
    }
}
