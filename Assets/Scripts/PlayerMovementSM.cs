using UnityEngine;

public class PlayerMovementSM : PlayerStateMachine
{
    public float speed;
    public CharacterController control;
    public Animator anim;

    [HideInInspector]
    public PlayerIdle idleState;
    [HideInInspector]
    public PlayerMoving movingState;

    private void Awake()
    {
        idleState = new PlayerIdle(this);
        movingState = new PlayerMoving(this);
    }

    protected override PlayerBaseState GetInitialState()
    {
        return idleState;
    }
}
