using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class InhTest : test
    {
        public override void Test1() { string x = ""; x = "this is"; string y = "uesif"; Console.WriteLine( x + y);

            base.Test2();
        }

        public void Test2() {

            base.Test2();
            Console.WriteLine("this is InhTest class, Test2");
            
        }
    }
}
