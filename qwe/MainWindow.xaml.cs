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
using System.IO;

namespace qwe
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int C = 0;
        int x1 = 0;
        int x2 = 0;
        int x5 = 0;
        int x10 = 0;
        public MainWindow()
        {
            InitializeComponent();
            
            RUB.Content = C + " Руб.";
        }

        private void AuthBT_Click(object sender, RoutedEventArgs e)
        {
            Auth auth = new Auth(x1, x2, x5, x10);
            auth.Show();
            this.Close();    

        }

        private void OneBT_Click(object sender, RoutedEventArgs e)
        {
            C = C + 1;
            x1 ++;
            RUB.Content = C + " Руб.";
            File.WriteAllText("D:\\qwe\\BD\\1.txt", Convert.ToString(x1));
        }

        private void TwoBT_Click(object sender, RoutedEventArgs e)
        {
            C = C + 2;
            x2++;
            RUB.Content = C + " Руб.";
            File.WriteAllText("D:\\qwe\\BD\\2.txt", Convert.ToString(x2));
        }

        private void FiveBT_Click(object sender, RoutedEventArgs e)
        {
            C = C + 5;
            x5++;
            RUB.Content = C + " Руб.";
            File.WriteAllText("D:\\qwe\\BD\\5.txt", Convert.ToString(x5));
        }

        private void TenBT_Click(object sender, RoutedEventArgs e)
        {
            C = C + 10;
            x10++;
            RUB.Content = C + " Руб.";
            File.WriteAllText("D:\\qwe\\BD\\10.txt", Convert.ToString(x10));
        }

        private void CoinddBT_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ваша сдача: " + Convert.ToString(C) + " руб." );
        }
    }
}
