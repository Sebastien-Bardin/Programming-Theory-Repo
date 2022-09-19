using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    public Sphere()
    {
        ShapeName = "sphere";
        ShapeColor = Color.blue;
        
    }
    private void Awake()
    {
        SetColor();
    }

    protected override void DisplayText()
    {
        Debug.Log("My color is: " + ShapeColor + " and I'm a: " + ShapeName);
    }

    private void OnMouseDown()
    {
        DisplayText();
    }
}
