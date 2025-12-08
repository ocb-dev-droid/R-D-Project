using EasyPeasyFirstPersonController;
using UnityEngine;
using UnityEngine.AI;
public class EnemyMovement : MonoBehaviour
{
    private Transform target;
    private NavMeshAgent agent;
    public bool inrange = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = FindAnyObjectByType<FirstPersonController>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(inrange)
            agent.destination = target.position;

        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            inrange = true;
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            inrange = false;
        }
    }
}
