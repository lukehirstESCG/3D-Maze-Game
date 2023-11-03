using UnityEngine;
using UnityEngine.UI;

public class PlayerMovementMobileSM : PlayerStateMachine
{
    public float speed = 5;
    public float rotationSpeed;
    public CharacterController control;
    public Transform player;
    public Transform cam;
    public VariableJoystick joystick;
    public Animator anim;
    public Vector3 direction;
    public Vector3 rotation;

    [HideInInspector]
    public playerIdleTouch idleState;
    [HideInInspector]
    public playerMovingTouch movingState;

    private void Awake()
    {
        idleState = new playerIdleTouch(this);
        movingState = new playerMovingTouch(this);
    }

    protected override PlayerBaseState GetInitialState()
    {
        return idleState;
    }
}
