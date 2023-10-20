using UnityEngine;

public class enemyPatrol : EnemyBaseState
{
    private EnemyMovementSM esm;
    public enemyPatrol(EnemyMovementSM esm) : base("Patrol", esm) { }

    public override void Enter()
    {
        base.Enter();
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();

        if (esm.agent.transform.position == esm.endPoint.transform.position)
        {
            enemyStateMachine.ChangeState(esm.idleState);
            Debug.Log("IDLE!");
        }
    }

    public override void UpdatePhysics()
    {
        base.UpdatePhysics();
        
        esm.pf.GoToNextPoint();
    }
}
