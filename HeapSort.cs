using System;

class HeapSort
{


    /*
        0
        1               2
        3       4       5       6
        7   8   9   10  11  12  13  14

    */

    // assume all children are heapified, heapify
    // the current node
    // probably requires a sift down

    // children are 2n+1 and 2n+2


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
        for (int i = (newHeap.Length / 2); i >= 0; i--)
        {
            SiftDown(newHeap, i, newHeap.Length);
        }
    }

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

    public static void TestSort(int[] testArray)
    {
        Console.WriteLine("Testing HeapSort on following array:");
        PrintArray(testArray);
        Console.WriteLine("Sorting...");
        Sort(testArray);
        Console.WriteLine("Array after executing HeapSort:");
        PrintArray(testArray);
    }

    public static void Main(string[] args)
    {
        // gotta test my heaps
        int[] testHeap1 = { 5, 4, 3, 2 };
        int[] testHeap2 = { 5, 4, 3, 2, 1 };
        int[] testHeap3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] testHeap4 = { 6, 5, 5, 3, 2, 1 };

        TestSort(testHeap1);
        TestSort(testHeap2);
        TestSort(testHeap3);
        TestSort(testHeap4);


    }
}