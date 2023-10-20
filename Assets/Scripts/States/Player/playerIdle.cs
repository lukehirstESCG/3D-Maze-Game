using UnityEngine;

public class playerIdle : PlayerBaseState
{
    public playerIdle(PlayerMovementSM playsm) : base("Idle", playsm) { }

    public override void Enter()
    {
        base.Enter();
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();
    }
}
