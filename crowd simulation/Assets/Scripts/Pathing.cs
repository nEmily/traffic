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
        nm = GetComponent<NavMeshAgent>();
        nm.SetDestination(dest.position);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetDest(Vector3 dest)
    {
        nm = GetComponent<NavMeshAgent>();
        nm.SetDestination(dest);
    }
}
