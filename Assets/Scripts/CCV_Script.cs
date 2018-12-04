using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCV_Script : MonoBehaviour {
    //Change Camera View Script
    //Should also enable TETRIS MODE!!!!!!!!!!!

    Camera playerCamera;
    Camera tetrisCamera;
    GameObject aimingReticle;
    bool showAim;
    
	// Use this for initialization
	void Start () {
        playerCamera = GameObject.Find("FirstPersonCharacter").GetComponent<Camera>();
        tetrisCamera = GameObject.Find("Tetris_Camera").GetComponent<Camera>();
        aimingReticle = GameObject.Find("Aiming_Reticle");

        playerCamera.enabled = true;
        tetrisCamera.enabled = false;
        showAim = true;
        aimingReticle.SetActive(showAim);
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            print("dewit");
            playerCamera.enabled = !playerCamera.enabled;
            tetrisCamera.enabled = !tetrisCamera.enabled;
            showAim = !showAim;
            aimingReticle.SetActive(showAim);
        }
		
	}
}
