using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal_Script : MonoBehaviour {

    //public bool EnteredTrigger;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Zombie")
        {
            Destroy(col.gameObject);
            print("Collided");
        }

    }
}
