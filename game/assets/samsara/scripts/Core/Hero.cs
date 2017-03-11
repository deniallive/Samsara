using UnityEngine.UI;
using UnityEngine;

public class Hero : MyUnit
{
    [HideInInspector]
    public GameObject Units;
    

    private void Start()
    {        
        SetParent();        
        Initialize();
    }

    public override void Initialize()
    {
        base.Initialize();
    }

    public override void OnTurnEnd()
    {
        base.OnTurnEnd();
    }

    private void SetParent()
    {
        Units = GameObject.Find("Units");
        transform.parent = Units.transform;
    }

}
