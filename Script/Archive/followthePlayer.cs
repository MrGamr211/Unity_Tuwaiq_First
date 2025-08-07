using UnityEngine;
using UnityEngine.AI;

public class followthePlayer : MonoBehaviour
{
    public Transform player;
    public NavMeshAgent agent;
    void Start()
    {
        
    }

    void Update()
    {
        if (agent.remainingDistance < 10)
        {
            agent.SetDestination(-player.position);
        }
        else
        {
            agent.SetDestination(player.position);
        }
    }
}
