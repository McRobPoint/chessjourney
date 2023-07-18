using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Piece 
{
    public static int TypeMask = 0b1110;

    public static int Pawn = 0b0010;    //2
    public static int Knight = 0b0100;  //4
    public static int Bishop = 0b0110;  //6
    public static int Rook = 0b1000;    //8
    public static int Queen = 0b1010;   //10
    public static int King = 0b1100;    //12

    public static int ColorMask = 0b0001;
    public static int White = 0b0000;
    public static int Black = 0b0001;

    public static int GetColor(int piece)
    {       
        return piece & ColorMask;
    }

}
