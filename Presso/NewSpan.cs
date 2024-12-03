using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace WhatsNew
{
    public class NewSpan
    {
        public NewSpan()
        {
            var dic = new Dictionary<string, int>
            {
                { "Hello", 1 },
                { " World!", 2 }
            };

            var str = "Hello, World!";
            ReadOnlySpan<char> span = "Hello, World!";

            Console.WriteLine(dic[str.Split(",")[0]]);

            var x = span.Split(',');

            var altDic = dic.GetAlternateLookup<ReadOnlySpan<char>>();

            foreach (var y in x)
            {
                ReadOnlySpan<char> key = span[y];
                Console.WriteLine(altDic[key]);

            }



        }
    }
}
