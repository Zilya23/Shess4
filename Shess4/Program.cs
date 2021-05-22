//Шагиахметова Зиля 220п
//Шахматы-3
using System;

class Program
{
    static void Main()
    {
        string chess = Console.ReadLine();
        Chess f1;
        bool move = false;

        switch (chess)
        {
            case "K":
                f1 = new King(1, 1);
                move = f1.RightMove(1, 2);
                break;
            case "Q":
                f1 = new Queen(1, 1);
                move = f1.RightMove(4, 1);
                break;
            case "B":
                f1 = new Bishop(1, 1);
                move = f1.RightMove(4, 4);
                break;
            case "N":
                f1 = new Knight(1, 1);
                move = f1.RightMove(3, 2);
                break;
            case "R":
                f1 = new Rook(1, 1);
                move = f1.RightMove(1, 6);
                break;
            case "P":
                f1 = new Pawn(1, 1);
                move = f1.RightMove(1, 2);
                break;

            default:
                Console.WriteLine("Unknown piece code. Try again.");
                break;
        }

        Console.WriteLine(move ? "YES" : "NO");
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