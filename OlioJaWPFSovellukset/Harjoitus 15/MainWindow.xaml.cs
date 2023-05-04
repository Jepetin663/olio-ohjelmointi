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

namespace Harjoitus_15
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private int henkilöAutot = 0;
        private int kuormaAutot = 0;

        public MainWindow()
        {
            InitializeComponent();

            TextAuto.Text = henkilöAutot.ToString();
            TextKuorma.Text = kuormaAutot.ToString();
        }

        private void ButtonAuto_Click(object sender, RoutedEventArgs e)
        {
            henkilöAutot++;
            TextAuto.Text = henkilöAutot.ToString();
        }

        private void ButtonKuorma_Click(object sender, RoutedEventArgs e)
        {
            kuormaAutot++;
            TextKuorma.Text = kuormaAutot.ToString();
        }
    }
}
