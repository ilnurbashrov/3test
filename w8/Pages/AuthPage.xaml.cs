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
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void btUserClick(object sender, RoutedEventArgs e)
        {
            User user = EFModel.Init().Users.FirstOrDefault(u => u.UserLogin == tbLogin.Text && u.UserPassword == tbPass.Text);
            if(user == null)
            {
                MessageBox.Show("Неверный пароль или логин!");
                return;
            }

            if(user.Role.RoleName == "Администраторр")
            {
                NavigationService.Navigate(new AdminServicePage( user));
            }
        }

        private void btAdminClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
