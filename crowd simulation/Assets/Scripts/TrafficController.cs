using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class TrafficController : MonoBehaviour
{
    public List<GameObject> trafficLights;
    private void Awake()
    {
        trafficLights = GameObject.FindGameObjectsWithTag("Traffic Light").ToList<GameObject>();
    }

    public int CanWalk(Vector3 pos, Vector3 next)
    {
        foreach (GameObject light in trafficLights)
        {

            if (light.GetComponent<BoxCollider>().bounds.Contains(pos))
            {
                if (!light.GetComponent<PedestrianLight>().walk)
                {
                    return 2;
                }
            }

            if (light.GetComponent<BoxCollider>().bounds.Contains(next))
            {
                if (!light.GetComponent<PedestrianLight>().walk)
                {
                    return 0;
                }
            }
        }

        return 1;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
