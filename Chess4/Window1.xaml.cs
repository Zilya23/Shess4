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
        public MainWindow MainWindow;

        public string figura;
        
        public Window1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {

            figura = tbFig.Text;
            /*
            //this.MainWindow.X1;
            int X1 = 1;
             int Y1 = 1;

            string fig = tbFig.Text;
            string SX1 = tbX.Text;
            string SY1 = tbY.Text;

            int X2 = Convert.ToInt32(SX1);
            int Y2 = Convert.ToInt32(SY1);

            Chess f2;
            bool move = false;

            switch (fig)
            {
                case "K":
                    f2 = new King(X1, Y1);
                    move = f2.RightMove(X2, Y2);
                    break;
                case "Q":
                    f2 = new Queen(X1, Y1);
                    move = f2.RightMove(X2, Y2);
                    break;
                case "B":
                    f2 = new Bishop(X1, Y1);
                    move = f2.RightMove(X2, Y2);
                    break;
                case "N":
                    f2 = new Knight(X1, Y1);
                    move = f2.RightMove(X2, Y2);
                    break;
                case "R":
                    f2 = new Rook(X1, Y1);
                    move = f2.RightMove(X2, Y2);
                    break;
                case "P":
                    f2 = new Pawn(X1, Y1);
                    move = f2.RightMove(X2, Y2);
                    break;

                default:
                    MessageBox.Show("Unknown piece code. Try again.");
                    break;
            }

            MessageBox.Show(move ? "YES" : "NO");
            */
        }
        

    }
}
