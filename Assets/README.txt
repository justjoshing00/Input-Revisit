Heres what I wanted out of this:

interfaces
-default behavior that I can override if neccessary
-the ability to quickly give that behaviour to a class

XInput classes
-different ways I can label and use groups of behaviors

commandmanger
-decouple commands from thier callers so that I can call commands from multiple places if I need to
without going through input (end turn is the most obvious example for needing that)

TODO:
-Fix GameLoop so that a call to ExecuteMovement calls the moveX functions on all interfaces that implement movement
-Implement IMovement, IInteraction, and IAction for TankInput and SoldierInput
-look at splitting commands into different kinds of commands
-figure out what to do with Pause()
-Make a final decision about this inheritance heiarchy for input
-Conform to C# naming conventions