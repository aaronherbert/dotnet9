namespace Jit9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumArray(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
        }

        public static int SumArray(int[] arr)
        {
            return arr.Sum();
        }
    }
}
