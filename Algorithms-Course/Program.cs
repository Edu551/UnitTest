using Algorithms_DataStruct_Lib;
using System.Diagnostics;

namespace Algorithms_Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            TestThreeSum();

            Console.ReadKey();
        }

        private static void TestThreeSum()
        {
            //1 second for 1k
            var ints = In.ReadInts("Data\\1kints.txt").ToArray();

            var watch = new Stopwatch();
            watch.Start();

            var triplets = ThreeSum.Count(ints);

            watch.Stop();

            Console.WriteLine($"The number of \"zero-sum\" triplets:{triplets}");
            Console.WriteLine($"Time taken:{watch.Elapsed:g}");
        }
    }
}