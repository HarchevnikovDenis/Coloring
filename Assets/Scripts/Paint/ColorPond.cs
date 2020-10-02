using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPond : MonoBehaviour
{
    [SerializeField] ColorSelector colorSelector;
    [SerializeField] private Color colorInThisPond;

    private void OnMouseEnter() 
    {
        colorSelector.SetNewColor(colorInThisPond);
    }
}
