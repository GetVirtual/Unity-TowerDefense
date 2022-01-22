using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Move : MonoBehaviour
{

    public Transform goal;
    private Animator animator;
    private NavMeshAgent agent;


    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        
        agent.destination = goal.position;
        animator.Play("WalkForwardBattle");

    }

    private void Update()
    {

        if (agent.remainingDistance > 0)
        {
            //animator.Play("WalkForwardBattle");
            // animation zu ende spielen lassen?
        }

    }
}
    

