using System;

namespace Fig_Square
{
    abstract class Figura
    {
        public static double s;
        public string[] namefig;
        public string[] Namefig
        {
            get { return namefig; }
            set { namefig = value; }
        }
        public Figura(string str1, string str2, string str3)
        {
            str1 = "circle";
            str2 = "triangle";
            str3 = "square";
            string[] namefig = new string[] { str1, str2, str3 };
            Namefig = namefig;

        }
        public abstract double SquareFig(double t);

    }

        class Square : Figura
        {
            public string fld { get; set; }//поле
            public Square(string str1, string str2, string str3)
                : base(str1, str2, str3)
            {
                fld = namefig[2];
            }
            public override double SquareFig(double s)
            {
                double a = 4;

                if (fld == namefig[2])
                {
                    s = a * a;
                }
                return s;
            }
            //S = 3.14 *R*2 = krug
        }
        class Triangle : Figura
        {
            public string fld { get; set; }
            public Triangle(string str1, string str2, string str3)
                : base(str1, str2, str3)
            {
                fld = namefig[1];
            }
            public override double SquareFig(double s)
            {
                int a = 4;
                int h = 5;
                if (fld == namefig[1])
                {
                    s = 0.5 * a * h;
                }

                return s;
            }
        }
        class Circle : Figura
        {
            public string fld { get; set; }
            public Circle(string str1, string str2, string str3)
                : base(str1, str2, str3)
            {
                fld = namefig[0];
            }
            public override double SquareFig(double s)
            {
                int r = 4;
                double a = 3.14;
                if (fld == namefig[0])
                {
                    s = a * r * 2;
                }
                return s;
            }

            class Calculation : Circle
            {
                public Calculation(string str1, string str2, string str3)
                    : base(str1, str2, str3)
                {
                    Namefig = namefig;
                }

                //static void Main(string[] args)
                //{

                //    Circle r = new Circle("", "", "");
                //    Triangle f = new Triangle("", "", "");
                //    Console.WriteLine(r.SquareFig(s));
                //    Console.WriteLine(f.SquareFig(s));
                //    Console.ReadKey();
                //}
            }
        }
    //}
}
