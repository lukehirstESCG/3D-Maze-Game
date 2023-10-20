using UnityEngine;

public class playerIdle : PlayerBaseState
{
    private PlayerMovementSM playsm;
    private float horizontalInput;
    private float verticalInput;

    public playerIdle(PlayerMovementSM playsm) : base("Idle", playsm) { }

    public override void Enter()
    {
        base.Enter();
        horizontalInput = 0f;
        verticalInput = 0f;
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();
        {
            playsm.ChangeState(playsm.movingState);
           // playsm.anim.SetBool("move", true);
        }
    }
}
