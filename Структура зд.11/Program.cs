using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*условия решения kx+b=0
     k=0,b=0 решение любой х
    к=0, b!=0 решений нет
    к=! 0  решение по формуле     
     */

namespace Структура_зд._11
{
    internal class LinearEquation
    {
       
        double k;
        double b;

        public LinearEquation ( double k, double b)
        {
            
            this.k = k;
            this.b = b;
        }
        public double K
        {

            get
            {
                return k;
            }
            set
            {
                if (value >= 0)
                    k = value;
                else
                    k = 0;
            }
        }
        public double B
        {
            get { return b; }
            set
            {
                if (value >= 0 )
                    b = value;
                else
                    b = 0;
            }
       
        }

        public double Root()
        {
            var root = -b/k;
            return root;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задайте коэфициент k:");
            double k = double.Parse(Console.ReadLine());
            Console.WriteLine("Задайте коэфициент b:");
            double b = double.Parse(Console.ReadLine());
            
           

            LinearEquation linearEquation = new LinearEquation (k,b);
            Console.WriteLine("Значение X " + linearEquation.Root());
            Console.ReadLine();
        }
    }
}
