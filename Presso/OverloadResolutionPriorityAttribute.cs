using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Presso
{
    public class OverloadResolutionPriorityAttribute

    {
        public OverloadResolutionPriorityAttribute()
        {
            var service = new MyService();

            service.Display("Hello World!");


        }

    }

    public class MyService
    {
        [System.Runtime.CompilerServices.OverloadResolutionPriority(1)]
        public void Display(string chars) =>
            Console.WriteLine(chars.ToUpper());

        [System.Runtime.CompilerServices.OverloadResolutionPriority(3)]
        public void Display(ReadOnlySpan<char> chars) =>
            Console.WriteLine(chars.ToArray());
    }
}
