using UnityEngine;

public class enemyAttack : EnemyBaseState
{
    private EnemyMovementSM esm;
    public enemyAttack(EnemyMovementSM enemyStateMachine) : base("Attack", enemyStateMachine)
    {
        esm = enemyStateMachine;
    }

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

        esm.agent.SetDestination(esm.target.position);
    }
}
