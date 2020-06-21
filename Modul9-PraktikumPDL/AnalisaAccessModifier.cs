using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace modul9ibnuu
{
    class ContohModifier
    {
        void method1()
        {
            Console.WriteLine("ini method 1");
        }

        public void method2()
        {
            Console.WriteLine("ini method 2");
        }

        private void method3()
        {
            Console.WriteLine("ini method 3");
        }
    }

    class TestMethod
    {
        static void Main(string[] args)
        {
            ContohModifier contohModifier = new ContohModifier();
            contohModifier.method2();
            Console.ReadKey();
        }
    }
}
