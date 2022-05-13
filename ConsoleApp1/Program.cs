using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Child
    {
        public void test()
        {
            Console.WriteLine("Hi I am Navya from test");
            Console.ReadLine();
        }

        private void test1()
        {
            Console.WriteLine("Hi I am Navya from test1");
            Console.ReadLine();
        }

        protected void test2()
        {
            Console.WriteLine("Hi I am Navya from test 2");
            Console.ReadLine();
        }

        internal void test3()
        {
            Console.WriteLine("Hi I am Navya from test 3 internal");
            Console.ReadLine();
        }

        protected internal void test4()
        {
            Console.WriteLine("Hi I am Navya from testn 4 protected internal");
            Console.ReadLine();
        }
    class Program : Child
    { 
       static void Main(string[] args)
        {
            Program obj = new Program();
            obj.test();
            obj.test1();
            obj.test2();
            obj.test3();
            obj.test4();
            Console.ReadLine();  
        }
    }
   
    }
}
