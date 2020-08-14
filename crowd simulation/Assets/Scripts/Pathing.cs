using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Pathing : MonoBehaviour
{
    public NavMeshAgent nm;
    public Transform dest;

    // Start is called before the first frame update
    void Start()
    {
        //nm = GetComponent<NavMeshAgent>();
        //nm.SetDestination(dest.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (dest && transform == dest) {
            Destroy(gameObject);
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
