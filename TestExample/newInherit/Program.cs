using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newInherit
{
    public class A
    {
        public virtual void Write()
        {
            Console.WriteLine("This is A");
        }
    }

    public class B : A
    {
        public override void Write()
        {
            Console.WriteLine("This is B");
        }
    }

    public class C : A
    {
        public new void Write()
        {
            Console.WriteLine("This is C");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A obj1 = new A();
            A obj2 = new B();
            A obj3 = new C();

            obj1.Write();
            obj2.Write();
            obj3.Write();

            Console.ReadKey();
        }
    }
}
