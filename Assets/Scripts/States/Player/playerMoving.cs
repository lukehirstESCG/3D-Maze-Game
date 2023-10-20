using UnityEngine;

public class playerMoving : PlayerBaseState
{
    public playerMoving(PlayerMovementSM playsm) : base("Moving", playsm) { }

    public override void Enter()
    {
        base.Enter();
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();
    }

    public override void UpdatePhysics()
    {
        base.UpdatePhysics();
    }
}
