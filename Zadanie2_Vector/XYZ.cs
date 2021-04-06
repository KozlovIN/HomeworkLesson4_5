using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2_Vector
{
    public class XYZ1
    {
        public int x1;
        public int y1;
        public int z1;


        public virtual void PublicMethod1()
        {
            x1 = 5;
            y1 = 6;
            z1 = 7;
            Console.WriteLine($"Координаты вектора А = ({x1}, {y1}, {z1})");
        }
    }

    public class XYZ2 : XYZ1
    {
        public override void PublicMethod1()
        {
            x1 = 5;
            y1 = 6;
            z1 = 7;
        }
    }

    public class XYZ3 : XYZ2
    {
        public int x2;
        public int y2;
        public int z2;

        public void PublicMethod2()
        {
            PublicMethod1();
            x2 = 8;
            y2 = 9;
            z2 = 1;

        }
    }
}
