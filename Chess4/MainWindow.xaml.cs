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
        public int X1;
        public int Y1;
        public int X2;
        public int Y2;
        public string fig;
        public int chet = 0;
        public int index;

        public MainWindow()
        {
            InitializeComponent();

            lbPiece.Items.Add("King");
            lbPiece.Items.Add("Queen");
            lbPiece.Items.Add("Knight");
            lbPiece.Items.Add("Bishop");
            lbPiece.Items.Add("Rook");
            lbPiece.Items.Add("Pawn");
        }

        private void btnKing_Click(object sender, RoutedEventArgs e)
        {
            chet = 0;
            btnX0Y0.Content = " ";
            btnX1Y0.Content = " ";
            btnX2Y0.Content = " ";
            btnX3Y0.Content = " ";
            btnX4Y0.Content = " ";
            btnX5Y0.Content = " ";
            btnX6Y0.Content = " ";
            btnX7Y0.Content = " ";
            btnX0Y1.Content = " ";
            btnX1Y1.Content = " ";
            btnX2Y1.Content = " ";
            btnX3Y1.Content = " ";
            btnX4Y1.Content = " ";
            btnX5Y1.Content = " ";
            btnX6Y1.Content = " ";
            btnX7Y1.Content = " ";
            btnX0Y2.Content = " ";
            btnX1Y2.Content = " ";
            btnX2Y2.Content = " ";
            btnX3Y2.Content = " ";
            btnX4Y2.Content = " ";
            btnX5Y2.Content = " ";
            btnX6Y2.Content = " ";
            btnX6Y2.Content = " ";
            btnX7Y2.Content = " ";
            btnX0Y3.Content = " ";
            btnX1Y3.Content = " ";
            btnX2Y3.Content = " ";
            btnX3Y3.Content = " ";
            btnX4Y3.Content = " ";
            btnX5Y3.Content = " ";
            btnX6Y3.Content = " ";
            btnX7Y3.Content = " ";
            btnX0Y4.Content = " ";
            btnX1Y4.Content = " ";
            btnX2Y4.Content = " ";
            btnX3Y4.Content = " ";
            btnX4Y4.Content = " ";
            btnX5Y4.Content = " ";
            btnX6Y4.Content = " ";
            btnX7Y4.Content = " ";
            btnX0Y5.Content = " ";
            btnX1Y5.Content = " ";
            btnX2Y5.Content = " ";
            btnX3Y5.Content = " ";
            btnX4Y5.Content = " ";
            btnX5Y5.Content = " ";
            btnX6Y5.Content = " ";
            btnX7Y5.Content = " ";
            btnX0Y6.Content = " ";
            btnX1Y6.Content = " ";
            btnX2Y6.Content = " ";
            btnX3Y6.Content = " ";
            btnX4Y6.Content = " ";
            btnX5Y6.Content = " ";
            btnX6Y6.Content = " ";
            btnX7Y6.Content = " ";
            btnX0Y7.Content = " ";
            btnX1Y7.Content = " ";
            btnX2Y7.Content = " ";
            btnX3Y7.Content = " ";
            btnX4Y7.Content = " ";
            btnX5Y7.Content = " ";
            btnX6Y7.Content = " ";
            btnX7Y7.Content = " ";
        }

        private void btnX0Y0_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 1;
                Y1 = 1;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX0Y0.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 1;
                Y2 = 1;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX0Y0.Content = move;
            }
        }

        private void btnX1Y0_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 2;
                Y1 = 1;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX1Y0.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 2;
                Y2 = 1;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX1Y0.Content = move;
            }
        }

        private void tbnX2Y0_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 3;
                Y1 = 1;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX2Y0.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 3;
                Y2 = 1;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX2Y0.Content = move;
            }
        }

        private void btnX3Y0_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 4;
                Y1 = 1;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX3Y0.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 4;
                Y2 = 1;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX3Y0.Content = move;
            }
        }

        private void btnX4Y0_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 5;
                Y1 = 1;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX4Y0.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 5;
                Y2 = 1;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX4Y0.Content = move;
            }
        }

        private void btnX5Y0_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 6;
                Y1 = 1;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX5Y0.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 6;
                Y2 = 1;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX5Y0.Content = move;
            }
        }

        private void btnX6Y0_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 7;
                Y1 = 1;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX6Y0.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 7;
                Y2 = 1;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX6Y0.Content = move;
            }
        }

        private void btnX7Y0_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 8;
                Y1 = 1;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX7Y0.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 8;
                Y2 = 1;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX7Y0.Content = move;
            }
        }

        private void btnX0Y1_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 1;
                Y1 = 2;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX0Y1.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 2;
                Y2 = 1;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX0Y1.Content = move;
            }
        }

        private void btnX1Y1_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 2;
                Y1 = 2;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX1Y1.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 2;
                Y2 = 2;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX1Y1.Content = move;
            }
        }

        private void btnX2Y1_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 3;
                Y1 = 2;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX2Y1.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 3;
                Y2 = 2;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX2Y1.Content = move;
            }
        }

        private void btnX3Y1_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 4;
                Y1 = 2;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX3Y1.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 4;
                Y2 = 2;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX3Y1.Content = move;
            }
        }

        private void btnX4Y1_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 5;
                Y1 = 2;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX4Y1.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 5;
                Y2 = 2;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX4Y1.Content = move;
            }
        }

        private void btnX5Y1_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 6;
                Y1 = 2;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX5Y1.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 6;
                Y2 = 2;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX5Y1.Content = move;
            }
        }

        private void btnX6Y1_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 7;
                Y1 = 2;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX6Y1.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 7;
                Y2 = 2;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX6Y1.Content = move;
            }
        }

        private void btnX7Y1_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 8;
                Y1 = 2;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX7Y1.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 8;
                Y2 = 2;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX7Y1.Content = move;
            }
        }

        private void btnX0Y2_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 1;
                Y1 = 3;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX0Y2.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 1;
                Y2 = 3;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX0Y2.Content = move;
            }
        }

        private void btnX1Y2_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 2;
                Y1 = 3;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX1Y2.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 2;
                Y2 = 3;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX1Y2.Content = move;
            }
        }

        private void btnX2Y2_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 3;
                Y1 = 3;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX2Y2.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 3;
                Y2 = 3;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX2Y2.Content = move;
            }
        }

        private void btnX3Y2_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 4;
                Y1 = 3;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX3Y2.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 4;
                Y2 = 3;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX3Y2.Content = move;
            }
        }

        private void btnX4Y2_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 5;
                Y1 = 3;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX4Y2.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 5;
                Y2 = 3;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX4Y2.Content = move;
            }
        }

        private void btnX5Y2_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 6;
                Y1 = 3;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX5Y2.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 6;
                Y2 = 3;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX5Y2.Content = move;
            }
        }

        private void btnX6Y3_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 7;
                Y1 = 3;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX6Y3.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 1;
                Y2 = 3;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX6Y3.Content = move;
            }
        }

        private void btnX7Y2_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 8;
                Y1 = 3;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX7Y2.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 8;
                Y2 = 3;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX7Y2.Content = move;
            }
        }

        private void btnX0Y3_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 1;
                Y1 = 4;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX0Y3.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 1;
                Y2 = 4;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX0Y3.Content = move;
            }
        }

        private void btnX1Y3_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 2;
                Y1 = 4;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX1Y3.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 2;
                Y2 = 4;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX1Y3.Content = move;
            }
        }

        private void btnX2Y3_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 3;
                Y1 = 4;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX2Y3.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 3;
                Y2 = 4;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX2Y3.Content = move;
            }
        }

        private void btnX3Y3_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 4;
                Y1 = 4;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX3Y3.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 4;
                Y2 = 4;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX3Y3.Content = move;
            }
        }

        private void btnX4Y3_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 5;
                Y1 = 4;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX4Y3.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 5;
                Y2 = 4;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX4Y3.Content = move;
            }
        }

        private void btnX5Y3_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 6;
                Y1 = 4;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX5Y3.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 6;
                Y2 = 4;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX5Y3.Content = move;
            }
        }

        private void btnX6Y2_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 7;
                Y1 = 4;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX6Y2.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 7;
                Y2 = 4;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX6Y2.Content = move;
            }
        }

        private void btnX7Y3_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 8;
                Y1 = 4;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX7Y3.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 8;
                Y2 = 4;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX7Y3.Content = move;
            }
        }

        private void btnX0Y4_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 1;
                Y1 = 5;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX0Y4.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 1;
                Y2 = 5;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX0Y4.Content = move;
            }
        }

        private void btnX1Y4_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 2;
                Y1 = 5;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX1Y4.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 2;
                Y2 = 5;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX1Y4.Content = move;
            }
        }

        private void btnX2Y4_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 3;
                Y1 = 5;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX2Y4.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 3;
                Y2 = 5;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX2Y4.Content = move;
            }
        }

        private void btnX3Y4_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 4;
                Y1 = 5;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX3Y4.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 4;
                Y2 = 5;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX3Y4.Content = move;
            }
        }

        private void btnX4Y4_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 5;
                Y1 = 5;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX4Y4.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 5;
                Y2 = 5;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX4Y4.Content = move;
            }
        }

        private void btnX5Y4_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 6;
                Y1 = 5;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX5Y4.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 6;
                Y2 = 5;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX5Y4.Content = move;
            }
        }

        private void btnX6Y4_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 7;
                Y1 = 5;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX6Y4.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 7;
                Y2 = 5;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX6Y4.Content = move;
            }
        }

        private void btnX7Y4_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 8;
                Y1 = 5;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX7Y4.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 8;
                Y2 = 5;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX7Y4.Content = move;
            }
        }

        private void btnX0Y5_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 1;
                Y1 = 6;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX0Y5.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 1;
                Y2 = 6;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX0Y5.Content = move;
            }
        }

        private void btnX1Y5_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 2;
                Y1 = 6;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX1Y5.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 2;
                Y2 = 6;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX1Y5.Content = move;
            }
        }

        private void btnX2Y5_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 3;
                Y1 = 6;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX2Y5.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 3;
                Y2 = 6;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX2Y5.Content = move;
            }
        }

        private void btnX3Y5_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 4;
                Y1 = 6;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX3Y5.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 4;
                Y2 = 6;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX3Y5.Content = move;
            }
        }

        private void btnX4Y5_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 5;
                Y1 = 6;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX4Y5.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 5;
                Y2 = 6;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX4Y5.Content = move;
            }
        }

        private void btnX5Y5_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 6;
                Y1 = 6;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX5Y5.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 6;
                Y2 = 6;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX5Y5.Content = move;
            }
        }

        private void btnX6Y5_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 7;
                Y1 = 6;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX6Y5.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 7;
                Y2 = 6;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX6Y5.Content = move;
            }
        }

        private void btnX7Y5_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 8;
                Y1 = 6;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX7Y5.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 8;
                Y2 = 6;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX7Y5.Content = move;
            }
        }

        private void btnX0Y6_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 1;
                Y1 = 7;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX0Y6.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 1;
                Y2 = 7;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX0Y6.Content = move;
            }
        }

        private void btnX1Y6_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 2;
                Y1 = 7;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX1Y6.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 2;
                Y2 = 7;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX1Y6.Content = move;
            }
        }

        private void btnX2Y6_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 3;
                Y1 = 7;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX2Y6.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 3;
                Y2 = 7;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX2Y6.Content = move;
            }
        }

        private void btnX3Y6_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 4;
                Y1 = 7;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX3Y6.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 4;
                Y2 = 7;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX3Y6.Content = move;
            }
        }

        private void btnX4Y6_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 5;
                Y1 = 7;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX4Y6.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 5;
                Y2 = 7;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX4Y6.Content = move;
            }
        }

        private void btnX5Y6_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 6;
                Y1 = 7;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX5Y6.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 6;
                Y2 = 7;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX5Y6.Content = move;
            }
        }

        private void btnX6Y6_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 7;
                Y1 = 7;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX6Y6.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 7;
                Y2 = 7;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX6Y6.Content = move;
            }
        }

        private void btnX7Y6_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 8;
                Y1 = 7;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX7Y6.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 8;
                Y2 = 7;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX7Y6.Content = move;
            }
        }

        private void btnX0Y7_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 1;
                Y1 = 8;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX0Y7.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 1;
                Y2 = 8;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX0Y7.Content = move;
            }
        }

        private void btnX1Y7_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 2;
                Y1 = 8;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX1Y7.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 2;
                Y2 = 8;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX1Y7.Content = move;
            }
        }

        private void btnX2Y7_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 3;
                Y1 = 8;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX2Y7.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 3;
                Y2 = 8;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX2Y7.Content = move;
            }
        }

        private void btnX3Y7_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 4;
                Y1 = 8;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX3Y7.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 4;
                Y2 = 8;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX3Y7.Content = move;
            }
        }

        private void btnX4Y7_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 5;
                Y1 = 8;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX4Y7.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 5;
                Y2 = 8;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX4Y7.Content = move;
            }
        }

        private void btnX5Y7_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 6;
                Y1 = 8;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX5Y7.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 6;
                Y2 = 8;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX5Y7.Content = move;
            }
        }

        private void btnX6Y7_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 7;
                Y1 = 8;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX6Y7.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 7;
                Y2 = 8;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX6Y7.Content = move;
            }
        }

        private void btnX7Y7_Click(object sender, RoutedEventArgs e)
        {
            if (chet == 0)
            {
                X1 = 8;
                Y1 = 8;
                chet = 1;
                index = lbPiece.SelectedIndex;
                fig = (string)lbPiece.Items[index];
                btnX7Y7.Content = fig;

            }
            else if (chet == 1)
            {
                X2 = 8;
                Y2 = 8;
                chet = 2;
                Chess f1;
                bool move = false;

                switch (fig)
                {
                    case "King":
                        f1 = new King(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Queen":
                        f1 = new Queen(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Bishop":
                        f1 = new Bishop(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Knight":
                        f1 = new Knight(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Rook":
                        f1 = new Rook(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;
                    case "Pawn":
                        f1 = new Pawn(X1, Y1);
                        move = f1.RightMove(X2, Y2);
                        break;

                    default:
                        MessageBox.Show("Unknown piece code. Try again.");
                        break;
                }

                btnX7Y7.Content = move;
            }
        }
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
