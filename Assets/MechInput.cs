using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechInput : UnitInput, IMovement, IAction, IInteraction
{
    CommandManager commandManager;

    public MechInput()
    {
        commandManager = new();
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
}
