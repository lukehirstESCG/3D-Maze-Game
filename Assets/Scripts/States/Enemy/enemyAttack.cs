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

        if (Vector3.Distance(esm.target.position, esm.enemy.transform.position) > 2)
        {
            enemyStateMachine.ChangeState(esm.patrolState);
        }
    }

    public override void UpdatePhysics()
    {
        base.UpdatePhysics();

        // Chase the player
        esm.agent.SetDestination(esm.target.position);
    }
}
