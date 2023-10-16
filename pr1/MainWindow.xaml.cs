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
using Lib_13;

namespace pr1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string Ch; string Zn;//описываем 2 переменных, число и вывод
        public MainWindow()
        {
            InitializeComponent();
        }

        private void InfoCLick(object sender, RoutedEventArgs e)//инфокнопка
        {
            MessageBox.Show("Кулькова Ангелина ИСП-31 \r\n Практическая работа 1. \r\n Генерировать случайные числа Х, распределенные в диапазоне от -5 до 5 и вычислять для чисел > 0 корень из X, а для чисел < 0 функцию x2.\r\n Вычисления прекратить, когда подряд появится два одинаковых случайных числа.");
        }

        private void ExitClick(object sender, RoutedEventArgs e)//кнопка выхода
        {
            this.Close();
        }

        private void ChetClick(object sender, RoutedEventArgs e)//кнопка расчёта
        {
            CLasspr1.GenerateNumber(out Ch, out Zn);//используем функцию из библиотеки
            tbch.Text = Ch; tbrez.Text = Zn;//переносим данные из переменных в текстбоксы
        }

    }
}
