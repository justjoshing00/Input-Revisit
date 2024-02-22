using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class CommandManager
{
    Commands commands;
    public Action moveUp; 
    public Action moveDown;
    public Action moveLeft;
    public Action moveRight;
    public Action firePrimary;
    public Action fireSecondary;
    public Action switchMode;
    public Action changeArmor;
    public Action interact;
    public Action endTurn;
    public Action viewObjectives;
    public Action pause;

    public CommandManager()
    {
        commands = new();
        moveUp = commands.MoveUp;
        moveDown = commands.MoveDown;
        moveLeft = commands.MoveLeft;
        moveRight = commands.MoveRight;
        firePrimary = commands.FirePrimary;
        fireSecondary = commands.FireSecondary;
        switchMode = commands.SwitchMode;
        changeArmor = commands.ChangeArmor;
        interact = commands.Interact;
        endTurn = commands.EndTurn;
        viewObjectives = commands.ViewObjectives;
        pause = commands.Pause;
    }


}
