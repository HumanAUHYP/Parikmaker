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

namespace Parikmaker.Pages
{
    /// <summary>
    /// Логика взаимодействия для ClientTablePage.xaml
    /// </summary>
    public partial class ClientTablePage : Page
    {
        List<Client> Clients = db.connection.Client.ToList();
        public ClientTablePage()
        {
            InitializeComponent();
            ClientTable.ItemsSource = Clients;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddClientPage());
        }
    }
}
