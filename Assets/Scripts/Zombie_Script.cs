using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie_Script : MonoBehaviour {

    //Later: Adapt this code such that each body part destroyed causes a different effect
    //example: shooting an arm produces points w/o killing a zombie
    //shooting a head kills the zombie, removing the posibility to farm more points
    public int health = 10;


	void Start () {

	}

    void DeductPoints(int DamageAmount)
    {
        health -= DamageAmount;
        print("Hit Zombie!");
    }

    // Update is called once per frame
    void Update () {
        if(health <= 0)
        {
            Destroy(gameObject);
        }
	}




}
