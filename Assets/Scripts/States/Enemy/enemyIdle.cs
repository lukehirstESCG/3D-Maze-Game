using UnityEngine;

public class enemyIdle : EnemyBaseState
{
    private EnemyMovementSM esm;
    public enemyIdle(EnemyMovementSM esm) : base("Idle", esm) { }

    public override void Enter()
    {
        base.Enter();
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();

        if (esm.agent.transform.position == esm.startPoint.transform.position)
        {
            enemyStateMachine.ChangeState(esm.patrolState);
            Debug.Log("PATROLLING");
        }
    }
}
