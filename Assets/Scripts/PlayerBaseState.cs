using UnityEngine;

public class PlayerBaseState
{
    public string name;
    protected PlayerStateMachine playsm;

    public PlayerBaseState(string name, PlayerStateMachine playsm)
    {
        this.name = name;
        this.playsm = playsm;
    }

    public virtual void Enter() { }
    public virtual void UpdateLogic() { }

    public virtual void UpdatePhysics() { }

    public virtual void Exit() { }

 }
