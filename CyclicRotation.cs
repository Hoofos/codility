using System;

class Solution
{
    public int[] solution(int k, int[] A)
    {
        int[] arrRotated = new int[A.Length]; // rotated array
        int newPos = 0;

        for (int i = 0; i < A.Length; i++)
        {
            newPos = i + k;

            if (newPos >= A.Length)
            {
                newPos = newPos % A.Length;
            }
            arrRotated[newPos] = A[i];
        }

        return arrRotated;

    }
}
