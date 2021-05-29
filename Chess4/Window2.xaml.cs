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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            string fig = tbFig.Text;
            string SX1 = tbX1.Text;
            string SY1 = tbY1.Text;
            string SX2 = tbX2.Text;
            string SY2 = tbY2.Text;
            //MessageBox.Show(fig);

            int X1 = Convert.ToInt32(SX1);
            int Y1 = Convert.ToInt32(SY1);
            int X2 = Convert.ToInt32(SX2);
            int Y2 = Convert.ToInt32(SY2);

            Chess f1;
            bool move = false;

            switch (fig)
            {
                case "K":
                    f1 = new King(X1, Y1);
                    move = f1.RightMove(X2, Y2);
                    break;
                case "Q":
                    f1 = new Queen(X1, Y1);
                    move = f1.RightMove(X2, Y2);
                    break;
                case "B":
                    f1 = new Bishop(X1, Y1);
                    move = f1.RightMove(X2, Y2);
                    break;
                case "N":
                    f1 = new Knight(X1, Y1);
                    move = f1.RightMove(X2, Y2);
                    break;
                case "R":
                    f1 = new Rook(X1, Y1);
                    move = f1.RightMove(X2, Y2);
                    break;
                case "P":
                    f1 = new Pawn(X1, Y1);
                    move = f1.RightMove(X2, Y2);
                    break;

                default:
                    MessageBox.Show("Unknown piece code. Try again.");
                    break;
            }

            MessageBox.Show(move ? "YES" : "NO");
        }
    }

    public class Chess
    {
        protected int x1;
        protected int y1;
        protected string chess;

        public Chess(int a, int b)
        {
            x1 = a;
            y1 = b;
        }

        public virtual bool RightMove(int x2, int y2)
        {
            return false;
        }
    }

    public class King : Chess
    {
        public King(int x1, int y1) : base(x1, y1)
        {
        }

        public override bool RightMove(int x2, int y2)
        {
            return (Math.Abs(x1 - x2) <= 1 && Math.Abs(y1 - y2) <= 1);
        }
    }

    public class Queen : Chess
    {
        public Queen(int x1, int y1) : base(x1, y1)
        {
        }

        public override bool RightMove(int x2, int y2)
        {
            return (x1 == x2 || y1 == y2 ||
                Math.Abs(x1 - x2) == Math.Abs(y1 - y2));
        }
    }

    public class Bishop : Chess
    {
        public Bishop(int x1, int y1) : base(x1, y1)
        {
        }

        public override bool RightMove(int x2, int y2)
        {
            return (Math.Abs(x1 - x2) == Math.Abs(y1 - y2));
        }
    }

    public class Knight : Chess
    {
        public Knight(int x1, int y1) : base(x1, y1)
        {
        }

        public override bool RightMove(int x2, int y2)
        {
            return ((Math.Abs(x1 - x2) == 2 && Math.Abs(y1 - y2) == 1) ||
                    (Math.Abs(x1 - x2) == 1 && Math.Abs(y1 - y2) == 2));
        }
    }

    public class Rook : Chess
    {
        public Rook(int x1, int y1) : base(x1, y1)
        {
        }

        public override bool RightMove(int x2, int y2)
        {
            return (x1 == x2 || y1 == y2);
        }
    }

    public class Pawn : Chess
    {
        public Pawn(int x1, int y1) : base(x1, y1)
        {
        }

        public override bool RightMove(int x2, int y2)
        {
            return ((x1 == x2 && y1 == 2 && y1 + 2 >= y2) ||
                    (x1 == x2 && y1 + 1 == y2));
        }
    }
}
