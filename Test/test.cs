using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public abstract class test
    {
        public abstract void Test1();

        public void Test2() { Console.WriteLine("this is test base class, Test2"); }

        public virtual void test3() { }

    }
}
