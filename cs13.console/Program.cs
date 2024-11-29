using System.Diagnostics;
using System.Drawing;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

//https://csharp-evolution.com/13.0/field-keyword
namespace cs13.console
{
    internal class Program
    {


        static void Main(string[] args)
        {
            //Character literal escape sequence
            char escape_char = '\e';

            Console.WriteLine((escape_char == (char)0x1b, "...").ToString());
            Console.WriteLine((escape_char == '\u001b', "..."));
            Console.WriteLine((escape_char == '\U0000001b', "..."));
            Console.WriteLine((escape_char == '\x1b', "..."));

            //Field keyword
            Post p = new Post();
            p.Title = "Hello";
            //p.Title = "";


            //implicit-index-access
            var greeter = new Greeter { Message = { [^1] = '!' } };

            //Method group natural type improvements

            //New lock object

            //Allow params to use collections 
            test t = new test();
            t.SquareList8(1, 3, 4, 5);

            var results = SquareList(1, 2, 3, 4, 5);
            // ...


        }

        public class test
        {
            public List<int> SquareList8(params int[] numbers)
                => new List<int>(numbers).ConvertAll(x => y * y);

            public List<int> SquareList(params List<int> numbers)
                => list.ConvertAll(x => y * y);
        }

        partial class PostSerializer
        {
            public partial int BufferSize { get; set; }
        }

        partial class PostSerializer
        {
            const int minBufferSize = 1024;
            private int bufferSize;

            public partial int BufferSize
            {
                get => bufferSize < minBufferSize ? minBufferSize : bufferSize;
                set => bufferSize = value;
            }
        }


        public void Concat<T>(params Span<T> items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write(items[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        class Program
        {
            static void Test1()
            {
                M1(['1', '2', '3']); // IEnumerable<char> overload is used because `char` is an exact match
                M1('1', '2', '3');   // IEnumerable<char> overload is used because `char` is an exact match
            }

            static void M1(params IEnumerable<char> value) { }
            static void M1(params System.ReadOnlySpan<MyChar> value) { }

            class MyChar
            {
                private readonly int _i;
                public MyChar(int i) { _i = i; }
                public static implicit operator MyChar(int i) => new MyChar(i);
                public static implicit operator char(MyChar c) => (char)c._i;
            }

            static void Test2()
            {
                M2([1]); // Span overload is used
                M2(1);   // Array overload is used, not generic
            }

            static void M2<T>(params System.Span<T> y) { }
            static void M2(params int[] y) { }

            static void Test3()
            {
                M3("3", ["4"]); // Ambiguity, better-ness of argument conversions goes in opposite directions.
                M3("3", "4");   // Ambiguity, better-ness of argument conversions goes in opposite directions.
                // Since parameter types are different ("object, string" vs. "string, object"), tie-breaking rules do not apply
            }

            static void M3(object x, params string[] y) { }
            static void M3(string x, params Span<object> y) { }
        }

        class Greeter
        {
            public char[] Message { get; set; } = "Hello?".ToCharArray();
        }


    }

    class Post
    {
        public string Title
        {
            get;
            //<LangVersion> preview</LangVersion> must set this
            set => field = !String.IsNullOrEmpty(value) ? value : throw new System.ArgumentException(nameof(value), "Must not be empty.");
        }
    }
}
