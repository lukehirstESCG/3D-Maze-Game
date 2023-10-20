using UnityEngine;
using UnityEngine.AI;

public class EnemyMovementSM : EnemyStateMachine
{
    public Transform target;
    public Transform enemy;
    public Animator anim;
    public NavMeshAgent agent;
    public bool attacking = false;
    public Transform endPoint;
    public Transform startPoint;
    public Pathfinding pf;

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
