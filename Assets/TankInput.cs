using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankInput : UnitInput, IMovement,IAction,IInteraction
{
    public TankInput() : base()
    {

    }

    public void MoveUp()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            commandManager.moveUp();

        }
    }
    public void MoveDown()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            commandManager.moveDown();

        }
    }
    public void MoveLeft()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            commandManager.moveLeft();

        }
    }
    public void MoveRight()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            commandManager.moveRight();

        }
    }
    public void FirePrimary()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            commandManager.firePrimary();
        }
    }
    public void FireSecondary()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            commandManager.fireSecondary();
        }
    }
    public void SwitchMode()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            commandManager.switchMode();
        }
    }
    public void ChangeArmor()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            commandManager.changeArmor();
        }
    }
    public void Interact()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            commandManager.interact();
        }
    }
}

