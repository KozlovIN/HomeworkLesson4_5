using System;

namespace Zadanie1_Point
{
    class Point
    {
        public string Name { get; }
        public int X { get; }
        public int Y { get; }

        public Point(string name, int x, int y)
        {
            Name = name;
            X = x;
            Y = y;
        }
    }

    class Polygon
    {
        public double a1;
        public double a2;
        public double a3;
        public double a4;
        public double a5;

        public string name1;
        public string name2;
        public string name3;
        public string name4;
        public string name5;

        public int px1;
        public int py1;
        public int px2;
        public int py2;
        public int px3;
        public int py3;
        public int px4;
        public int py4;
        public int px5;
        public int py5;

        public Polygon()
        {
            var p1 = new Point("A", 3, 1);

            var p2 = new Point("B", 1, 6);

            var p3 = new Point("C", 5, 13);

            var p4 = new Point("D", 14, 10);

            var p5 = new Point("E", 11, 3);

            name1 = p1.Name;
            name2 = p2.Name;
            name3 = p3.Name;
            name4 = p4.Name;
            name5 = p5.Name;
            px1 = p1.X;
            py1 = p1.Y;
            px2 = p2.X;
            py2 = p2.Y;
            px3 = p3.X;
            py3 = p3.Y;
            px4 = p4.X;
            py4 = p4.Y;
            px5 = p5.X;
            py5 = p5.Y;
        }
        public void Perimeter()
        {
            Console.WriteLine($"Точка:{name1}  X={px1} Y={py1}");
            Console.WriteLine($"Точка:{name2}  X={px2} Y={py2}");
            Console.WriteLine($"Точка:{name3}  X={px3} Y={py3}");
            Console.WriteLine($"Точка:{name4}  X={px4} Y={py4}");
            Console.WriteLine($"Точка:{name5}  X={px5} Y={py5}");

            string s1 = string.Empty;
            Console.WriteLine(s1);

            var d = new Polygon();

            d.a1 = Math.Sqrt((d.px2 - d.px1) * (d.px2 - d.px1) + (d.py2 - d.py1) * (d.py2 - d.py1));
            Console.WriteLine($"Длина стороны 1 = {d.a1}");

            d.a2 = Math.Sqrt((d.px3 - d.px2) * (d.px3 - d.px2) + (d.py3 - d.py2) * (d.py3 - d.py2));
            Console.WriteLine($"Длина стороны 2 = {d.a2}");

            d.a3 = Math.Sqrt((d.px4 - d.px3) * (d.px4 - d.px3) + (d.py4 - d.py3) * (d.py4 - d.py3));
            Console.WriteLine($"Длина стороны 3 = {d.a3}");

            d.a4 = Math.Sqrt((d.px5 - d.px4) * (d.px5 - d.px4) + (d.py5 - d.py4) * (d.py5 - d.py4));
            Console.WriteLine($"Длина стороны 4 = {d.a4}");

            d.a5 = Math.Sqrt((d.px1 - d.px5) * (d.px1 - d.px5) + (d.py1 - d.py5) * (d.py1 - d.py5));
            Console.WriteLine($"Длина стороны 5 = {d.a5}");

            string s2 = string.Empty;
            Console.WriteLine(s2);


            double perimeter = d.a1 + d.a2 + d.a3 + d.a4 + d.a5;
            Console.WriteLine("Периметр многоугольника = " + perimeter);

        }
    }

    class Program
    {
        static void Main(string[] arg)
        {
            var polygon1 = new Polygon();
            polygon1.Perimeter();
        }

    }

}
