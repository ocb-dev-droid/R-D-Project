using EasyPeasyFirstPersonController;
using UnityEngine;
using UnityEngine.AI;
public class EnemyMovement : MonoBehaviour
{
    private Transform target;
    private NavMeshAgent agent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = FindAnyObjectByType<FirstPersonController>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = target.position;
    }
}
