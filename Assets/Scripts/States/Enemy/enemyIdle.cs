using UnityEngine;

public class enemyIdle : EnemyBaseState
{
    private EnemyMovementSM esm;
    public enemyIdle(EnemyMovementSM enemyStateMachine) : base("Idle", enemyStateMachine)
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
        {
            if (Vector3.Distance(esm.enemy.transform.position, esm.target.position) <= 8)
            {
                enemyStateMachine.ChangeState(esm.patrolState);
            }
        }
    }
}
