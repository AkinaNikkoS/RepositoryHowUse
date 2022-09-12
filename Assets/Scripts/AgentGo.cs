using UnityEngine.AI;
using UnityEngine;

public class AgentGo : MonoBehaviour
{
    public Transform Goal;

    void Update()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = Goal.position;
    }
}
