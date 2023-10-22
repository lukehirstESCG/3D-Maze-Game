using UnityEngine.AI;
using UnityEngine;
using NUnit.Framework.Internal;

public class enemyPatrol : EnemyBaseState
{
    private EnemyMovementSM esm;
    public enemyPatrol(EnemyMovementSM enemyStateMachine) : base("Patrol", enemyStateMachine) { }

    public override void Enter()
    {
        base.Enter();
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();
        {
           
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
