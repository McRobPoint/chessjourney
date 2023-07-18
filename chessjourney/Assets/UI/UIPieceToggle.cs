using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPieceToggle : MonoBehaviour
{
    [SerializeField] private Toggle toggle;
    [SerializeField] int piece;

    

    private void Awake()
    {        
        toggle.onValueChanged.AddListener(delegate {
            ToggleChangeListener();
	    });        
    }    

    private void ToggleChangeListener()
    {
        if (toggle.isOn)
        {
            BoardHelper.activatedPieces.Add(piece);
        }
        else
        {
            BoardHelper.activatedPieces.Remove(piece);
        }
    }
}
