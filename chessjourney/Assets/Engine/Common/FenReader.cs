using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class FenReader 
{
    [SerializeField]
    public static string fen = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1";

    private static Dictionary<char, int> charToPieceDict = InitCharToPieceDict();

    public static int[] ReadFen()
    {
        int[] squares = new int[64];
        string[] splitFen = fen.Split(" ");
        string position = splitFen[0];
        string sideToMove = splitFen[1];
        string castleRights = splitFen[2];
        string enPassantSquare = splitFen[3];
        string captureOrPawnMoveCounter = splitFen[4];
        ReadPosition(position, squares);        
        return squares;
    }

    private static void ReadPosition(string position, int[] squares)
    {
        int currentRow = 0;
        int currentCol = 0;
        for (int pos = 0; pos < position.Length; pos++)
        {
            char currentChar = position[pos];
            if (charToPieceDict.ContainsKey(currentChar))
            {
                squares[(7 - currentRow) * 8 + currentCol] = charToPieceDict.GetValueOrDefault(currentChar);                
                currentCol++;
                continue;
            }
            if (currentChar == '/')
            {
                currentCol = 0;
                currentRow++;
                continue;
            }

            currentCol += currentChar - '0';
        }
    }

    private static Dictionary<char, int> InitCharToPieceDict()
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        dict.Add('K', Piece.King    | Piece.White);
        dict.Add('Q', Piece.Queen   | Piece.White);
        dict.Add('R', Piece.Rook    | Piece.White);
        dict.Add('B', Piece.Bishop  | Piece.White);
        dict.Add('N', Piece.Knight  | Piece.White);
        dict.Add('P', Piece.Pawn    | Piece.White);

        dict.Add('k', Piece.King    | Piece.Black);
        dict.Add('q', Piece.Queen   | Piece.Black);
        dict.Add('r', Piece.Rook    | Piece.Black);
        dict.Add('b', Piece.Bishop  | Piece.Black);
        dict.Add('n', Piece.Knight  | Piece.Black);
        dict.Add('p', Piece.Pawn    | Piece.Black);
        return dict;
    }
  
}
