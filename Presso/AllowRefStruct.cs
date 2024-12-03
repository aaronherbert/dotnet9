using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WhatsNew
{
    public class AllowRefStruct
    {
        public AllowRefStruct()
        {
            //https://github.com/search?q=org%3Adotnet++%22allows+ref+struct%22&type=code&p=3
            var str = "icle";
            var s = new Span<string>(ref str);
            var x = new C<Span<string>>();
            x.M(s);
        }

        public class C<T> where T : allows ref struct
        {
            // Use T as a ref struct:
            public void M(scoped T p)
            {
                // The parameter p must follow ref safety rules
            }
        }
        class Foo<T> where T : allows ref struct { }

        class Boo<T> { }

        class Example<T> where T : allows ref struct
        {
            private Foo<T> _foo; // allowed
            //private Boo<T> _boo; // disallowed
        }
    }
}
