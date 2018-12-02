using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Pathfinder : MonoBehaviour {

    public Transform target;
    public float RotationSpeed;

    Seeker seeker;
    Path path;
    int currentWaypoint;

    private Quaternion _lookRotation;
    private Vector3 _direction;

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
	void Update () {
        if (path == null)
        {
            return;
        }

        if(currentWaypoint >= path.vectorPath.Count)
        {
            return;
        }

        
        _direction = (path.vectorPath[currentWaypoint] - transform.position).normalized;
       

        _lookRotation = Quaternion.LookRotation(_direction);

        transform.rotation = Quaternion.Slerp(transform.rotation, _lookRotation, Time.deltaTime * RotationSpeed);


        transform.position = path.vectorPath[currentWaypoint];

        currentWaypoint++;
	}
}
