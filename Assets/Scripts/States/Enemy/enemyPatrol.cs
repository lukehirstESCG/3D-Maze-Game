using UnityEngine;

public class enemyPatrol : EnemyBaseState
{
    private EnemyMovementSM esm;
    public enemyPatrol(EnemyMovementSM enemyStateMachine) : base("Patrol", enemyStateMachine)
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
            if (Vector3.Distance(esm.target.transform.position, esm.enemy.transform.position) > 8)
            {
                enemyStateMachine.ChangeState(esm.idleState);
            }

            if (Vector3.Distance(esm.target.position, esm.enemy.transform.position) <= 3)
            {
                enemyStateMachine.ChangeState(esm.attackState);                
            }
        }
    }

    public override void UpdatePhysics()
    {
        base.UpdatePhysics();
        {
            if (!esm.agent.pathPending && esm.agent.remainingDistance < 0.5f)
            {
                GoToNextPoint();
            }

            void GoToNextPoint()
            {
                if (esm.points.Length == 0)
                {
                    return;
                }
                esm.agent.destination = esm.points[esm.dests].position;
                esm.dests = (esm.dests + 1) % esm.points.Length;
            }

        }
    }
}
