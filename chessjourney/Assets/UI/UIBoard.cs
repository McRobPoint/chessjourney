using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIBoard : MonoBehaviour
{
    [SerializeField] UISquare whiteSquare;
    [SerializeField] UISquare blackSquare;

    UISquare[] squares = new UISquare[64];
   
    
    void Start()
    {
        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                int pos = row * 8 + col;               
                UISquare squareToRef = (((row + col) % 2) == 0) ? whiteSquare : blackSquare;
                squares[row * 8 + col] = Instantiate(squareToRef, new Vector3(row, col, 0), Quaternion.identity);
            }            
        }        
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {           
            Vector2 cameraCoordinates = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            cameraCoordinates.x += 0.5f;
            cameraCoordinates.y += 0.5f;
            Vector2Int fieldCoordinates = new Vector2Int(Mathf.FloorToInt(cameraCoordinates.x), Mathf.FloorToInt(cameraCoordinates.y));
            
            if (fieldCoordinates.x > 7 || fieldCoordinates.x < 0 ||
                fieldCoordinates.y > 7 || fieldCoordinates.y < 0)
            {
                return;
            }                                  
            squares[fieldCoordinates.x * 8 + fieldCoordinates.y].SetPiece();
        }
    }



}
