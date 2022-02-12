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
using System.Windows.Shapes;
using System.IO;

namespace qwe
{
    /// <summary>
    /// Логика взаимодействия для admWindow.xaml
    /// </summary>
    public partial class admWindow : Window
    {
        

        int C = 0;
        int ax1, ax2, ax5, ax10;
        string path = Directory.GetCurrentDirectory();
        public admWindow(int x1, int x2, int x5, int x10)
        {
            InitializeComponent();

            ax1 = x1;
            ax2 = x2;
            ax5 = x5;
            ax10 = x10;
            RUB.Content = C + " Руб.";

            path = path.Replace(@"\", @"\\");
            path = path + "\\DB\\";
        }

        
        

        private void OneBT_Click(object sender, RoutedEventArgs e)
        {
            C = C + 1;
            ax1++;
            RUB.Content = C + " Руб.";
            File.WriteAllText(path + "1.txt", Convert.ToString(ax1));

        }

        private void TwoBT_Click(object sender, RoutedEventArgs e)
        {
            ax2++;
            C = C + 2;
            RUB.Content = C + " Руб.";
            File.WriteAllText(path + "2.txt", Convert.ToString(ax2));
        }

        private void FiveBT_Click(object sender, RoutedEventArgs e)
        {
            ax5++;
            C = C + 5;
            RUB.Content = C + " Руб.";
            File.WriteAllText(path + "5.txt", Convert.ToString(ax5));
        }

        private void TenBT_Click(object sender, RoutedEventArgs e)
        {
            ax10++;
            C = C + 10;
            RUB.Content = C + " Руб.";
            File.WriteAllText(path + "10.txt", Convert.ToString(ax10));
        }

        private void Och_Click(object sender, RoutedEventArgs e)
        {
            PDFWindow pDF= new PDFWindow();
            pDF.Show();
           
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddWindow addWindow = new AddWindow();
            addWindow.Show();
            this.Close();
        }

        private void AuthBT_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void CoinddBT_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ваша сдача: " + Convert.ToString(C) + " руб.");
        }

        private void Coin_Click(object sender, RoutedEventArgs e)
        {
            CoinWindow cw = new CoinWindow(ax1, ax2, ax5, ax10);
            cw.Show();
            

        }
    }
}
