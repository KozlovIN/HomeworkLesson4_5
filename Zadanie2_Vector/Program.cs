using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2_Vector
{
    class Vector

    {
        static void Main(string[] args)
        {
            Coordinats();
            Lenght();
            ScalMul();
            VectMul();
            Angle();
            Sum();
            Dif();
        }

        static void Coordinats()
        {
            var a = new XYZ1();
            a.PublicMethod1();
        }

        static void Lenght()
        {
            var a = new XYZ2();
            a.PublicMethod1();
            int ax1 = a.x1;
            int ay1 = a.y1;
            int az1 = a.z1;
            double lenght = Lenght1(ax1, ay1, az1);
            string s1 = string.Empty;
            Console.WriteLine(s1);
            Console.WriteLine("Длина вектора А = " + lenght);
        }




        static void ScalMul()
        {
            var a = new XYZ3();
            a.PublicMethod2();
            Console.ReadLine();
            int ax1 = a.x1;
            int ax2 = a.x2;
            int ay1 = a.y1;
            int ay2 = a.y2;
            int az1 = a.z1;
            int az2 = a.z2;
            Console.WriteLine($"Координаты вектора B = ({a.x2}, {a.y2}, {a.z2})");
            int scalMul = Scal(ax1, ax2, ay1, ay2, az1, az2);
            string s1 = string.Empty;
            Console.WriteLine(s1);
            Console.WriteLine("Скалярное произведение веторов А и В = " + scalMul);

        }
        static void VectMul()
        {
            var a = new XYZ3();
            a.PublicMethod2();

            int vectMul1 = ((a.y1 * a.z2) - (a.z1 * a.y2));
            int vectMul2 = ((a.z1 * a.x2) - (a.x1 * a.z2));
            int vectMul3 = ((a.x1 * a.y2) - (a.y1 * a.x2));
            Console.WriteLine($"Векторное произведение веторов А и В = ({vectMul1}, {vectMul2}, {vectMul3})");
        }

        static void Angle()
        {
            var a = new XYZ3();
            a.PublicMethod2();

            int ax1 = a.x1;
            int ax2 = a.x2;
            int ay1 = a.y1;
            int ay2 = a.y2;
            int az1 = a.z1;
            int az2 = a.z2;

            double angle = Scal(ax1, ax2, ay1, ay2, az1, az2) / (Lenght1(ax1, ay1, az1) * Lenght2(ax2, ay2, az2));

            Console.WriteLine($"Косинус угла между векторами А и В = " + angle);
        }

        static void Sum()
        {
            var a = new XYZ3();
            a.PublicMethod2();

            int sumX = a.x1 + a.x2;
            int sumY = a.y1 + a.y2;
            int sumZ = a.z1 + a.z2;

            Console.WriteLine($"Сумма веторов А и В = ({sumX}, {sumY}, {sumZ})");
        }

        static void Dif()
        {
            var a = new XYZ3();
            a.PublicMethod2();

            int difX = a.x1 - a.x2;
            int difY = a.y1 - a.y2;
            int difZ = a.z1 - a.z2;

            Console.WriteLine($"Разность веторов А и В = ({difX}, {difY}, {difZ})");
        }

        static int Scal(int ax1, int ax2, int ay1, int ay2, int az1, int az2)
        {
            var a = new XYZ3();
            a.PublicMethod2();

            int scal = ((a.x1 * a.x2) + (a.y1 * a.y2) + (a.z1 * a.z2));
            return scal;
        }


        static double Lenght1(int ax1, int ay1, int az1)
        {
            var a = new XYZ3();
            a.PublicMethod2();

            double lenght1 = Math.Sqrt((a.x1 * a.x1) + (a.y1 * a.y1) + (a.z1 * a.z1));
            return lenght1;
        }

        static double Lenght2(int ax2, int ay2, int az2)
        {
            var a = new XYZ3();
            a.PublicMethod2();

            double lenght2 = Math.Sqrt((a.x2 * a.x2) + (a.y2 * a.y2) + (a.z2 * a.z2));
            return lenght2;
        }
    }
}
