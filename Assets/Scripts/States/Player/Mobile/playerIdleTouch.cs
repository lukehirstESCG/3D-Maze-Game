using UnityEngine;

public class playerIdleTouch : PlayerBaseState
{
    private PlayerMovementMobileSM playsme;
    float horizontalInput;
    float verticalInput;

    public playerIdleTouch(PlayerMovementMobileSM playerStateMachine) : base("Idle", playerStateMachine)
    {
        playsme = playerStateMachine;
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

        horizontalInput = playsme.joystick.Horizontal;
        verticalInput = playsme.joystick.Vertical;
        float direction = new Vector2(horizontalInput, verticalInput).magnitude;

        if (direction > 0.01f)
        {
            playerStateMachine.ChangeState(playsme.movingState);
            playsme.anim.SetBool("move", true);
        }
    }
}