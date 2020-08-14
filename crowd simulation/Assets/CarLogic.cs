using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CarLogic : MonoBehaviour
{
    public List<Transform> carStops;
    int i = 0;
    NavMeshAgent nm;
    // Start is called before the first frame update
    void Start()
    {
        if (NavMesh.SamplePosition(transform.position, out NavMeshHit hit, 500, 1))
        {
            transform.position = hit.position;
        }
        nm = GetComponent<NavMeshAgent>();
        nm.enabled = true;
        nm.SetAreaCost(0, 5);
        nm.SetAreaCost(3, 1);
        nm.SetDestination(carStops[i].position);
    }

    // Update is called once per frame
    void Update()
    {
        if (nm.pathStatus == NavMeshPathStatus.PathComplete)
        {
            i = (i + 1) % carStops.Count;
            nm.SetDestination(carStops[i].position);
        }
    }
}
