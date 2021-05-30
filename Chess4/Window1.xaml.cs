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

namespace Chess4
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {

            int X1 = 1;
            int Y1 = 1;

            string fig = tbFig.Text;
            string SX1 = tbX.Text;
            string SY1 = tbY.Text;

            int X2 = Convert.ToInt32(SX1);
            int Y2 = Convert.ToInt32(SY1);

            //this.Owner.cont = fig;


        }
    }
}
