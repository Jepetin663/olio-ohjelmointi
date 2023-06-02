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
using static System.Net.Mime.MediaTypeNames;

namespace Harjoitus_17
{
    public partial class MainWindow : Window
    {
        private int saunanlämpö = 30;
        private int keittiönvalot;

        public MainWindow()
        {
            InitializeComponent();

            tblValue.Text = saunanlämpö + "°C";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            float saunanlämpö2 = saunanlämpö--;
            tblValue.Text = saunanlämpö2 + "°C";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            float saunanlämpö1 = saunanlämpö++;
            tblValue.Text = saunanlämpö1 + "°C";
        }

        private void btnSavu_Click(object sender, RoutedEventArgs e)
        {
            if (imgSavu.Visibility == Visibility.Hidden)
            {
                imgSavu.Visibility = Visibility.Visible;
            }
            else
            {
                imgSavu.Visibility = Visibility.Hidden;
            }
        }
        private void btnValot_Click(object sender, RoutedEventArgs e)
        {
            if (imgValo.Visibility == Visibility.Hidden)
            {
                imgValo.Visibility = Visibility.Visible;
            }
            else
            {
                imgValo.Visibility = Visibility.Hidden;
            }
        }
    }
}
