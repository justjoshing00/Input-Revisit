using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
    //TODO: "for all units that implement movement/action/interaction, call F()"
    //TODO: create some mechanism for indirectly calling functions (service locator, probably)
    MechInput MI;
    TankInput TI;
    SoldierInput SI;

    // Start is called before the first frame update
    void Start()
    {
        MI = new();
        TI = new();
        SI = new();
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
        ((IMovement)MI).MoveUp();
        ((IMovement)MI).MoveDown();
        ((IMovement)MI).MoveLeft();
        ((IMovement)MI).MoveRight();

        ((IAction)MI).FirePrimary();
        ((IAction)MI).FireSecondary();
        ((IAction)MI).ChangeArmor();
        ((IAction)MI).SwitchMode();

        ((IInteraction)MI).Interact();

        MI.EndTurn();
        MI.ViewObjectives();

        MI.Pause();

        //((IMovement)TI).MoveUp();
        //((IMovement)TI).MoveDown();
        //((IMovement)TI).MoveLeft();
        //((IMovement)TI).MoveRight();

        //((IAction)TI).FirePrimary();
        //((IAction)TI).FireSecondary();
        //((IAction)TI).ChangeArmor();
        //((IAction)TI).SwitchMode();

        //((IInteraction)TI).Interact();

        //TI.EndTurn();
        //TI.ViewObjectives();

        //TI.Pause();

        //((IMovement)SI).MoveUp();
        //((IMovement)SI).MoveDown();
        //((IMovement)SI).MoveLeft();
        //((IMovement)SI).MoveRight();

        //((IAction)SI).FirePrimary();
        //((IAction)SI).FireSecondary();
        //((IAction)SI).ChangeArmor();
        //((IAction)SI).SwitchMode();

        //((IInteraction)SI).Interact();

        //SI.EndTurn();
        //SI.ViewObjectives();

        //SI.Pause();
    }
}
