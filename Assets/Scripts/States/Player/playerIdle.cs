using UnityEngine;

public class playerIdle : PlayerBaseState
{
    private PlayerMovementSM playsm;
    float horizontalInput;
    float verticalInput;

    public playerIdle(PlayerMovementSM playerStateMachine) : base("Idle", playerStateMachine)
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

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        float direction = new Vector2(horizontalInput, verticalInput).magnitude;

        if (direction > 0.01f)
        {
            playerStateMachine.ChangeState(playsm.movingState);
            playsm.anim.SetBool("move", true);
        }
    }
}