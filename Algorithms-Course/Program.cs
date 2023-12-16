using Algorithms_DataStruct_Lib;
using Algorithms_DataStruct_Lib.Node;
using System;
using System.Diagnostics;

namespace Algorithms_Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //NodeExamples();

            Queue<int> queue = new Queue<int>(18);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            Console.WriteLine($"Should print out 1: {queue.Peek()}");

            queue.Dequeue();
            
            Console.WriteLine($"Should print out 2: {queue.Peek()}");
            Console.WriteLine($"Contains 3? {queue.Contains(3)}");


            Console.ReadKey();
        }

        private static void NodeExamples()
        {
            var first = new Node<int>(5);
            var second = new Node<int>(1);
            var third = new Node<int>(3);

            first.Next = second;
            second.Next = third;

            PrintOutLinkedList(first);
        }

        private static void PrintOutLinkedList(Node<int> node)
        {
            while(node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }

        }

        private static int RecursiveFactorial(int n)
        {
            if (n == 0)
                return 1;

            return n * RecursiveFactorial(n - 1);
        }

        private static int IterativeFactorial(int number) 
        {
            if (number == 0)
                return 1;

            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        private static void TestThreeSum()
        {
            //0:00:00,0036967 second for 16k QuickSort
            var ints = In.ReadInts("Data\\16kints.txt").ToArray();

            var watch = new Stopwatch();
            watch.Start();

            Sorting.QuickSort(ints);

            //var triplets = ThreeSum.Count(ints);

            watch.Stop();

            //Console.WriteLine($"The number of \"zero-sum\" triplets:{triplets}");
            Console.WriteLine($"Time taken:{watch.Elapsed:g}");
        }

        private static void LinearSearchDemo()
        {
            var customersList = new List<Person>()
            {
                new() {Age = 3, Name = "Ann"},
                new() {Age = 16, Name = "Bill"},
                new() {Age = 20, Name = "Rose"},
                new() {Age = 14, Name = "Rob"},
                new() {Age = 28, Name = "Bill"},
                new() {Age = 14, Name = "John"},
            };
            var intList = new List<int>() { 1, 4, 2, 7, 5, 9, 12, 3, 2, 1 };

            bool contains = intList.Contains(3);
            bool contains2 = customersList.Contains(new Person { Age = 14, Name = "Rob" }, new CustomersComparer());

            bool exists = customersList.Exists(customer => customer.Age == 28);

            int min = intList.Min();
            int max = intList.Max();

            int youngestCustomerAge = customersList.Min(customer => customer.Age);

            Person? bill = customersList.Find(customer => customer.Name == "Bill");
            Person? lastBill = customersList.FindLast(customer => customer.Name == "Bill");
            Person lastBill2 = customersList.Last(customer => customer.Name == "Bill");

            List<Person> customers = customersList.FindAll(customer => customer.Age > 18);
            IEnumerable<Person> whereAge = customersList.Where(customer => customer.Age > 18);

            int index1 = customersList.FindIndex(customer => customer.Age == 14);
            int lastIndex = customersList.FindLastIndex(customer => customer.Age > 18);

            int indexOf = intList.IndexOf(2);
            int lastIndexOf = intList.LastIndexOf(2);

            //from list
            bool isTrueForAll = customersList.TrueForAll(customer => customer.Age > 10);

            //from linq
            bool all = customersList.All(customer => customer.Age < 50);

            bool areThereAny = customersList.Any(customer => customer.Age == 3);

            int count = customersList.Count(customer => customer.Age > 18);

            Person firstBill = customersList.First(customer => customer.Name == "Bill");

            Person singleAnn = customersList.Single(customer => customer.Name == "Ann");
        }

        #region Func

        private static bool Exists(int[] array, int number)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                    return true;
            }

            return false;
        }

        private static int IndexOf(int[] array, int number)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                    return i;
            }

            return -1;
        }
        #endregion

    }
    
    internal class CustomersComparer : IEqualityComparer<Person>
    {
        public bool Equals(Person x, Person y) => x.Age == y.Age && x.Name == y.Name;

        public int GetHashCode(Person obj) => obj.GetHashCode();
    }
}