using UnityEngine;
using UnityEngine.AI;

public class EnemyMovementSM : EnemyStateMachine
{
    public Transform target;
    public Transform enemy;
    public NavMeshAgent agent;
    [HideInInspector]
    public int dests;
    public bool attacking = false;
    public Transform[] points;

    [HideInInspector]
    public enemyIdle idleState;
    [HideInInspector]
    public enemyPatrol patrolState;
    [HideInInspector]
    public enemyAttack attackState;

    private void Awake()
    {
        idleState = new enemyIdle(this);
        patrolState = new enemyPatrol(this);
        attackState = new enemyAttack(this);
    }

    protected override EnemyBaseState GetInitialState()
    {
        return idleState;
    }
}
