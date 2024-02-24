using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{

    
    MechInput mechInput = new();
    TankInput tankInput = new();
    SoldierInput soldierInput = new();

    List<IMovement> movers;
    List<IAction> actors;
    List<IInteraction> interactors;

    // Start is called before the first frame update
    void Start()
    {
        movers = new List<IMovement> { mechInput, tankInput, soldierInput };
        actors = new List<IAction> { mechInput, tankInput, soldierInput };
        interactors = new List<IInteraction> { mechInput, tankInput, soldierInput };
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
        //if unit is active
        //OR
        //search list of units for active unit, then call these passing in the active unit
        //OR
        //shove the active unit to the front of the list
        foreach (IMovement mover in movers)
        {
            mover.MoveUp();
            mover.MoveDown();
            mover.MoveLeft();
            mover.MoveRight();
        }
        foreach (IAction actor in actors)
        {
            actor.FirePrimary();
            actor.FireSecondary();
            actor.SwitchMode();
            actor.ChangeArmor();
        }
        foreach (IInteraction interactor in interactors)
        {
            interactor.Interact();
        }

        mechInput.EndTurn();
        soldierInput.EndTurn();
        tankInput.EndTurn();

        mechInput.ViewObjectives();
        soldierInput.ViewObjectives();
        tankInput.ViewObjectives();


    }
}
