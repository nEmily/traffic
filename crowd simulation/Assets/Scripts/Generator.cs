using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public float particleW;
    public float particleH;
    public GameObject particle;
    public List<Transform> destinations;

    // Start is called before the first frame update
    void Start()
    {
        Collider box = GetComponent<BoxCollider>();
        Vector3 size = box.bounds.max - box.bounds.min;
        Vector3 origin = new Vector3(box.bounds.min.x + particleW / 2, 1, box.bounds.min.z + particleH / 2);
        for (int i = 0; i < size.x / particleW; i++)
        {
            for (int j = 0; j < size.y / particleH; j++)
            {
                GameObject p = Instantiate(particle, origin + new Vector3(i * particleW, 0, j * particleH), Quaternion.identity);
                p.transform.parent = transform.parent;
                //p.GetComponent<Pathing>().SetDest(destinations[1].position);
            }
        }


        Debug.Log("done!");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
