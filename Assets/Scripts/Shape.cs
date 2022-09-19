using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE PARENT
public class Shape : MonoBehaviour
{


    private string _name;
    private Color _color;

    // ENCAPSULATION
    public string ShapeName
    {
        get { return _name; }
        protected set { _name = value; }
    }

    // ENCAPSULATION
    public Color ShapeColor
    {
        get { return _color; }
        protected set { _color = value; }
    }

    protected virtual void DisplayText()
    {
        Debug.Log("i'm a Shape");
    }

    // ABSTRACTION
    protected void SetColor()
    {
        GetComponent<MeshRenderer>().material.color = ShapeColor;
    }

    





}
