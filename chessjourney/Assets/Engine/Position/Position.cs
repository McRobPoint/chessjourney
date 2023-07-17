using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position 
{
    public int[] squares = new int[64];
    public ulong[] pieces = new ulong[16];

    public ushort flag = 0b0000;
    public ulong enPassant = 0;
    public ulong zobrist = 0;
    public byte sideToMove;


    public Position(int[] squares) {
        for (int i = 0; i < squares.Length; i++)
        {            
            pieces[squares[i]] ^= 1ul << i;
        }
        Bitboard.Print(pieces[Piece.King | Piece.Black]);
    }
}
