using UnityEngine;

public class enemyIdle : EnemyBaseState
{
    public enemyIdle(EnemyMovementSM esm) : base("Idle", esm) { }

    public override void Enter()
    {
        base.Enter();
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();
    }
}
