# Algorithm Discussion

## Algorithm Source

This algorithm was inspired from a reading of the HeapSort algorithm on the wikipedia page, found here: [https://en.wikipedia.org/wiki/Heapsort](https://en.wikipedia.org/wiki/Heapsort). However, while I read the description, I didn't look too carefully at the psuedocode, so what you see here may be implemented differently.

## Test Cases

For this assignment, I chose the following test arrays:

1. { 1, 2, 3, 4, 5, 6 }
2. { 5, 4, 3, 2, 1 }
3. { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }
4. { 9, 3, 6, 3, 7, 3, 9, 3 }
5. { }
6. { 1 }

The first three test cases are different arrays to test. The first test case is already sorted properly; the algorithm should return the array sorted. In addition, the first two test cases have different lengths that test to make sure the algorithm handles odd and even sized arrays properly.

The fourth test case is an unsorted array with multiple repeating values. The intent with this test case is to ensure the algorithm handles repeated values (i.e., values in the array with equal value).

The final two test cases are "edge cases": an empty array and an array with only a single element. In both cases, the Sort should return the array with no changes made. This is more of a "make sure it doesn't break" sort of test case.
