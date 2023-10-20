using UnityEngine;

public class enemyAttack : EnemyBaseState
{
    public enemyAttack(EnemyMovementSM esm) : base("Attack", esm) { }

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
