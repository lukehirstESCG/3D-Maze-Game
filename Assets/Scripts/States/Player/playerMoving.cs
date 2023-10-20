using UnityEngine;

public class playerMoving : PlayerBaseState
{
    private float horizontalInput;
    private float verticalInput;
    private PlayerMovementSM playsm;
    public playerMoving(PlayerMovementSM playsm) : base("Moving", playsm) { }

    public override void Enter()
    {
        base.Enter();
        horizontalInput = 0;
        verticalInput = 0;
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();

        if (Mathf.Abs(horizontalInput) < Mathf.Abs(verticalInput) || Mathf.Abs(verticalInput) < Mathf.Abs(horizontalInput))
        {
            playsm.ChangeState(playsm.idleState);
            playsm.anim.SetBool("move", false);
        }    
    }

    public override void UpdatePhysics()
    {
        base.UpdatePhysics();

        playsm.rotation = new Vector3(0, Input.GetAxis("Horizontal") * playsm.rotationSpeed * Time.deltaTime, 0);

        Vector3 move = new Vector3(0, 0, Input.GetAxisRaw("Vertical") * Time.deltaTime);
        move = playsm.transform.TransformDirection(move);
        playsm.control.Move(move * playsm.speed);
        playsm.transform.Rotate(playsm.rotation);
    }
}
