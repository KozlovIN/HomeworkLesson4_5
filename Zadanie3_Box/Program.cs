using System;

namespace Zadanie3_Box
{

    public abstract class Shape
    {
        public abstract double volume { get; set; }
        public abstract void Volume();
    
    }

    class Box : Shape
    {
        public override double volume { get; set; }
        public override void Volume()
        {
            int h = 10;
            volume = h * h * h;
            Console.WriteLine($"Объем контейнера Вох = {volume}");
        }

    }


    class Cylinder : Shape
    {
        public override double volume { get; set; }
        public override void Volume()
        {
            int h = 5;
            int r = 3;
            volume = 3.14 * r * r * h;
            Console.WriteLine($"Объем цилиндра = {volume}");
        }
    }

    class Pyramid : Shape
    {
        public override double volume { get; set; }
        public override void Volume()
        {
            int l = 10;
            int h = 10;
            volume = l * l * h / 3;
            Console.WriteLine($"Объем пирамиды = {volume}");
        }
    }


    class Ball : Shape
    {
        public override double volume { get; set; }
        public override void Volume()
        {
            int r = 5;
            volume = 3.14 * r * r * r * 4 / 3;
            Console.WriteLine($"Объем шара = {volume}");
        }
    }

    class Add
    {
        public void Add1(Shape v1)
        {
            v1.Volume();


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            WorkingWithFigures();
        }

        static void WorkingWithFigures()
        {

            var zap = new Add();
            var box = new Box();
            var cil = new Cylinder();
            var pyr = new Pyramid();
            var bal = new Ball();

            zap.Add1(box);

            string s1 = string.Empty;
            Console.WriteLine(s1);

            zap.Add1(cil);
            zap.Add1(pyr);
            zap.Add1(bal);

            Console.WriteLine(s1);

            double sum = cil.volume + pyr.volume + bal.volume;

            Console.WriteLine("Объем заполнения контейнера Box другими фигурами = " + sum);

            Console.WriteLine(s1);

            if (sum < box.volume)
            {
                Console.WriteLine("Контейнер Box до конца не заполнен ");
            }
            else
            {
                Console.WriteLine("Контейнер Box переполнен ");
            }
        }
    }
}
