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

namespace Chess4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public Window2 Window2;
        public Window1 Window1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnKing_Click(object sender, RoutedEventArgs e)
        {
            Window2 = new Window2();
            Window2.Show();
        }

        private void btnX0Y0_Click(object sender, RoutedEventArgs e)
        {
            //cont = " ";

            Window1 = new Window1();

            Window1.Owner = this;

            Window1.Show();

            btnX0Y0.FontSize = 24;
            btnX0Y0.Content = "K";
        }
    }
}
