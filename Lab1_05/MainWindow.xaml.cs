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

namespace Lab1_05
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

        private void textBoxImie_LostFocus(object sender, RoutedEventArgs e)
        {
            labelKom1.Content = "Siemka, " + textBoxImie.Text + " " + textBoxNazwisko.Text;
        }
        private void textBoxNazwisko_LostFocus(object sender, RoutedEventArgs e)
        {
            labelKom1.Content = "Siemka, " + textBoxImie.Text + " " + textBoxNazwisko.Text;
        }

        private void textBoxWiek_LostFocus(object sender, RoutedEventArgs e)
        {
            int wiek = Convert.ToInt32(textBoxWiek.Text);
            if (wiek < 65)
            {
                labelKom2.Content = string.Format(" Do emerytury pozostało ci {0} lat", 65 - wiek);
            }
            else
            {
                labelKom2.Content = "Jesteś emerytem!";
            }
        }

      

        private void buttonWyczysc_Click(object sender, RoutedEventArgs e)
        {
            labelKom1.Content = " ";
            labelKom2.Content = " ";
            textBoxImie.Text = " ";
            textBoxNazwisko.Text = " ";
            textBoxWiek.Text = " ";
        }
    }
}
