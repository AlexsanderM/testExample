using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExample
{
    public class Class1
    {
        public Class1()
        {
            Console.WriteLine("This is Class1");
        }
    }

    class Class2 : Class1
    {
        public Class2()
        {
            Console.WriteLine("This is Class2");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Class2 class2 = new Class2();
            Console.ReadKey();
        }
    }
}
