using System;
using System.Collections.Generic;

class Solution
{
    // THE PROBLEM
    // Given an array that contains N bits, use base -2 and consider the bit order from the least to the most significant.
    // If the number represented in the array is X, find the array B that represents -X
    // Example: A = { 1, 0, 0, 1, 1 } = 1*(-2^0) + 0*(-2^1) + 0*(-2^2) + 1*(-2^3) + 1*(-2^4) = 9
    //          B = { 1, 1, 0, 1 } =  1*(-2^0) + 1*(-2^1) + 0*(-2^2) + 1*(-2^3) = -9
    // Notes:
    // > as the solution envolves the use of List, must add "using System.Collections.Generic;"

    public int[] solution(int[] A)
    {
        double number = 0;

        // first we must get the number from the array
        for (int i = 0; i < A.Length; i++)
        {
            number += A[i] * Math.Pow(-2, i);
        }

        // now we multiply it by -1
        number = number * -1;

        // List time. Create a list to populate with the new elements of the array
        List<int> lstConvert = new List<int>();
        do
        {
            // every element of the list will be the
            // remainder of the division of the number by -2
            lstConvert.Add(Convert.ToInt32(Math.Abs(number % -2)));

            // now we have to divide the number by the -2 base
            // and apply the Ceiling.
            number = Math.Ceiling(number / -2);
        } while (number != 0); //we do the loop until number equals 0

        // as we have to return an array, just convert the list
        int[] arrConvert = lstConvert.ToArray();

        return arrConvert;
    }
}
