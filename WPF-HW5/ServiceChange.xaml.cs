using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_HW5
{
    /// <summary>
    /// Interaction logic for ServiceChange.xaml
    /// </summary>
    public partial class ServiceChange : Window
    {
        public ServiceChange()
        {
            InitializeComponent();
        }

        private void LightButton(object sender, RoutedEventArgs e)
        {
            Service service1 = new Service() {
                Name = "Свет"
            };

            using(var context = new Context())
            {
                context.Add(service1);
                context.SaveChanges();
            }
        }

        private void OtoplenieButton(object sender, RoutedEventArgs e)
        {
            Service service2 = new Service()
            {
                Name = "Отопление"
            };

            using (var context = new Context())
            {
                context.Add(service2);
                context.SaveChanges();
            }
        }

        private void WaterButton(object sender, RoutedEventArgs e)
        {
            Service service3 = new Service()
            {
                Name = "Вода"
            };

            using (var context = new Context())
            {
                context.Add(service3);
                context.SaveChanges();
            }
        }
    }
}
