using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPiece : MonoBehaviour
{
    [SerializeField] public Sprite w_king;
    [SerializeField] public Sprite w_queen;
    [SerializeField] public Sprite w_rook;
    [SerializeField] public Sprite w_bishop;
    [SerializeField] public Sprite w_knight;
    [SerializeField] public Sprite w_pawn;
    [SerializeField] public Sprite b_king;
    [SerializeField] public Sprite b_queen;
    [SerializeField] public Sprite b_rook;
    [SerializeField] public Sprite b_bishop;
    [SerializeField] public Sprite b_knight;
    [SerializeField] public Sprite b_pawn;

    private Sprite[] sprites = new Sprite[16];
    public int piece;

    Vector2 _startPosition;

    private void Start()
    {
        InitSpritesArray();
    }

    public void SetPiece(int _piece)
    {        
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        piece = _piece;
        spriteRenderer.sprite = sprites[_piece];
    }

    public void RemovePiece()
    {
        piece = 0;
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = null;
    }




    private void InitSpritesArray()
    {
        
        sprites[Piece.Pawn | Piece.White] = w_pawn;
        sprites[Piece.Knight | Piece.White] = w_knight;
        sprites[Piece.Bishop | Piece.White] = w_bishop;
        sprites[Piece.Rook | Piece.White] = w_rook;
        sprites[Piece.Queen | Piece.White] = w_queen;
        sprites[Piece.King | Piece.White] = w_king;

        sprites[Piece.Pawn | Piece.Black] = b_pawn;
        sprites[Piece.Knight | Piece.Black] = b_knight;
        sprites[Piece.Bishop | Piece.Black] = b_bishop;
        sprites[Piece.Rook | Piece.Black] = b_rook;
        sprites[Piece.Queen | Piece.Black] = b_queen;
        sprites[Piece.King | Piece.Black] = b_king;

    }
}
