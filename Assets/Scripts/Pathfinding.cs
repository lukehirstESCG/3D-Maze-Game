using UnityEngine;
using UnityEngine.AI;

public class Pathfinding : MonoBehaviour
{
    public Transform[] points;
    private NavMeshAgent agent;
    private int dests;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void FixedUpdate()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.5)
        {
            GoToNextPoint();
        }
    }

    public void GoToNextPoint()
    {
        if (points.Length == 0)
        {
            return;
        }
        agent.destination = points[dests].position;
        dests = (dests + 1) % points.Length;
    }
}
