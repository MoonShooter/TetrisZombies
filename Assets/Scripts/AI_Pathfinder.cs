using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Pathfinder : MonoBehaviour {

    public Transform target;

    Seeker seeker;
    Path path;
    int currentWaypoint;

	// Use this for initialization
	void Start () {
        seeker = GetComponent<Seeker>();
        seeker.StartPath(transform.position, target.position, OnPathComplete);
	}
	
    public void OnPathComplete(Path p)
    {
        if (!p.error)
        {
            path = p;
            currentWaypoint = 0;
        }
        else
        {
            Debug.Log(p.error);
        }
    }

	// Update is called once per frame
	void FixedUpdate () {
        if (path == null)
        {
            return;
        }

        if(currentWaypoint >= path.vectorPath.Count)
        {
            return;
        }

        transform.position = path.vectorPath[currentWaypoint];
        currentWaypoint++;
	}
}
