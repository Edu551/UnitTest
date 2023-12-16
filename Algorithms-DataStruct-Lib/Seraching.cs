namespace Algorithms_DataStruct_Lib
{
    public class Seraching
    {
        // This is better than the recursive one.
        public static int BinarySearchClassic(int[] array, int value)
        {
            int low = 0;
            int high = array.Length;

            while (low < high)
            {
                int mid = (low + high) / 2;
                var test = array[mid];
                if (array[mid] == value)
                    return mid;

                if (array[mid] < value)
                    low = mid + 1;
                else high = mid;
            }

            return -1;
        }

        public static int RecursiveBinarySearch(int[] array, int value)
        {
            return InternalRecursiveBinarySearch(0, array.Length);

            int InternalRecursiveBinarySearch(int low, int high)
            {
                if (low >= high)
                    return -1;

                int mid = (low + high) / 2;

                if (array[mid] == value)
                    return mid;

                if (array[mid] < value)
                    return InternalRecursiveBinarySearch(mid + 1, high);

                return InternalRecursiveBinarySearch(low, mid);
            }
        }
    }
}
