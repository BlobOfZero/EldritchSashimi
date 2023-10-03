using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyRanged : MonoBehaviour
{
    public NavMeshAgent agent;

    public Transform player;

    public float speed;

    [SerializeField] private LayerMask WhatIsPlayer;

    [SerializeField] private bool IsChasing;

    [SerializeField] private bool IsAttacking;

    [SerializeField] private bool PlayerInAttackRange;

    [SerializeField] private float AttackRange;

    [SerializeField] private int  health = 3;

    void awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }
   
    // Update is called once per frame
    void Update()
    {
        PlayerInAttackRange = Physics.CheckSphere(transform.position, AttackRange, WhatIsPlayer);

        if (!PlayerInAttackRange)
        {            
            IsAttacking = false;
            IsChasing = true;
            Chasing();
        }

        if (PlayerInAttackRange)
        {
            IsChasing = false;
            IsAttacking = true;
        }           
        
    }


    void Chasing()
    {
        if (IsChasing) 
        {
            agent.SetDestination(player.position);
        }        
        transform.LookAt(player);      
    }

}
