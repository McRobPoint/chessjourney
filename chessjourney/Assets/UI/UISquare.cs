using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISquare : MonoBehaviour
{    
    SpriteRenderer spriteRenderer;

    [SerializeField] UIPiece piece;
    [SerializeField] Color highlightColor;

    Color squareColor;
    

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        piece = Instantiate(piece, transform.position, Quaternion.identity);       
    }

    public void SetSquareColor(Color color)
    {
        squareColor = color;
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
