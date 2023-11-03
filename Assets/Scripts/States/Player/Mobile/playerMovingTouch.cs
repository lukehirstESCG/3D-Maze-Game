using UnityEngine;

public class playerMovingTouch : PlayerBaseState
{
    float horizontalInput;
    float verticalInput;
    private PlayerMovementMobileSM playsm;
    public playerMovingTouch(PlayerMovementMobileSM playerStateMachine) : base("Moving", playerStateMachine)
    {
        playsm = playerStateMachine;
    }

    public override void Enter()
    {
        base.Enter();
        horizontalInput = 0;
        verticalInput = 0;
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();

        horizontalInput = playsm.mobile.Horizontal;
        verticalInput = playsm.mobile.Vertical;
        float direction = new Vector2(horizontalInput, verticalInput).magnitude;

        if (direction <= 0.01f)
        {
            playerStateMachine.ChangeState(playsm.idleState);
            playsm.anim.SetBool("move", false);
        }
    }

    public override void UpdatePhysics()
    {
        base.UpdatePhysics();

        playsm.rotation = new Vector3(0, playsm.mobile.Horizontal * playsm.rotationSpeed * Time.deltaTime, 0);

        Vector3 move = new Vector3(0, 0, playsm.mobile.Vertical * Time.deltaTime);
        move = playsm.transform.TransformDirection(move);
        playsm.control.Move(move * playsm.speed);
        playsm.transform.Rotate(playsm.rotation);

        playsm.cam.transform.position = playsm.transform.position;
        playsm.cam.rotation = playsm.player.rotation;
    }
}