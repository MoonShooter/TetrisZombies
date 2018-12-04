using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M9_Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //print("Fire");
            GetComponent<Animation>().Play("Gunshot");
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            print("Switch");
        }
        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            print("Alt Camera");
        }
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            print("Tetris");
        }
		
	}
}
