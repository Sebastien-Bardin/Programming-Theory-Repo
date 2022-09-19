using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
   
    public Cube()
    {
        ShapeName = "Cube";
        ShapeColor = Color.red;
        
    }

    private void Awake()
    {
        SetColor();
    }

    protected override void DisplayText()
    {
        Debug.Log("I'm a : " + ShapeName + " my color is : " + ShapeColor);
    }

    private void OnMouseDown()
    {
        DisplayText();
    }
}
