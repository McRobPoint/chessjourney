using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class BoardHelper 
{

    public static void PrintBoard(int[] squares)
    {
        for (int row = 7; row >= 0; row--)
        {
            string output = "";
            for (int col = 0; col <= 7; col++)
            {
                output += squares[row * 8 + col];
            }
            Debug.Log(output);
        }
    }
}

