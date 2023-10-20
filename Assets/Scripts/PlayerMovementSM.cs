using UnityEngine;

public class PlayerMovementSM : PlayerStateMachine
{
    public float speed = 5;
    public CharacterController control;
    public float rotationSpeed;
    public Transform Player;
    public Vector3 direction;
   // public Animator anim;

    [HideInInspector]
    public playerIdle idleState;
    [HideInInspector]
    public playerMoving movingState;

    private void Awake()
    {
        idleState = new playerIdle(this);
        movingState = new playerMoving(this);
    }

    protected override PlayerBaseState GetInitialState()
    {
        return idleState;
    }
}
