using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIBoard : MonoBehaviour
{
    [SerializeField] UISquare squareRef;    

    UISquare[] squares = new UISquare[64];

    private int firstSquare = -1;
    
    void Start()
    {
        InitEmptyBoard();
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            HandleMouseClick();
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            ReadPositionFromFen();
        }
    }

    public void Move(ushort move)
    {
        
    }

    private void HandleMouseClick()
    {
        int squareNum = SquareNumFromMousePosition(Input.mousePosition);
        if (firstSquare >= 0)
        {
            if (squareNum >= 0)
            {
                MovePiece(firstSquare, squareNum);
                squares[firstSquare].RemoveHighlight();
                firstSquare = -1;
                
            }
        }
        else if (squareNum >= 0)
        {
            firstSquare = squareNum;

            squares[firstSquare].HighlightSquare();
        }
    }

    private int SquareNumFromMousePosition(Vector3 mousePosition)
    {
        Vector2 cameraCoordinates = Camera.main.ScreenToWorldPoint(mousePosition);
        cameraCoordinates.x += 0.5f;
        cameraCoordinates.y += 0.5f;
        Vector2Int fieldCoordinates = new Vector2Int(Mathf.FloorToInt(cameraCoordinates.y), Mathf.FloorToInt(cameraCoordinates.x));

        if (fieldCoordinates.x > 7 || fieldCoordinates.x < 0 ||
            fieldCoordinates.y > 7 || fieldCoordinates.y < 0)
        {
            return -1;
        }
        return fieldCoordinates.x * 8 + fieldCoordinates.y;
    }

    private void ReadPositionFromFen()
    {
        int[] _squares = FenReader.ReadFen();
        for (int i = 0; i < _squares.Length; i++)
        {
            squares[i].SetPiece(_squares[i]);
        }
        Position position = new Position(_squares);
    }

    private void InitEmptyBoard()
    {
        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                int pos = row * 8 + col;                
                squares[row * 8 + col] = Instantiate(squareRef, new Vector3(col, row, 0), Quaternion.identity);
                squares[row * 8 + col].SetSquareColor((((row + col) % 2) == 0) ? Color.gray : Color.white);
            }
        }
    }

    private void MovePiece(int from, int to)
    {
        this.squares[to].SetPiece(this.squares[from].GetPiece());
        this.squares[from].RemovePiece();
    }
}
