using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISquare : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    [SerializeField] UIPiece piece;
    [SerializeField] Color highlightColor;


    Color squareColor;
    int squareNum;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        piece = Instantiate(piece, transform.position, Quaternion.identity);
    }

    private void Update()
    {

        Position position = BoardHelper.GetPosition();
        if (position == null) return;
        ulong allActivatedPieces = 0;
        foreach (int piece in BoardHelper.activatedPieces)
        {
            allActivatedPieces ^= position.pieces[piece];
        }
        allActivatedPieces &= (1ul << squareNum);
        if (allActivatedPieces > 0) HighlightSquare();
        else RemoveHighlight();
    }

    public void InitSquare(Color color, int _squareNum)
    {
        squareColor = color;
        squareNum = _squareNum;
        spriteRenderer.color = squareColor;
    }

    public void HighlightSquare()
    {
        spriteRenderer.color = highlightColor;
    }

    public void RemoveHighlight()
    {
        spriteRenderer.color = squareColor;
    }

    public void SetPiece(int _piece)
    {
        piece.SetPiece(_piece);
    }

    public void RemovePiece()
    {
        piece.RemovePiece();
    }

    public int GetPiece()
    {
        return piece.piece;
    }
}
