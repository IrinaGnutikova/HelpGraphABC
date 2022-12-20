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

namespace HelpGraphABC
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

        private void BtnLvl1_Click(object sender, RoutedEventArgs e)
        {
            FLvl.NavigationService.Navigate(new Uri("Pages_Lvl,Itog,Start/Lvl_1.xaml", UriKind.Relative));
        }

        private void BtnLvl2_Click(object sender, RoutedEventArgs e)
        {
            FLvl.NavigationService.Navigate(new Uri("Pages_Lvl,Itog,Start/Lvl_2.xaml", UriKind.Relative));
        }

        private void BtnLvl3_Click(object sender, RoutedEventArgs e)
        {
            FLvl.NavigationService.Navigate(new Uri("Pages_Lvl,Itog,Start/Lvl_3.xaml", UriKind.Relative));
        }

        private void BtnLvl4_Click(object sender, RoutedEventArgs e)
        {
            FLvl.NavigationService.Navigate(new Uri("Pages_Lvl,Itog,Start/Lvl_4.xaml", UriKind.Relative));
        }

        private void BtnLvl5_Click(object sender, RoutedEventArgs e)
        {
            FLvl.NavigationService.Navigate(new Uri("Pages_Lvl,Itog,Start/Lvl_5.xaml", UriKind.Relative));

        }

        private void BtnLvl6_Click(object sender, RoutedEventArgs e)
        {
            FLvl.NavigationService.Navigate(new Uri("Pages_Lvl,Itog,Start/Lvl_6.xaml", UriKind.Relative));
        }

        private void BtnItog_Click(object sender, RoutedEventArgs e)
        {
            if (Prov.Proverka.All(x => x == true))
            {
                FLvl.NavigationService.Navigate(new Uri("Pages_Lvl,Itog,Start/Itog.xaml", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("Ты выполнил не все задания! Вернись, когда все задания будут выполнены.","Ошибка!");
            }
        }
    }
}
