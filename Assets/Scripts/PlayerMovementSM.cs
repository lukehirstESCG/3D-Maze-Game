using UnityEngine;
using UnityEngine.UI;

public class PlayerMovementSM : PlayerStateMachine
{
    public float speed = 5;
    public float rotationSpeed;
    public CharacterController control;
    public Transform player;
    public Transform cam;
    public Animator anim;
    public Vector3 direction;
    public Vector3 rotation;

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
