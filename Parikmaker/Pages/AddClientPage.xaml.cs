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
    /// Логика взаимодействия для AddClientPage.xaml
    /// </summary>
    public partial class AddClientPage : Page
    {
        public AddClientPage()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Client client = new Client();
            client.Name = tbName.Text;
            client.Surname = tbSurname.Text;
            client.Lastname = tbLastname.Text;

            db.connection.Client.Add(client);
            db.connection.SaveChanges();
            NavigationService.Navigate(new ClientTablePage());
        }
    }
}
