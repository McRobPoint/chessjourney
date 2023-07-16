using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISquare : MonoBehaviour
{    
    SpriteRenderer spriteRenderer;
    [SerializeField] UIPiece piece;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        piece = Instantiate(piece, transform.position, Quaternion.identity);       
    }

    public void SetPiece()
    {
        piece.SetPiece(1);
    }
}
