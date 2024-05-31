using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = EnemyPooler.instance.target.position;
    }
}
