using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public float particleW;
    public float particleH;
    public GameObject particle;

    // Start is called before the first frame update
    void Start()
    {
        Collider box = GetComponent<BoxCollider>();
        Vector3 size = box.bounds.max - box.bounds.min;

        for (int i = 0; i < size.x / particleW; i++)
        {
            for (int j = 0; i < size.y / particleH; j++)
            {
                Instantiate(particle, new Vector3(i * particleW, 1, j * particleH), Quaternion.identity, transform.parent);
                Debug.Log("help!");
            }
        }
        Debug.Log("done!");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
