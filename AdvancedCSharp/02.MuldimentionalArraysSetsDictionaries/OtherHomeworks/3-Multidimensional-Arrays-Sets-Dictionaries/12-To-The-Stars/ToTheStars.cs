using System;
using System.Collections.Generic;
using System.Linq;
class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}
class ToTheStars
{
    static bool isTrue = false;
    static void Main()
    {
        var firstStar = Console.ReadLine().Split(' ');
        Point first = new Point { X = int.Parse(firstStar[1]), Y = int.Parse(firstStar[2]) };
        List<Point> firstCoordinates = new List<Point>
        {
            first,
            new Point{ X = first.X + 1, Y = first.Y},
            new Point{ X = first.X - 1, Y = first.Y},
            new Point{ X = first.X, Y = first.Y + 1},
            new Point{ X = first.X, Y = first.Y - 1},
            new Point{ X = first.X + 1, Y = first.Y + 1},
            new Point{ X = first.X - 1, Y = first.Y - 1},
            new Point{ X = first.X + 1, Y = first.Y - 1},
            new Point{ X = first.X - 1, Y = first.Y + 1}
        };
        var secondStar = Console.ReadLine().Split(' ');
        Point second = new Point { X = int.Parse(secondStar[1]), Y = int.Parse(secondStar[2]) };
        List<Point> secondCoordinates = new List<Point>
        {
            second,
            new Point{ X = second.X + 1, Y = second.Y},
            new Point{ X = second.X - 1, Y = second.Y},
            new Point{ X = second.X, Y = second.Y + 1},
            new Point{ X = second.X, Y = second.Y - 1},
            new Point{ X = second.X + 1, Y = second.Y + 1},
            new Point{ X = second.X - 1, Y = second.Y - 1},
            new Point{ X = second.X + 1, Y = second.Y - 1},
            new Point{ X = second.X - 1, Y = second.Y + 1}
        };
        var thirdStar = Console.ReadLine().Split(' ');
        Point third = new Point { X = int.Parse(thirdStar[1]), Y = int.Parse(thirdStar[2]) };
        List<Point> thirdCoordinates = new List<Point>
        {
            second,
            new Point{ X = third.X + 1, Y = third.Y},
            new Point{ X = third.X - 1, Y = third.Y},
            new Point{ X = third.X, Y = third.Y + 1},
            new Point{ X = third.X, Y = third.Y - 1},
            new Point{ X = third.X + 1, Y = third.Y + 1},
            new Point{ X = third.X - 1, Y = third.Y - 1},
            new Point{ X = third.X + 1, Y = third.Y - 1},
            new Point{ X = third.X - 1, Y = third.Y + 1}
        };
        int[] shipCoordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Point ship = new Point { X = shipCoordinates[0], Y = shipCoordinates[1] };
        int moves = int.Parse(Console.ReadLine());
        for (int i = 0; i <= moves; i++)
        {
            SearchPoints(firstStar, firstCoordinates, ship);
            SearchPoints(secondStar, secondCoordinates, ship);
            SearchPoints(thirdStar, thirdCoordinates, ship);
            if (isTrue == false)
            {
                Console.WriteLine("space");
            }
            isTrue = false;
            ship.Y++;
        }
    }

    private static void SearchPoints(string[] firstStar, List<Point> firstCoordinates, Point ship)
    {
        foreach (var point in firstCoordinates)
        {
            if (point.X == ship.X && point.Y == ship.Y)
            {
                Console.WriteLine(firstStar[0].ToLower());
                isTrue = true;
            }
        }
    }
}

