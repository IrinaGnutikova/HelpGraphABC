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
    /// Логика взаимодействия для Lvl_4.xaml
    /// </summary>
    public static class ProvMethodLvl4
    {
        public static bool ProvTask(int x1, int y1, int x2, int y2)
        {
            if (x1 == 170 && y1 == 160 && x2 == 330 && y2 == 160)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public partial class Lvl_4 : Page
    {
        public Lvl_4()
        {
            InitializeComponent();
            if (Prov.Proverka[3] == true)
            {
                var bc = new BrushConverter();
                tblNameLvl.Foreground = (Brush)bc.ConvertFrom("#FF459F5D");
            }
        }

        private void BtnProv_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int x1 = Convert.ToInt32(tbX1.Text);
                int x2 = Convert.ToInt32(tbX2.Text);
                int y1 = Convert.ToInt32(tbY1.Text);
                int y2 = Convert.ToInt32(tbY2.Text);
                if (ProvMethodLvl4.ProvTask(x1, y1, x2, y2))
                {
                    imLine.Margin = new Thickness(589, 242, 0, 0);
                    Prov.Proverka[3] = true;
                    var bc = new BrushConverter();
                    tblNameLvl.Foreground = (Brush)bc.ConvertFrom("#FF459F5D");
                }
                else
                {
                    MessageBox.Show("Это неправильные значеения. Будь внимательнее!", "Осторожнее!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Вводи только целые числа", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnHelp_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Первые два числа являются координатами точки начала линии (х - первое число, у - второе). Вторые два числа координаты точки конца линии (х и у соответственно).", "Подсказка", MessageBoxButton.OK, MessageBoxImage.Question);
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            imLine.Margin = new Thickness(569, -92, 0, 0);
            tbX1.Text = "";
            tbY1.Text = "";
            tbX2.Text = "";
            tbY2.Text = "";
            Prov.Proverka[3] = false;
            var bc = new BrushConverter();
            tblNameLvl.Foreground = (Brush)bc.ConvertFrom("#FF000000");
        }
    }
}
