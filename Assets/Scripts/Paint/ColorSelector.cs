using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PaintIn3D;

public class ColorSelector : MonoBehaviour
{
    [SerializeField] private P3dPaintSphere painter;
    public Color currentColor {private get; set;}

    public void SetNewColor(Color color)
    {
        painter.Color = color;
    }
}
