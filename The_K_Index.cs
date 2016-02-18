using System;

class Solution
{
    // THE PROBLEM
    // Find a index K that split the array A with N elements so that if one side has N occurrances of a given inter X, the other side
    // has the same number of non occurrances
    // Example: A = { 3, 4, 3, 5, 7, 3, 2 } | X = 3
    // K = 4 as A[0...4-1] contains 2 times X and A[K...N-1] contains 2 elements that are different than X

    public int solution(int X, int[]A)
    {
        int[] arrPos = new int[A.Length];
        int K = 0;
        int occurrances = 0;

        // first count how many occurences of X there is in A
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] == X)
            {
                occurrances += 1;
            }
        }

        // now just subtract the length of the array by the number of occurrences of X
        K = A.Length - occurrances;

        return K;
    }
}
