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
    /// Логика взаимодействия для Lvl_5.xaml
    /// </summary>
    public static class ProvMethodLvl5
    {
        public static bool ProvTask(int x1, int y1, int x2, int y2, string color)
        {
            if (x1 == 230 && y1 == 30 && x2 == 280 && y2 == 200 && color == "clYellow")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public partial class Lvl_5 : Page
    {
        public Lvl_5()
        {
            InitializeComponent();
            if (Prov.Proverka[4] == true)
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
                int y1 = Convert.ToInt32(tbY1.Text);
                int x2 = Convert.ToInt32(tbX2.Text);
                int y2 = Convert.ToInt32(tbY2.Text);
                string color = cbColor.SelectionBoxItem.ToString();
                if (ProvMethodLvl5.ProvTask(x1, y1, x2, y2, color) == true)
                {
                    imRec.Margin = new Thickness(645, 125, 0, 0);
                    Prov.Proverka[4] = true;
                    var bc = new BrushConverter();
                    tblNameLvl.Foreground = (Brush)bc.ConvertFrom("#FF459F5D");
                }
                else
                {
                    MessageBox.Show("Это неправильый ответ. Будь внимательнее!", "Осторожнее!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Вводи только целые числа", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("FloodFill закрашивает замкнутую область. Данная процедура имеет 3 параметра. Первые 2 параметра определяют точку с координатами, откуда начинается закраска. 3-й параметр определяет цвет."+ Environment.NewLine +"Rectangle (x1, y1, x2, y2) - рисует контур прямоугольника. Точки с координатами (x1, y1) и (x2, y2) определяют диагональные вершины прямоугольника.", "Справка");
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            imRec.Margin = new Thickness(591, -219, 0, 0);
            tbX1.Text = "";
            tbY1.Text = "";
            tbX2.Text = "";
            tbY2.Text = "";
            Prov.Proverka[4] = false;
            var bc = new BrushConverter();
            tblNameLvl.Foreground = (Brush)bc.ConvertFrom("#FF000000");
        }
    }
}
