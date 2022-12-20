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
    /// Логика взаимодействия для Lvl_6.xaml
    /// </summary>
    public static class ProvMethodLvl6
    {
        public static bool ProvTask(int cirREye, int cirY, int cirR, int elX, int lineX2, int lineX1, string color, string setbr, string ffill)
        {
            if (cirREye == 15 && cirY == 250 && cirR == 80 && elX == 90 && lineX2 == 185 && lineX1 == 235 && color == "clLightSkyBlue" && setbr == "SetBrushColor" && ffill == "FloodFill")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public partial class Lvl_6 : Page
    {
        public Lvl_6()
        {
            InitializeComponent();
            if (Prov.Proverka[5] == true)
            {
                var bc = new BrushConverter();
                tblNameLvl.Foreground = (Brush)bc.ConvertFrom("#FF459F5D");
            }
        }

        private void BtnProv_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int cirREye = Convert.ToInt32(tbCirREye.Text);
                int cirY = Convert.ToInt32(tbCirY.Text);
                int cirR = Convert.ToInt32(tbCirR.Text);
                int elX = Convert.ToInt32(tbElX.Text);
                int lineX2 = Convert.ToInt32(tbLineX2.Text);
                int lineX1 = Convert.ToInt32(tbLineX1.Text);
                string color = cbColor.SelectionBoxItem.ToString();
                string setbr = cbSetbr.SelectionBoxItem.ToString();
                string ffill = cbFfill.SelectionBoxItem.ToString();
                if (ProvMethodLvl6.ProvTask(cirREye, cirY, cirR, elX, lineX2, lineX1, color, setbr, ffill) == true)
                {
                    imLvl.Source = new BitmapImage(new Uri(@"\Source\Lvl6_end.png", UriKind.Relative));
                    Prov.Proverka[5] = true;
                    var bc = new BrushConverter();
                    tblNameLvl.Foreground = (Brush)bc.ConvertFrom("#FF459F5D");
                }
                else
                {
                    MessageBox.Show("Это неправильный ответ. Будь внимательнее! Если что-то забыл, то загляни в справку.", "Осторожнее!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Вводи только целые числа", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    

        private void BtnHelp_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("FloodFill(x, y, color) - Закрашивает замкнутую область. Точка с координатами (X, Y) — начальная точка внутри замкнутой области, с которой начнется закраска." + Environment.NewLine + "SetBrushColor(c: Color) - Устанавливает цвет текущей кисти" + Environment.NewLine + "Ellipse(x1, y1, x2, y2) - Рисует заполненный эллипс, ограниченный прямоугольником, заданным координатами противоположных вершин (x1, y1) и (x2, y2)" + Environment.NewLine + "Circle(x, y, r) - Рисует заполненную окружность с центром (x, y) и радиусом r", "Справка");
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            imLvl.Source = new BitmapImage(new Uri(@"\Source\Lvl6_start.png", UriKind.Relative));
            tbCirREye.Text = "";
            tbCirY.Text = "";
            tbCirR.Text = "";
            tbElX.Text = "";
            tbLineX2.Text = "";
            tbLineX1.Text = "";
            Prov.Proverka[5] = false;
            var bc = new BrushConverter();
            tblNameLvl.Foreground = (Brush)bc.ConvertFrom("#FF000000");

        }
    }
}
