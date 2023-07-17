using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPieceToggle : MonoBehaviour
{
    Toggle toggle;
    [SerializeField] int piece;

    private void Awake()
    {
        toggle = GetComponent<Toggle>();
        toggle.onValueChanged.AddListener(delegate
        {
            ToggleValueChanged();
        });
    }

    private void ToggleValueChanged()
    {
        Debug.Log("Toggled: " + toggle.isOn);
    }

}
