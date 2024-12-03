using System.Collections;
using BenchmarkDotNet.Attributes;
using Iced.Intel;

namespace WhatsNew
{
    public class ParamsCollections
    {
        /*
         * Cleaner code. Significantly reduces the number of calls to .ToArray(), .ToList().
Performance. Calls like .ToArray(), .ToList()already add extra resource overhead on their own. 
        Also, it now supports passing Span<> and IEnumerable<>, leveraging more efficient memory usage and lazy execution. 
        Overall, this provides greater flexibility and better performance in scenarios that demand it 🚀.
         */
        public ParamsCollections()
        {
            Console.WriteLine(SumArray([1, 2, 3]));
        }

        public int SumArray(int[] numbers)
        {
            return numbers.Sum();
        }

        public int SumParamsArray(params int[] numbers)
        {
            return numbers.Sum();
        }

        public int SumList(params List<int> numbers)
        {
            return numbers.Sum();
        }

        public int SumList(params Span<int> numbers)
        {//https://ironpdf.com/blog/net-help/csharp-span/
            return 0;
        }

        public int SumtestCollection(params TestCollection numbers)
        {
            return numbers.Sum();
        }


    }

    public class TestCollection : IEnumerable<int>
    {
        private List<int> _numbers { get; set; }

        public TestCollection()
        {

        }
        public TestCollection(List<int> numbers)
        {
            _numbers = _numbers;
        }
        public IEnumerator<int> GetEnumerator()
        {
            return _numbers.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(int item)
        {
            _numbers.Add(item);
        }
    }

    public class BenchMarks
    {
        public ParamsCollections ParamsCollections { get; set; } = new();

        [Benchmark]
        public int SummArray()
        {
            return ParamsCollections.SumArray(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        }

        [Benchmark]
        public int SumParamsArray()
        {
            return ParamsCollections.SumParamsArray(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
        }

        [Benchmark]
        public int SumList()
        {
            return ParamsCollections.SumList(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        }

        [Benchmark]
        public int SumtestCollection()
        {
            return ParamsCollections.SumtestCollection(new TestCollection(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
        }


    }
}
