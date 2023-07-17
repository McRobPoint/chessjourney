using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class Bitboard 
{
    private static ulong oneMask = 1;

    public static void Print(ulong bb)
    {
        string bytes = Convert.ToString((long)bb, 2);
        while (bytes.Length < 64)
        {
            bytes = "0" + bytes;
        }

        string output = "";
        for (int i = 0; i <= 7; i++)
        {
            output += "\r\n" + Reverse(bytes.Substring(i * 8, 8));
        }
        
        Debug.Log(output);
    }

    private static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
