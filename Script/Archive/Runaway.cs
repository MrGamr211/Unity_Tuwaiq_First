using UnityEngine;
using UnityEngine.AI;

public class Runaway : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;
    void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        if (agent.stoppingDistance == 10 + 2)
        {
            agent.SetDestination(-player.position);
        }
        else
        {
            agent.SetDestination(player.position);
        }
    }
}
