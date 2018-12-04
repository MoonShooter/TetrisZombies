using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Pathfinder : MonoBehaviour {

    public Transform target;
    float RotationSpeed = 100;
    public float movementSpeed;

    Seeker seeker;
    Path path;

    int currentWaypoint;
    float maxWaypointDistance = 2f;

    private Quaternion _lookRotation;
    private Vector3 _direction;
    private Vector3 _dir;

    CharacterController characterController;

	// Use this for initialization
	void Start () {
        seeker = GetComponent<Seeker>();
        seeker.StartPath(transform.position, target.position, OnPathComplete);
        characterController = GetComponent<CharacterController>();
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

        
        _direction = (path.vectorPath[currentWaypoint] - transform.position).normalized;

        _dir = _direction * movementSpeed;
       

        _lookRotation = Quaternion.LookRotation(_direction);

        transform.rotation = Quaternion.Slerp(transform.rotation, _lookRotation, Time.deltaTime * RotationSpeed);


        //transform.position = path.vectorPath[currentWaypoint];

        characterController.SimpleMove(_dir);

        if (Vector3.Distance(transform.position, path.vectorPath[currentWaypoint]) < maxWaypointDistance)
        {

            currentWaypoint++;

        }
	}
}
