using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Generator : MonoBehaviour
{
    //public float particleW;
    //public float particleH;
    public GameObject particle;
    public GameObject characterParent;
    public bool spawn = true;

    public float spawnTimer = 3f;
    List<Transform> destinations;

    // Start is called before the first frame update
    void Start()
    {
        destinations = gameObject.transform.parent.GetComponentsInChildren<Transform>().ToList<Transform>();
        destinations.Remove(gameObject.transform);
        destinations.Remove(gameObject.transform.parent);

        if (spawn)
        {
            StartCoroutine(Spawn());
        }
    }

    IEnumerator Spawn()
    {
        while (true) {
            Generate();
            yield return new WaitForSeconds(Random.Range(spawnTimer - 1, spawnTimer + 1));
        }
    }

    void Generate()
    {
        GameObject p = Instantiate(particle, gameObject.transform.position, Quaternion.identity);
        p.transform.parent = characterParent.transform;
        p.GetComponent<Pathing>().SetDest(destinations[Random.Range(0, destinations.Count)]);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collision");
        if (other.CompareTag("Player") && other.GetComponent<Pathing>().dest == gameObject.transform)
        {
            Debug.Log("desparning////");
            other.GetComponent<Pathing>().DeSpawn();
        }
    }

    //void GenerateBox()
    //{
    //    Collider box = gameObject.GetComponent<BoxCollider>();
    //    Vector3 size = box.bounds.max - box.bounds.min;
    //    Vector3 origin = new Vector3(box.bounds.min.x + particleW / 2, 1, box.bounds.min.z + particleH / 2);
    //    for (int i = 0; i < size.x / particleW; i++)
    //    {
    //        for (int j = 0; j < size.y / particleH; j++)
    //        {
    //            GameObject p = Instantiate(particle, origin + new Vector3(i * particleW, 0, j * particleH), Quaternion.identity);
    //            p.transform.parent = transform.parent;
    //            p.GetComponent<Pathing>().SetDest(destinations[Random.Range(0, destinations.Count)].position);
    //        }
    //    }
    //}
}
