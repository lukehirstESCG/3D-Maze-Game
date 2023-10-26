using UnityEngine;
using UnityEngine.AI;

public class EnemyMovementSM : EnemyStateMachine
{
    public Transform target;
    public Transform enemy;
    public float damage;
    public Transform[] points;
    public NavMeshAgent agent;
    public PlayerHealth pHealth;
    [HideInInspector]
    public int dests;
    public bool attacking = false;

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
