using System;
using UnityEngine;
using UnityEngine.UI;

public class GuiController : MonoBehaviour
{
    public CellGrid CellGrid;
    public GameObject UnitsParent;
    public Button NextTurnButton;
    
    void Start()
    {
        CellGrid.GameStarted += OnGameStarted;
        CellGrid.GameEnded += OnGameEnded;
    }
    private void OnGameStarted(object sender, EventArgs e)
    {
        foreach (Transform unit in UnitsParent.transform)
        {
            unit.GetComponent<Unit>().UnitHighlighted += OnUnitHighlighted;
            unit.GetComponent<Unit>().UnitDehighlighted += OnUnitDehighlighted;
            unit.GetComponent<Unit>().UnitAttacked += OnUnitAttacked;
        }

        foreach (Transform cell in CellGrid.transform)
        {
            cell.GetComponent<Cell>().CellHighlighted += OnCellHighlighted;
            cell.GetComponent<Cell>().CellDehighlighted += OnCellDehighlighted;
        }

        OnTurnEnded(sender,e);
    }

    private void OnGameEnded(object sender, EventArgs e)
    {
    }
    private void OnTurnEnded(object sender, EventArgs e)
    {
        NextTurnButton.interactable = ((sender as CellGrid).CurrentPlayer is HumanPlayer);

    }
    private void OnCellDehighlighted(object sender, EventArgs e)
    {
    }
    private void OnCellHighlighted(object sender, EventArgs e)
    {
    }
    private void OnUnitAttacked(object sender, AttackEventArgs e)
    {
        if (!(CellGrid.CurrentPlayer is HumanPlayer)) return;
        OnUnitDehighlighted(sender, new EventArgs());

        if ((sender as Unit).HitPoints <= 0) return;

        OnUnitHighlighted(sender, e);
    }
    private void OnUnitDehighlighted(object sender, EventArgs e)
    {
    }
    private void OnUnitHighlighted(object sender, EventArgs e)
    {
        var unit = sender as MyUnit;
    }

    public void RestartLevel()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
