using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Pathing : MonoBehaviour
{
    NavMeshAgent nm;
    public Transform dest;
    TrafficController trafficController;

    // Start is called before the first frame update
    void Start()
    {
        trafficController = GameObject.Find("Traffic Controller").GetComponent<TrafficController>();
        nm = GetComponent<NavMeshAgent>();
        nm.SetDestination(dest.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (dest && transform == dest)
        {
            Destroy(gameObject);
        }

        nm.SamplePathPosition(NavMesh.AllAreas, 2f, out NavMeshHit hit);
        int x = trafficController.CanWalk(transform.position, hit.position);
        if (x == 0)
        {
            nm.velocity = Vector3.zero;
        } else if (x == 2)
        {
            nm.velocity *= (3/2);
        }

    }

    public void SetDest(Transform t)
    {
        nm = GetComponent<NavMeshAgent>();
        dest = t;
        nm.SetDestination(t.position);
    }

    public void DeSpawn()
    {
        Destroy(gameObject);
    }
}
