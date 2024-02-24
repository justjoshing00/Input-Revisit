using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Commands 
{
    public void MoveUp()
    {
        Debug.Log("moved up");
    }
    public void MoveDown()
    {
        Debug.Log("moved down");
    }
    public void MoveLeft()
    {
        Debug.Log("moved left");
    }
    public void MoveRight()
    {
        Debug.Log("moved right");
    }
    public void FirePrimary()
    {
        Debug.Log("Primary weapon fired");
    }
    public void FireSecondary()
    {
        Debug.Log("Secondary weapon fired");
    }
    public void SwitchMode()
    {
        Debug.Log("mode switched");
    }
    public void ChangeArmor()
    {
        Debug.Log("armortype changed");
    }
    public void Interact()
    {
        Debug.Log("interacted with gameobject");
    }
    public void EndTurn()
    {
        Debug.Log("turn ended");
    }
    public void ViewObjectives()
    {
        Debug.Log("opened objectives screen");
    }
    public void Pause()
    {
        Debug.Log("game paused");
    }
}
