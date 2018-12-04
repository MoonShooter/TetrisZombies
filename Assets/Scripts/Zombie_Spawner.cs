using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie_Spawner : MonoBehaviour {

    // Use this for initialization


    public float spawnRate;
    public GameObject ZombiePrefab;

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
        if(timer > spawnRate)
        {
            Instantiate(ZombiePrefab, loc, Quaternion.identity);

            timer = 0f;
        }
		
	}
}
