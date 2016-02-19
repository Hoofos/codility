using System;

class Solution
{
    // THE PROBLEM
    // In chess, the knigth is a piece that moves as (2,1) or (1,2)
    // If we start at (0,0), find the number of moves K that the knight needs to get to a given position (A,B)
    // Notes:
    // > if the knight can't reach the given position, return -1;
    // > if it would take more than 100.000.000 for the knigth to get there, it will probably be dead before that, so return -2;

    public int solution(int A, int B)
    {
        // As the knight moves as (2,1) or (1,2), this means that it moves is multiple of 3
        // Now we sum the coordinates (A,B), and it must be multiple of 3

        int sum = A + B;
        int moves = 0;

        // sum is not multiple of 3
        // impossible for the knigth to get there, return -1
        if (sum % 3 > 0)
        {
            moves = -1;
        }
        // too many moves
        // the knight dropped dead after move 99999999, return -2
        else if (sum / 3 > 100000000)
        {
            moves = -2;
        }
        // if the knight can get there and it did manage to get there alive,
        // return the number of moves
        else
        {
            moves = sum / 3;
        }

        return moves;
    }
}
