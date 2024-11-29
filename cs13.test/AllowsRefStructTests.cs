//namespace cs13.test
//{
//    public class AllowsRefStructTests
//    {//https://blog.ndepend.com/c-13-ref-struct-interfaces-and-the-allows-ref-struct-generic-anti-constraint/
//        [Fact]
//        public void Test1()
//        {
//            const string str = "Hello .NET 9 and C# 13";
//            ReadOnlySpan<char> span = str;

//            // GetCustomHash() can be invoked on various types that implement IReadOnlyList<char>
//            // including a ref struct with no heap allocation required
//            int h1 = GetCustomHash(new ReadOnlySpanWrapper<char>(span));

//            char[] array = str.ToCharArray();
//            int h2 = GetCustomHash(array);

//            Assert.IsTrue(h1 == h2);

//            // Algorithm that can work with an abstracted span
//            static int GetCustomHash<T>(T list) where T : IReadOnlyList<char>, allows ref struct
//            {
//                int hash = 0;
//                int count = list.Count;
//                for (int i = 0; i < count; i++)
//                {
//                    //  http://www.cse.yorku.ca/~oz/hash.html  (hash * 33) + c
//                    //  the magic of number 33 (why it works better than many other constants, prime or not)
//                    //  has never been adequately explained. 
//                    hash += (hash << 5) + list[i];
//                }
//                return hash;
//            }

//            // ref struct wrapper 
//            ref struct ReadOnlySpanWrapper<T> : IReadOnlyList<T>
//        {
//            readonly ReadOnlySpan<T> _span;
//            internal ReadOnlySpanWrapper(ReadOnlySpan<T> span)
//            {
//                _span = span;
//            }
//            public T this[int index] => _span[index];
//            public int Count => _span.Length;

//            // No way to box a ref struct into an interface
//            public IEnumerator<T> GetEnumerator() { throw new NotImplementedException(); }
//            IEnumerator IEnumerable.GetEnumerator() { throw new NotImplementedException(); }
//        }

//        static class Assert
//        {
//            public static void IsTrue(bool b)
//            {
//                System.Diagnostics.Debug.Assert(b);
//            }
//        }

//    }
//}
//}
