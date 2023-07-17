using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Move
{
	public static class Flag
	{
		public const ushort Quiet = 0b0000;
		public const ushort Capture = 0b0001;
		public const ushort DoublePawnPush = 0b0010;
		public const ushort KingCastle = 0b0100;
		public const ushort QueenCastle = 0b0110;
		public const ushort PromoteToQueen = 0b1000;
		public const ushort PromoteToKnight = 0b1010;
		public const ushort PromoteToRook = 0b1100;
		public const ushort PromoteToBishop = 0b1110;
	}


	const ushort startSquareMask = 0b0000000000111111;
	const ushort targetSquareMask = 0b0000111111000000;
	const ushort flagMask = 0b1111000000000000;


	public static ushort GenerateMove(int from, int to, int flag)
    {
		return  (ushort)(from | to << 6 | flag << 12);
    }

	public static ushort GetFlag(ushort move) {
		return (ushort) (move >> 12);
	}

	public static bool IsCapture(ushort move)
    {
		return GetFlag(move) == Flag.Capture;
    }
}
