using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

using UnityEngine.AI;

public class EnimyAI : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent agent;

    public Transform Player;

    public LayerMask GroundMask;
    public LayerMask PlayerMask;

    //walk
    public Vector3 walkPoint;
    public float walkPointRange;

    public bool WalkPointSet;

    public float timeBetweenAtt;
    bool alreadyAccacked;

    public float sightRange, attackRange;
    public bool PLayerInSightRange, PlayerInAttackRange;



    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        PLayerInSightRange = Physics.CheckSphere(transform.position, sightRange, PlayerMask);
        PLayerInSightRange = Physics.CheckSphere(transform.position, attackRange, GroundMask);

        if (!PLayerInSightRange && !PLayerInSightRange)
        {
            Walking();
        }
        if (PLayerInSightRange && !PlayerInAttackRange)
        {
            chasePlayer();
        }
        if (PLayerInSightRange && PLayerInSightRange)
        {
            attackPlayer();
        }
    }

    void SearchWalk()
    {
        float RandonX = Random.Range(-walkPointRange, walkPointRange);

        float RandonZ = Random.Range(-walkPointRange, walkPointRange);

        walkPoint = new Vector3(transform.position.x + RandonX, transform.position.y, transform.position.z + RandonZ);

        if (Physics.Raycast(walkPoint,-transform.up, 2f, GroundMask))
        {
            WalkPointSet = true;
        }
    }

    void Walking()
    {
        if (!WalkPointSet)
        {
            SearchWalk();
        }

        if (WalkPointSet)
        {
            agent.SetDestination(walkPoint);
        }

        Vector3 distanceWalkPoint = transform.position - walkPoint;

        if (distanceWalkPoint.magnitude < 1f)
        {
            WalkPointSet = false;
        }

    }

    void chasePlayer()
    {
        agent.SetDestination(Player.position);
    }
    void attackPlayer()
    {

        
    }
}
