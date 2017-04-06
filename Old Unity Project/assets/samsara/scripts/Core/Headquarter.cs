using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

/// <summary>
/// Base class for buildings in the game.
/// </summary>
public class Headquarter : Building
{
    [HideInInspector]
    public Canvas HQpanel;
    public GameObject Hero;      
    /// <summary>
    /// Method called after object instantiation to initialize fields etc. 
    /// </summary>
    public override void Start()
    {
        //turn the HQ panel off first.
        GameObject tempObj = GameObject.Find("H_Menu");
        HQpanel = tempObj.GetComponent<Canvas>();
        HQpanel.enabled = false;
    }

    protected override void OnMouseDown()
    {
        //turn the HQ panel on
        GameObject tempObj = GameObject.Find("H_Menu");
        HQpanel = tempObj.GetComponent<Canvas>();
        HQpanel.enabled = true;
    }
    
    public override void Build_Button()
    {
        Transform T = getTrans();
        Vector3 pos;
              
        pos = new Vector3(0, 2, 0);

        Instantiate(Hero, T.position - pos, T.rotation);

        /*temp2.x = GetX();
        temp2.y = GetY() - 1;
        temp2.z = GetZ();*/

        //temp1.position = temp2;

        //Instantiate(unit, temp1.position, temp1.rotation);

    }  

}