using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie_Script : MonoBehaviour {

    // Use this for initialization

    GameObject go;
    GameObject goal;

	void Start () {
        go = this.gameObject;
        goal = GameObject.FindGameObjectWithTag("Goal");
	}
	
	// Update is called once per frame
	void Update () {
        
	}


}
