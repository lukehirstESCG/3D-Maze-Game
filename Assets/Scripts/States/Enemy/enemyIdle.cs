using UnityEngine;

public class enemyIdle : EnemyBaseState
{
    private EnemyMovementSM esm;
    public float proximity;
    public enemyIdle(EnemyMovementSM enemyStateMachine) : base("Idle", enemyStateMachine) { }

    public override void Enter()
    {
        base.Enter();
    }

    public override void UpdateLogic()
    {
        base.UpdateLogic();
        {
            // Get the enemy position in relation to the player position.
           float dist = Vector3.Distance(esm.enemy.transform.position, esm.target.transform.position);

            float proximity = 2;

            if (dist <= proximity)
            {
                enemyStateMachine.ChangeState(esm.patrolState);
            }
        }
    }
}
