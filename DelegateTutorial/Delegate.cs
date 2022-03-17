using System;

namespace DelegateTutorial
{

    
    class Delegate
    {
        public delegate void Simple();
        public delegate int Calculator(int x, int y);
        public delegate void FirstDelegate();
        static void Main(string[] args)
        {
            //Annonymous Delegate
            Simple msg = delegate ()
            {
                Console.WriteLine("Welcome to the wonderful world of c# programming!");
            };
            //To acesss the delegate
            msg();
            //using lambda expression
            Simple msg2 = () =>
            {
                Console.WriteLine("Welcome to the wonderful world of c# programming!~ lamda");
            };
            msg2();

            Console.WriteLine("==================================");
            Console.WriteLine("==================================");

            Calculator c = new Calculator(Delegate.Addition);
            Console.WriteLine(c(10, 5));

            Calculator d = new Calculator(Delegate.Division);
            Console.WriteLine(d(10, 5));

            Calculator e = new Calculator(Delegate.Multiplication);
            Console.WriteLine(e(10, 5));

            Console.WriteLine("==================================");
            Console.WriteLine("==================================");

            Delegate p = new Delegate();
            Delegate.FirstDelegate fd1 = new Delegate.FirstDelegate(p.Fun1);
            Delegate.FirstDelegate fd2 = new Delegate.FirstDelegate(p.Fun2);
            Delegate.FirstDelegate fd3 = new Delegate.FirstDelegate(p.Fun3);

            fd1();
            fd2();
            fd3();
        }

        public void Fun1()
        {
            Console.WriteLine("I am function 1");
        }
        public void Fun2()
        {
            Console.WriteLine("I am function 2");
        }
        public void Fun3()
        {
            Console.WriteLine("I am function 3");
        }
        static int Addition(int a, int b)
        {
            return a + b;
        }
        static int Division(int a, int b)
        {
            return a / b;
        }
        static int Multiplication(int a, int b)
        {
            return a * b;
        }
    }
}
