using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

/// <summary>
/// Base class for buildings in the game.
/// </summary>
public abstract class Building : MonoBehaviour
{

    /// <summary>
    /// Cell that the unit is currently occupying.
    /// </summary>
    public Cell Cell { get; set; }

    /// <summary>
    /// Method called after object instantiation to initialize fields etc. 
    /// </summary>
    public virtual void Start()
    {

    }

    protected virtual void OnMouseDown()
    {

    }

    public Transform getTrans()
    {
        return transform;
    }

    public virtual void Build_Button()
    {
        
    }
}
