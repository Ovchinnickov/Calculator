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

namespace Калькулятор_Зарплаты_Преподавателя
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        double zarplata;
        double zarplata1 = 3880;
        double zarplata2 = 4268;
        double zarplata3 = 5106;
        double zarplata4 = 5247;
        double zarplata5 = 6003;
        double zarplata6 = 6463;
        double zarplata7 = 6960;
        private void vich(object sender, RoutedEventArgs e)
        {
            double chasiki = 0;
            double uroven_kval = 1;

            if (Assistent.IsChecked == true)
            {
                zarplata = zarplata1;
                chasiki = 24;
            }
            if (Tich.IsChecked == true)
            {
                zarplata = zarplata2;
                chasiki = 32;
            }
            if (Oldtich.IsChecked == true)
            {
                zarplata = zarplata3;
                chasiki = 35;
            }
            if (Docent.IsChecked == true)
            {
                zarplata = zarplata4;
                chasiki = 35;
            }
            if (Profi.IsChecked == true)
            {
                zarplata = zarplata5;
                chasiki = 36;
            }
            if (Dekan.IsChecked == true)
            {
                zarplata = zarplata6;
                chasiki = 33;
            }
            if (Zaved.IsChecked == true)
            {
                zarplata = zarplata7;
                chasiki = 37;
            }

            if (doc1.IsChecked == true)
            {
                zarplata = zarplata * 1.40;
                uroven_kval++;
            }
           
            if (zaved11.IsChecked == true)
            {
                chasiki += 3;
                zarplata = zarplata * 1.1;
                uroven_kval++;
            }
            if (nats_proekt1.IsChecked == true)
            {
                chasiki += 3;
                zarplata = zarplata * 1.15;
                uroven_kval++;
            }
            if (kyrat1.IsChecked == true)
            {
                chasiki += 2;
                zarplata = zarplata * 1.2;
                uroven_kval++;
            }
            if (ychit1.IsChecked == true)
            {
                zarplata = zarplata * 1.5;
                uroven_kval++;
            }
           
            if (kanddoc1.IsChecked == true)
            {
                zarplata = zarplata * 1.7;
                uroven_kval++;
            }
           
            double nach2 = zarplata;
            double koef2 = nach2 / 95;
            double nal2 = (nach2 - koef2) * 0.13;
            double vidach2 = nach2 - koef2 - nal2;
            nach.Text = nach2.ToString();
            koef.Text = Math.Round(koef2, 2).ToString();
            nal.Text = Math.Round(nal2, 2).ToString();
            vidach.Text = Math.Round(vidach2, 2).ToString();
            uroven.Text = uroven_kval.ToString();
            chasi_v_nedelu.Text = chasiki.ToString();
        }
    }
}
