using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedestrianLight : MonoBehaviour
{
    GameObject walkLight;
    GameObject stopLight;

    public bool walk;
    float stopTime = 10f;
    float walkTime = 5f;
    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        walkLight = gameObject.transform.Find("Walk Light").gameObject;
        stopLight = gameObject.transform.Find("Stop Light").gameObject;
        if (Random.Range(0, 2) == 0)
        {
            walk = false;
            walkLight.SetActive(false);
            stopLight.SetActive(true);
        } else
        {
            walk = true;
            walkLight.SetActive(true);
            stopLight.SetActive(false);
        }

        StartCoroutine(PLight());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator PLight()
    {
        while (true)
        {
            if (walk)
            {
                yield return new WaitForSeconds(walkTime);
                walk = false;
                stopLight.SetActive(true);
                walkLight.SetActive(false);
            }

            yield return new WaitForSeconds(Random.Range(3, stopTime));
            walk = true;
            walkLight.SetActive(true);
            stopLight.SetActive(false);
        }
    }
}
