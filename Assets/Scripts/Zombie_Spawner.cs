using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie_Spawner : MonoBehaviour {

    // Use this for initialization


    public float spawnRate;
    public GameObject ZombiePrefab;
    float overallTimer = 0f;
    public float changeSpeedAt;

    GameObject target;

    float timer;
    Vector3 loc;


	void Start () {

        target = GameObject.Find("Door");
        ZombiePrefab.GetComponent<AI_Pathfinder>().target = target.transform;
        loc = new Vector3(52f,1.1f,-5.2f);
	}
	
	// Update is called once per frame
	void Update () {

        timer += Time.deltaTime;
        overallTimer += Time.deltaTime;
        if(timer > spawnRate)
        {
            Instantiate(ZombiePrefab, loc, Quaternion.identity);

            timer = 0f;
        }

        if(spawnRate>.01 && overallTimer > changeSpeedAt)
        {
            spawnRate -= .05f;
            overallTimer = 0f;
        }
		
	}
}
