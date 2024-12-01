using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presso
{
    public class RefInAsync
    {
        public RefInAsync()
        {

        }

        //https://okyrylchuk.dev/blog/whats-new-in-charp13/
        public async Task AsyncMethod()
        {
            await Task.Delay(1000);
            ReadOnlySpan<char> span = "Hello, World";
            // do something with span
        }
    }
}
