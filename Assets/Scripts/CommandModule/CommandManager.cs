using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class CommandManager
{
    Commands commands;
    public Action MoveUp; 
    public Action MoveDown;
    public Action MoveLeft;
    public Action MoveRight;
    public Action FirePrimary;
    public Action FireSecondary;
    public Action SwitchMode;
    public Action ChangeArmor;
    public Action Interact;
    public Action EndTurn;
    public Action ViewObjectives;
    public Action Pause;

    public CommandManager()
    {
        commands = new();
        MoveUp = commands.MoveUp;
        MoveDown = commands.MoveDown;
        MoveLeft = commands.MoveLeft;
        MoveRight = commands.MoveRight;
        FirePrimary = commands.FirePrimary;
        FireSecondary = commands.FireSecondary;
        SwitchMode = commands.SwitchMode;
        ChangeArmor = commands.ChangeArmor;
        Interact = commands.Interact;
        EndTurn = commands.EndTurn;
        ViewObjectives = commands.ViewObjectives;
        Pause = commands.Pause;
    }


}
