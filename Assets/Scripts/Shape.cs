using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{


    private string _name;
    private Color _color;

    public string ShapeName
    {
        get { return _name; }
        protected set { _name = value; }
    }

    public Color ShapeColor
    {
        get { return _color; }
        protected set { _color = value; }
    }

    protected virtual void DisplayText()
    {
        Debug.Log("i'm a Shape");
    }

    protected void SetColor()
    {
        GetComponent<MeshRenderer>().material.color = ShapeColor;
    }

    private void Awake()
    {
        SetColor();
    }





}
