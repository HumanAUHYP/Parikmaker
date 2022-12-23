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

namespace Parikmaker
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        string login = "Admin";
        string password = "Admin123";
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            if (tbxLogin.Text == login && pbxPassword.Password == password)
            {
                MessageBox.Show("Все правильно");
                NavigationService.Navigate(new AdminPage());
            }
            else
                MessageBox.Show("Логин или пароль не верны");
        }
    }
}
