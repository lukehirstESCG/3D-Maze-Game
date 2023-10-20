using UnityEngine;

public class playerMoving : PlayerBaseState
{
    private float horizontalInput;
    private float verticalInput;
    private PlayerMovementSM playsm;
    public playerMoving(PlayerMovementSM playerStateMachine) : base("Moving", playerStateMachine)
    {
        playsm = playerStateMachine;
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();

        if (playsm.direction.magnitude <= 0.01f)
        {
            playerStateMachine.ChangeState(playsm.idleState);
          // playsm.anim.SetBool("move", false);
        }    
    }

    public override void UpdatePhysics()
    {
        base.UpdatePhysics();

        playsm.control.Move(playsm.direction * playsm.speed * Time.deltaTime);
        playsm.direction = new Vector3(horizontalInput, 0f, verticalInput).normalized;
    }
}
