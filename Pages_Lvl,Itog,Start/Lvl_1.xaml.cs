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


namespace HelpGraphABC.Pages_Lvl_Itog_Start
{
    /// <summary>
    /// Interaction logic for Lvl_1.xaml
    /// </summary>
    public static class ProvMethodLvl1
    {
        public static bool ProvTask(int x)
        {
            if (x == 260)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public partial class Lvl_1 : Page
    {
        public Lvl_1()
        {
            InitializeComponent();
            if (Prov.Proverka[0] == true)
            {
                var bc = new BrushConverter();
                tblNameLvl.Foreground = (Brush)bc.ConvertFrom("#FF459F5D");
            }
        }


        private void BtnProv_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (ProvMethodLvl1.ProvTask(Convert.ToInt32(tbX.Text)) == true)
                {
                    imRedBall.Margin = new Thickness(667, 326, 0, 0);
                    Prov.Proverka[0] = true;
                    var bc = new BrushConverter();
                    tblNameLvl.Foreground = (Brush)bc.ConvertFrom("#FF459F5D");
                }
                else
                {
                     MessageBox.Show("Это неправильное значеение х. Будь внимательнее!", "Осторожнее!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Вводи только целые числа", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            imRedBall.Margin = new Thickness(494, 326, 0, 0);
            tbX.Text = "50";
            Prov.Proverka[0] = false;
            var bc = new BrushConverter();
            tblNameLvl.Foreground = (Brush)bc.ConvertFrom("#FF000000");
        }
    }
}
