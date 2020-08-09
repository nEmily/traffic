using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class Particle : MonoBehaviour
{
    public ParticleSystem system;
    [ReadOnly] public Vector3 position;
    [ReadOnly] public Vector3 last_position;

    // Start is called before the first frame update
    void Start()
    {
        //system.AddParticle(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
