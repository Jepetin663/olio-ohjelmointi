using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Harjoitus_16
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


        private void btnKmToMiles_Click(object sender, RoutedEventArgs e)
        {
            float annettuArvo;
            bool result = float.TryParse(tbInputField.Text, out annettuArvo);

            if (result)
            {
                string conversionText = annettuArvo + " kilometers = " + KmToMiles(annettuArvo).ToString() + " miles";
                UpdateText(conversionText);
            }
            else
            {
                UpdateText("Text box can't contain anything else than numbers");
            }
        }

        private void btnMilesToKm_Click(object sender, RoutedEventArgs e)
        {
            float annettuArvo;
            bool result = float.TryParse(tbInputField.Text, out annettuArvo);

            if (result)
            {
                string conversionText = annettuArvo + " miles =  " + MilesToKm(annettuArvo).ToString() + " kilometers" +
                    "";
                UpdateText(conversionText);
            }
            else
            {
                UpdateText("Text box can't contain anything else than numbers");
            }
        }

        private void UpdateText(string text)
        {
            tbCoversionResult.Text = text;
        }


        // staattinen metodi, jonka avulla voidaan muuntaa kilometrit maileiksi.
        //Metodissa tulee olla yksi parametri (float i) ja tulee palauttaa float -arvo hakijalle
        private static float KmToMiles(float i)
        {
            float conversion = 0.62137f;

            return i * conversion;
        }

        private static float MilesToKm(float i)
        {
            float conversion = 1.609344f;

            return i * conversion;
        }

    }
}
