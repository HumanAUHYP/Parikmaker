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
    /// Логика взаимодействия для HaircutAddPage.xaml
    /// </summary>
    public partial class HaircutAddPage : Page
    {
        Haircut haircut = new Haircut();
        List<Gender> Genders = db.connection.Gender.ToList();
        public HaircutAddPage()
        {
            InitializeComponent();
            cbGender.ItemsSource = Genders;
        }

        private void cbGender_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            haircut.Gender = ((sender as ComboBox).SelectedItem as Gender).Short;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            haircut.Name = tbName.Text;
            haircut.Price = Convert.ToDecimal(tbPrice.Text);
            db.connection.Haircut.Add(haircut);
            db.connection.SaveChanges();
            NavigationService.Navigate(new HaircutTablePage());
        }
    }
}
