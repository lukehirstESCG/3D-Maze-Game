using UnityEngine;

public class playerIdleTouch : PlayerBaseState
{
    private PlayerMovementMobileSM playsm;
    float horizontalInput;
    float verticalInput;

    public playerIdleTouch(PlayerMovementMobileSM playerStateMachine) : base("Idle", playerStateMachine)
    {
        playsm = playerStateMachine;
    }

    public override void Enter()
    {
        base.Enter();
        horizontalInput = 0f;
        verticalInput = 0f;
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();

        horizontalInput = playsm.mobile.Horizontal;
        verticalInput = playsm.mobile.Vertical;
        float direction = new Vector2(horizontalInput, verticalInput).magnitude;

        if (direction > 0.01f)
        {
            playerStateMachine.ChangeState(playsm.movingState);
            playsm.anim.SetBool("move", true);
        }
    }
}