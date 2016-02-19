using System;

class Solution
{
    public int solution(int N)
    {
        string strBinary = Convert.ToString(N, 2);
        int count = 0;
        int maxCount = 0;
        bool startCounting = false;

        foreach (char c in strBinary)
        {
            string strBin = Convert.ToString(c);

            // First we have to find a 1 to enable the 0 count
            if (strBin == "1")
            {
                startCounting = true;

                // If count > 0 that means we have just finished coutting a 0 sequence
                if (count > 0)
                {
                    // If the actual count is bigger than our last biggest count, we set it as the new biggest
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }
                    count = 0; // As our count is over, we set the counter to zero to start a new one
                }
            }
            else
            {
                // Add one to the counter only if the startCounting is true 
                if (startCounting)
                {
                    count = count + 1;
                }
            }
        }

        return maxCount;
    }
}


