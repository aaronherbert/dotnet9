using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presso
{
    public class RefStruct
    {/*C# 13 allows for ref struct to implement interfaces.

However, you cannot convert the ref struct type to an interface (line 3 in the example below) because it’s a boxing conversion, which is forbidden by ref safety. Also, you cannot declare methods explicitly implementing an interface method in the ref struct. */

        //https://okyrylchuk.dev/blog/whats-new-in-charp13/
        public RefStruct()
        {
            Foo foo = new Foo();

            //var _ = (IFoo)foo; /nope
        }

    }
    interface IFoo
    { }

    ref struct Foo : IFoo
    { }
}
