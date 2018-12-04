using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handgun_Damage_Script : MonoBehaviour {

    public int DamageAmount = 5;
    public float targetDistance;
    public float AllowedRange = 200;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            RaycastHit Shot;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))
            {
                targetDistance = Shot.distance;
                if (targetDistance < AllowedRange)
                {
                    print("Raycast_Fired");
                    Shot.transform.SendMessage("DeductPoints", DamageAmount, SendMessageOptions.DontRequireReceiver);
                }
            }
        }
    }
}

