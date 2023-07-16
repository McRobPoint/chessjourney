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

    public int piece;

    Vector2 _startPosition;



    public void SetPiece(int _piece)
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();       
        spriteRenderer.sprite = b_king;        
    }
}
