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

        protected void method4()
        {
            Console.WriteLine("ini method 4");
        }

        class AnakClassOutside: ContohModifier
        {
            public static void Main(string[] args)
            {
                AnakClassOutside anakDariLuar = new AnakClassOutside();
                anakDariLuar.method1();
                anakDariLuar.method2();
                anakDariLuar.method3();
                anakDariLuar.method4();
                Console.ReadKey();
            }
        }
    }
}
