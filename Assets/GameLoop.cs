using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{

    
    MechInput MI = new();
    TankInput TI = new();
    SoldierInput SI = new();

    List<IMovement> Movers;
    List<IAction> Actors;
    List<IInteraction> Interactors;

    // Start is called before the first frame update
    void Start()
    {
        Movers = new List<IMovement> { MI, TI, SI };
        Actors = new List<IAction> { MI, TI, SI };
        Interactors = new List<IInteraction> { MI, TI, SI };
    }

    // Update is called once per frame
    void Update()
    {
        Loop();
    }

    void Loop()
    {
        ExecuteInput();
    }

    void ExecuteInput()
    {

        foreach (IMovement mover in Movers)
        {
            mover.MoveUp();
            mover.MoveDown();
            mover.MoveLeft();
            mover.MoveRight();
        }
        foreach (IAction actor in Actors)
        {
            actor.FirePrimary();
            actor.FireSecondary();
            actor.SwitchMode();
            actor.ChangeArmor();
        }
        foreach (IInteraction interactor in Interactors)
        {
            interactor.Interact();
        }

        MI.EndTurn();
        SI.EndTurn();
        TI.EndTurn();

        MI.ViewObjectives();
        SI.ViewObjectives();
        TI.ViewObjectives();


    }
}
