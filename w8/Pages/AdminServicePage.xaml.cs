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
using w8.DateBase;

namespace w8.Pages
{
    /// <summary>
    /// Логика взаимодействия для AdminServicePage.xaml
    /// </summary>
    public partial class AdminServicePage : Page
    {
        public AdminServicePage(User user)
        {
            InitializeComponent();
            tbFIO.Text = user.UserFN + " " + user.UserLN + " " + user.UserMN;
            UpdateData();
        }

        public void UpdateData()
        {
            IEnumerable<Product> products = EFModel.Init().Products.Where(w => w.ProductName.Contains(tbSearch.Text) || w.ProductCategory.Contains(tbSearch.Text));
            LvService.ItemsSource = products.ToList();
        }

        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateData();
        }

        private void cbSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
