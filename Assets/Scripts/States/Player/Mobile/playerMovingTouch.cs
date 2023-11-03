using UnityEngine;

public class playerMovingTouch : PlayerBaseState
{
    float horizontalInput;
    float verticalInput;
    private PlayerMovementMobileSM playsme;
    public playerMovingTouch(PlayerMovementMobileSM playerStateMachine) : base("Moving", playerStateMachine)
    {
        playsme = playerStateMachine;
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

        horizontalInput = playsme.joystick.Horizontal;
        verticalInput = playsme.joystick.Vertical;
        float direction = new Vector2(horizontalInput, verticalInput).magnitude;

        if (direction <= 0.01)
        {
            playerStateMachine.ChangeState(playsme.idleState);
            playsme.anim.SetBool("move", false);
        }
    }

    public override void UpdatePhysics()
    {
        base.UpdatePhysics();

        playsme.rotation = new Vector3(0, playsme.joystick.Horizontal * playsme.rotationSpeed * Time.deltaTime, 0);

        Vector3 move = new Vector3(0, 0, playsme.joystick.Vertical * Time.deltaTime);
        move = playsme.transform.TransformDirection(move);
        playsme.control.Move(move * playsme.speed);
        playsme.transform.Rotate(playsme.rotation);

        playsme.cam.transform.position = playsme.transform.position;
        playsme.cam.rotation = playsme.player.rotation;
    }
}