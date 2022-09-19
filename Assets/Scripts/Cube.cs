using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// INHERITANCE CHILD
public class Cube : Shape
{
   
    public Cube()
    {
        // INHERITANCE
        ShapeName = "Cube";
        ShapeColor = Color.red;
        
    }

    private void Awake()
    {
        // INHERITANCE //ABSTRACTION
        SetColor();
    }

    //POLYMORPHISME OVERRINDING
    protected override void DisplayText()
    {
        Debug.Log("I'm a : " + ShapeName + " my color is : " + ShapeColor);
    }

    private void OnMouseDown()
    {
        DisplayText();
    }
}
