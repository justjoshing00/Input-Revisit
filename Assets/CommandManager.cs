using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandManager
{
    Commands commands;
    public delegate void MoveUp();
    public MoveUp moveUp;

    public delegate void MoveDown();
    public MoveUp moveDown;

    public delegate void MoveLeft();
    public MoveUp moveLeft;

    public delegate void MoveRight();
    public MoveUp moveRight;
    public CommandManager()
    {
        commands = new();
        moveUp = commands.MoveUp;
        moveDown = commands.MoveDown;
        moveLeft = commands.MoveLeft;
        moveRight = commands.MoveRight;
    }

    
}
