using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class BoardHelper 
{    
    public static HashSet<int> activatedPieces = new HashSet<int>();
    private static Position position;

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

    public static void SetPosition(Position _position)
    {
        position = _position;
    }

    public static Position GetPosition()
    {
        return position;
    }
}

