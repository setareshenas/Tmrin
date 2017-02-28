using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class mohasebe
    {
        public int maghloob(int a)
        {
            int s = a;
            int n = 0;
            for (int i = s.ToString().Length; i > 0; i--)
            {
                n = n * 10 + s % 10;
                s /= 10;
            }
            return n;
        }

        public string avval(int a)
        {
            string x = "?";
            for (int i = 2; i <= a; i++)
            {
                if ((a % i) == 0)
                {
                    x = "Adad avval nist";
                    break;
                }
                else
                { 
                    x = "Adad avval ast";
                }
            }
            return x;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            int v;
            Console.WriteLine("hello \n");
            Console.WriteLine("Please enter your section: \n 1) maghloobe yek adad. \n 2) Avval budane yek adad: \n");
            v = int.Parse(Console.ReadLine());
            if (v == 1)
            {
                int x;
                int y;
                mohasebe objmagh = new mohasebe();
                Console.Write("Enter your number \n");
                x = int.Parse(Console.ReadLine());
                y = objmagh.maghloob(x);
                Console.Write(y);
                Console.ReadLine();
            }
            else
            {
                int b;
                string c;
                mohasebe objav = new mohasebe();
                Console.WriteLine("Enter A Number:");
                b = Convert.ToInt32(Console.ReadLine());
                c = objav.avval(b);
                Console.Write(c);
                Console.ReadKey();
            }

        }
    }
}
