using System;

class HeapSort
{
    /// <summary>
    /// Swap two integer values (by reference!).
    /// </summary>
    /// <param name="first">the first integer to swap</param>
    /// <param name="second">the second integer to swap</param>
    public static void Swap(ref int first, ref int second)
    {
        int temp = first;
        first = second;
        second = temp;
    }


    /// <summary>
    /// SiftDown sifts a node down in the Max Heap.  This assumes that all
    /// values in the array after the give node are already in Max Heap
    /// configuration.
    /// </summary>
    /// <param name="heap">the heap-in-progress</param>
    /// <param name="node">the particular node to "sift down"</param>
    public static void SiftDown(int[] heap, int node, int last)
    {
        int left = (node * 2) + 1;
        int right = (node * 2) + 2;

        int biggest = node;

        if ((left < last) && (heap[left] > heap[biggest]))
        {
            biggest = left;
        }

        if ((right < last) && (heap[right] > heap[biggest]))
        {
            biggest = right;
        }

        if (node != biggest)
        {
            Swap(ref heap[biggest], ref heap[node]);
            SiftDown(heap, biggest, last);
        }

    }

    /// <summary>
    /// HeapifyMax takes an array and arranges it into a Max Heap.
    /// </summary>
    /// <param name="newHeap">the array to Heapify</param>
    public static void HeapifyMax(int[] newHeap)
    {
        // the back half of the array are nodes w/ no children,
        // so they can be skipped.
        for (int i = (newHeap.Length / 2); i >= 0; i--)
        {
            SiftDown(newHeap, i, newHeap.Length);
        }
    }

    /// <summary>
    /// Sort is the primary method of the HeapSort implementation.
    /// </summary>
    /// <param name="sortArray"></param>
    public static void Sort(int[] sortArray)
    {
        HeapifyMax(sortArray);
        for (int i = sortArray.Length - 1; i > 0; i--)
        {
            Swap(ref sortArray[0], ref sortArray[i]);
            SiftDown(sortArray, 0, i);
        }
    }

    /// <summary>
    /// PrintArray prints out the contents of an integer array.
    /// </summary>
    /// <param name="printArray">the array to be printed</param>
    public static void PrintArray(int[] printArray)
    {
        Console.WriteLine("Contents of Array:");
        Console.Write("{ ");
        for (int i = 0; i < printArray.Length; i++)
        {
            Console.Write(printArray[i]);
            if (i < printArray.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine(" }");
    }

    /// <summary>
    /// TestSort displays the content of the array before sorting, sorts
    /// the array, and displays the content of the array after sorting.
    /// </summary>
    /// <param name="testArray">the array to test the sort on</param>
    public static void TestSort(int[] testArray)
    {
        Console.WriteLine("Testing HeapSort on following array:");
        PrintArray(testArray);
        Console.WriteLine("Sorting...");
        Sort(testArray);
        Console.WriteLine("Array after executing HeapSort:");
        PrintArray(testArray);
    }

    public static void Spacer()
    {
        Console.WriteLine("\n* * * * * * * * * *\n");
    }
    public static void Main(string[] args)
    {
        // gotta test my heaps
        int[] testHeap1 = { 5, 4, 3, 2 };
        int[] testHeap2 = { 5, 4, 3, 2, 1 };
        int[] testHeap3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] testHeap4 = { 9, 3, 6, 3, 7, 3, 9, 3 };
        int[] testHeap5 = { };
        int[] testHeap6 = { 1 };

        TestSort(testHeap1);
        Spacer();
        TestSort(testHeap2);
        Spacer();
        TestSort(testHeap3);
        Spacer();
        TestSort(testHeap4);
        Spacer();
        TestSort(testHeap5);
        Spacer();
        TestSort(testHeap6);


    }
}