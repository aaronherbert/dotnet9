using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presso
{
    internal class ImplicitIndexAccess
    {
        public ImplicitIndexAccess()
        {
            var greeter = new Greeter { Message = { [^1] = '!' } };
            Console.WriteLine(greeter);

            //before
            //var greeter = new Greeter();
            //greeter.Message[^1] = '!';

        }

    }

    class Greeter
    {
        public char[] Message { get; set; } = "Hello?".ToCharArray();
    }
}
