using UnityEngine;

public class EnemyBaseState
{
    public string name;
    protected EnemyStateMachine esm;

    public EnemyBaseState(string name, EnemyStateMachine esm)
    {
        this.name = name;
        this.esm = esm;
    }

    public virtual void Enter() { }
    public virtual void UpdateLogic() { }
    public virtual void UpdatePhysics() { }
    public virtual void Exit() { }

}
