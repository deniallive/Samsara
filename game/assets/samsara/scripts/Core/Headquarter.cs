using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
using System;

public class Headquarter : MonoBehaviour
{
    public Color BuildingColor;
    public event EventHandler BuildingClicked;

    public void Start()
    {
       SetColor(BuildingColor);
    }

    private void SetColor(Color color)
    {
        GetComponent<Renderer>().material.color = color;
    }
}