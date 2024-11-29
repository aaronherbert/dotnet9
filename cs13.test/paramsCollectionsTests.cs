namespace cs13.test
{
    public class ParamsCollectionsTests
    {
        [Fact]
        public void Test1()
        {

        }

        public void Concat<T>(params ReadOnlySpan<T> items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write(items[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
