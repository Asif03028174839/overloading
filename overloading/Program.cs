using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program

    {

        void sum (int a , int b)
        {
            Console.WriteLine(a + b);
        }



        void sum (float a , float b)
        {
            Console.WriteLine(a + b);
        }
       

        static void Main(string[] args)
        {

            Program obj = new Program();
            obj.sum(20.4f, 30.5f);
            Console.ReadLine();
            

        }
    }
}
