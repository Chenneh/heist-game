﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellGuardMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Transform[] patrolWayPoints;
    public float stoppingDistance = 0.1f;

    private int direction = 1;
    private CellGuardState guardState;
    private int wayPointIndex;

    // Start is called before the first frame update
    void Start()
    {
        guardState = GetComponent<CellGuardState>();
        wayPointIndex = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (guardState.mState == CellGuardState.AIState.normal)
        {
            float step = moveSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, patrolWayPoints[wayPointIndex].position, step);

            if(Vector3.Distance(transform.position, patrolWayPoints[wayPointIndex].position) < stoppingDistance)
            {
                if (wayPointIndex == patrolWayPoints.Length - 1)
                    wayPointIndex = 0;
                else
                    wayPointIndex++;

                transform.LookAt(patrolWayPoints[wayPointIndex]);
            }
        }
    }
}

