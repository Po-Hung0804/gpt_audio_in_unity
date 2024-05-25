using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class routine : MonoBehaviour
{
    // Start is called before the first frame update
    private NavMeshAgent agent;
    private LineRenderer line;
    private GameObject destination;
    private NavMeshPath path;
    void Start()
    {
        destination = GameObject.FindGameObjectWithTag("Finish");
        agent = transform.GetComponent<NavMeshAgent>();
        line = transform.GetComponent<LineRenderer>();
        agent.SetDestination(destination.transform.position);


    }

    // Update is called once per frame
    void Update()
    {
        
        if (agent.path.corners.Length > 1)
        {
            line.positionCount = agent.path.corners.Length;
            line.SetPositions(agent.path.corners);
        }

    }
}
