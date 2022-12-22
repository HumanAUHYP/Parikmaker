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
    /// Логика взаимодействия для AddCashboxPage.xaml
    /// </summary>
    public partial class AddCashboxPage : Page
    {
        List<Client> Clients = db.connection.Client.ToList();
        List<Haircut> Haircuts = db.connection.Haircut.ToList();
        int clientId;
        int haircutId;
        public AddCashboxPage()
        {
            InitializeComponent();
            cbClient.ItemsSource = Clients;
            cbHaircut.ItemsSource = Haircuts;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Cashbox cashbox = new Cashbox();
            cashbox.ClientId = clientId;
            cashbox.HaircutId = haircutId;
            cashbox.CutDate = DateTime.Now.Date;

            db.connection.Cashbox.Add(cashbox);
            db.connection.SaveChanges();

            NavigationService.Navigate(new AdminPage());
        }

        private void cbClient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Client client = Clients[(sender as ComboBox).SelectedIndex];
            lbSurname.Content = client.Surname;
            lbLastname.Content = client.Lastname;
            clientId = client.Id;
        }

        private void cbHaircut_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Haircut haircut = Haircuts[(sender as ComboBox).SelectedIndex];
            haircutId = haircut.Id;
        }
    }
}
