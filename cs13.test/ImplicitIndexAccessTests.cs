using System.Diagnostics;

namespace cs13.test
{
    public class ImplicitIndexAccessTests
    {
        [Fact]
        public void Test1()
        {
            var dataBuffer = new DataBuffer(10);
            dataBuffer[^1] = 8;   // Assigns 8 to the last element
            dataBuffer[^2] = 5;   // Assigns 5 to the second from last element
            dataBuffer[^3] = 12;  // Assigns 12 to the third from last element
            dataBuffer[^7] = 15;  // Assigns 15 to the seventh from last element

            dataBuffer.PrintBuffer();
        }

        public class DataBuffer
        {
            private int[] buffer;

            public DataBuffer(int size)
            {
                buffer = new int[size];
            }

            public int this[Index index]
            {
                get => buffer[index];
                set => buffer[index] = value;
            }

            public void PrintBuffer()
            {
                for (int i = 0; i < buffer.Length; i++)
                {
                    Debug.WriteLine($"Buffer[{i}] = {buffer[i]}");
                }
            }
        }
    }
}
