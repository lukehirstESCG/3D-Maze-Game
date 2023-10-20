using UnityEngine;

public class enemyPatrol : EnemyBaseState
{
    public enemyPatrol(EnemyMovementSM esm) : base("Patrol", esm) { }

    public override void Enter()
    {
        base.Enter();
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();
    }

    public override void UpdatePhysics()
    {
        base.UpdatePhysics();
    }
}
