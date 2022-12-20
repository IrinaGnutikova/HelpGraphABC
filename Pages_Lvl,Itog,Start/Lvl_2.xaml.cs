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
    /// Interaction logic for Lvl_2.xaml
    /// </summary>
    public static class ProvMethodLvl2
    {
        public static bool ProvTask(int x, int y)
        {
            if (x == 380 && y == 300)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public partial class Lvl_2 : Page
    {
        public Lvl_2()
        {
            InitializeComponent();
            if (Prov.Proverka[1] == true)
            {
                var bc = new BrushConverter();
                tblNameLvl.Foreground = (Brush)bc.ConvertFrom("#FF459F5D");
            }
        }

        private void BtnProv_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (ProvMethodLvl2.ProvTask(Convert.ToInt32(tbX.Text),Convert.ToInt32(tbY.Text))==true)
                {
                    imRedBall.Margin = new Thickness(709, 305, 0, 0);
                    Prov.Proverka[1] = true;
                    var bc = new BrushConverter();
                    tblNameLvl.Foreground = (Brush)bc.ConvertFrom("#FF459F5D");
                }
                else
                {
                    MessageBox.Show("Это неправильное значеение х или у. Будь внимательнее! Не забудь про радиус. На графике изображены координаты границ мячика, а не его середины.", "Осторожнее!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Вводи только целые числа", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            imRedBall.Margin = new Thickness(491, 189, 0, 0);
            tbX.Text = "100";
            tbY.Text = "150";
            Prov.Proverka[1] = false;
            var bc = new BrushConverter();
            tblNameLvl.Foreground = (Brush)bc.ConvertFrom("#FF000000");
        }
    }
}
