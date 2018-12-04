using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPP_Script : MonoBehaviour {

    //This Script should change the player's position depending on if they press Q or E

    GameObject player;
    public Vector3[] vantagePoints;

    int cPos = 0;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E))
        {
            cPos++;
            cPos = Mathf.Abs(cPos) % vantagePoints.Length;
            player.transform.position = vantagePoints[cPos];
            print("Up Switch " + cPos);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //Known Bug: Q may only switch between 0 and 1 when too low -- fix math too tired to do now
            cPos--;
            cPos = Mathf.Abs(cPos) % vantagePoints.Length;
            player.transform.position = vantagePoints[cPos];
            print("Down Switch " + cPos);
        }
    }
}
