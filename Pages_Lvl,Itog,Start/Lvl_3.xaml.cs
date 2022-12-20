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
    /// Логика взаимодействия для Lvl_3.xaml
    /// </summary>
    public static class ProvMethodLvl3
    {
        public static bool ProvTask(string color)
        {
            if (color == "clBlue")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public partial class Lvl_3 : Page
    {
        public Lvl_3()
        {
            InitializeComponent();
            if (Prov.Proverka[2] == true)
            {
                var bc = new BrushConverter();
                tblNameLvl.Foreground = (Brush)bc.ConvertFrom("#FF459F5D");
            }
        }

        private void BtnProv_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (ProvMethodLvl3.ProvTask(tbColor.Text) == true)
                {
                    imBall.Source = new BitmapImage(new Uri(@"\Source\Blue_ball.png", UriKind.Relative));
                    Prov.Proverka[2] = true;
                    var bc = new BrushConverter();
                    tblNameLvl.Foreground = (Brush)bc.ConvertFrom("#FF459F5D");
                }
                else
                {
                    MessageBox.Show("Это неправильный цвет. Будь внимательнее! Цвет пишется с заглавной буквы, а cl с маленькой. Они пишутся слитно!", "Осторожнее!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
            catch
            {
            }
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            imBall.Source = new BitmapImage(new Uri(@"\source\Red_ball.png", UriKind.Relative));
            tbColor.Text = "clRed";
            Prov.Proverka[2] = false;
            var bc = new BrushConverter();
            tblNameLvl.Foreground = (Brush)bc.ConvertFrom("#FF000000");
        }
    }
}
