using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample
{
    delegate void PrintDelegate();


    class SuperClass
    {
        int a;
        int b;

        public int PrintOK(this)
        {
            return (this.a + this.b);
       
        }
    }


    class SimpleClass
    {
        public int a;
        public int b;
        public PrintDelegate pd;
        public int PrintOK()
        {
            pd.Invoke(this);
            return 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            SuperClass c = new SuperClass();
            SimpleClass s = new SimpleClass();
            s.a = 6;
            s.b = 3;
            s.pd = c.PrintOK(this);
            s.PrintOK(this);
        }
    }
}