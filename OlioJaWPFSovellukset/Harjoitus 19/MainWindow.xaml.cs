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

namespace Harjoitus_19
{
    public partial class MainWindow : Window
    {
        private int currentFloor = 1;

        public MainWindow()
        {
            InitializeComponent();
            PäivitäTämänKerroksenTeksti();
        }

        private void MoveButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(valitsemasiKerrosTextBox.Text, out int valitsemasiKerros))
            {
                if (valitsemasiKerros >= 1 && ¨valitsemasiKerros <= 10)
                {
                    if (valitsemasiKerros == tämäKerrosFloor)
                    {
                        MessageBox.Show("Olet jo valitsemassasi kerroksessa.");
                    }
                    else
                    {
                        MessageBox.Show("Hissi liikkuu kerrokseen: " + valitsemasiKerros);
                        tämäKerros = valitsemasiKerros;
                        PäivitäTämänKerroksenTeksti();
                    }
                }
                else
                {
                    MessageBox.Show("Virheellinen syöte. Valitse kerros väliltä 1-10.");
                }
            }
            else
            {
                MessageBox.Show("Virheellinen syöte. Valitse kerros väliltä 1-10.");
            }
        }

        private void PäivitäTämänKerroksenTeksti()
        {
            tämäKerrosTextBlock.Text = tämäKerros.ToString();
        }
    }
}