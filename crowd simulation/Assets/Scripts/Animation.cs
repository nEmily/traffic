using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Animation : MonoBehaviour
{
    [SerializeField] private Animator m_animator;
    NavMeshAgent nm;

    // Start is called before the first frame update
    void Start()
    {
        m_animator.SetBool("Grounded", true);
        nm = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        m_animator.SetFloat("MoveSpeed", nm.velocity.magnitude);

    }
}
