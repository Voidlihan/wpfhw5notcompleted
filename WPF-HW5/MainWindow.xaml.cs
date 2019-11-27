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

namespace WPF_HW5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void RegButton(object sender, RoutedEventArgs e)
        {
            User user = new User
            {
                IIN = textBoxIIN.Text,
                Street = textBoxStreet.Text,
                House = textBoxHouse.Text,
                Phonenumber = textBoxPhonenumber.Text,
            };
            using(var context = new Context())
            {
                context.Add(user);
                context.SaveChanges();
            }
        }

        public bool isExist(string IIN)
        {
            using (var context = new Context())
            {
                var user = context.User.SingleOrDefault(user => user.IIN == IIN.ToLower());
                return !(user == null);
            }
        }

        public User SignIn(string IIN)
        {
            using (var context = new Context())
            {
                var user = context.User.SingleOrDefault(user => user.IIN == IIN.ToLower());
                return user;
            }
        }

        private void ToServices(object sender, RoutedEventArgs e)
        {
            ServiceChange serviceChange = new ServiceChange();
            serviceChange.Show();
        }

        private void SignInButton(object sender, RoutedEventArgs e)
        {
            if (isExist(textBoxIIN.Text))
            {       
                servicesButton.Visibility = Visibility.Visible;
            }
        }
    }
}
