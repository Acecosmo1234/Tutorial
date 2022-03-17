using System;


namespace project1
{
   //public class Program
   // {
   //     static void (string[] args)
   //     {
            
   //     }

        public class FourSideGeometricFigure
        {
            private string nm;
            private double bs;
            private double hg;

            public string Name
            {
                get { return nm; }
                set { nm = value; }
            }

            public double Base
            {
                get { return bs; }
                set { bs = value; }
            }

            public double Height
            {
                get { return hg; }
                set { hg = value; }
            }

            public double Area
            {
                get { return bs * hg; }
            }

            public override string ToString()
            {
                string result = "Type:   " + nm + "\n" +
                                "Base:   " + bs.ToString() + "\n" +
                                "Height: " + hg.ToString() + "\n" +
                                "Area:   " + Area.ToString();
                return result;
            }
        }

        public class Generator<TypeOfValue>
        {
            public void Show(TypeOfValue val)
            {
                Console.WriteLine("{0}\n", val.ToString());
            }
        }
        public class Exercise
        {
            static int Main()
            {
                var sqr = new FourSideGeometricFigure();
                sqr.Name = "Square";
                sqr.Base = 36.82;
                sqr.Height = 36.82;
                Generator<FourSideGeometricFigure> exoSquare =
                        new Generator<FourSideGeometricFigure>();
                exoSquare.Show(sqr);

                FourSideGeometricFigure rect = new FourSideGeometricFigure();
                rect.Name = "Rectangle";
                rect.Base = 52.94;
                rect.Height = 27.58;

                Generator<FourSideGeometricFigure> exoRect =
                        new Generator<FourSideGeometricFigure>();
                exoRect.Show(rect);
                return 0;
            }
        }
    }




