using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE CHILD

public class Sphere : Shape
{
    public Sphere()
    {
        // INHERITANCE 
        ShapeName = "sphere";
        ShapeColor = Color.blue;
        
    }
    private void Awake()
    {
        // INHERITANCE //ABSTRACTION
        SetColor();
    }

    //POLYMORPHISME OVERRINDING
    protected override void DisplayText()
    {
        Debug.Log("My color is: " + ShapeColor + " and I'm a: " + ShapeName);
    }

    private void OnMouseDown()
    {
        DisplayText();
    }
}
