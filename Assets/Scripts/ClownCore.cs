using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ClownCore : MonoBehaviour
{
    public NavMeshAgent agent;
    public CursorPointer cursorPointer;
    public ClownMover mover;

    private void Start()
    {
        agent.updatePosition = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            agent.SetDestination(cursorPointer.point);
        }

        mover.Move(agent.desiredVelocity);
        Debug.DrawLine(transform.position + Vector3.up * 0.5f, transform.position + Vector3.up * 0.5f + agent.desiredVelocity * 5, Color.cyan);
        //agent.nextPosition = transform.position;
    }
}
