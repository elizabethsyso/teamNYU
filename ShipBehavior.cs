using UnityEngine;
using System.Collections;

public class ShipBehavior : MonoBehaviour {
	public int force;
	public bool stop;
	Rigidbody shipRigid;

	// Use this for initialization
	void Start () {
		stop = false;
		shipRigid = gameObject.rigidbody;
	
	}
	
	// Update is called once per frame
	void Update () {
				if (Input.GetKeyDown(KeyCode.A)) {
						shipRigid.AddForce (Vector3.left * force);		
				}
				if (Input.GetKeyDown (KeyCode.D)) {
						shipRigid.AddForce (Vector3.right * force);
				}
				if (Input.GetKeyDown (KeyCode.S)) {
						shipRigid.AddForce (Vector3.back * force);
				}
				if (Input.GetKeyDown (KeyCode.W)) {
						shipRigid.AddForce (Vector3.forward * force);
				}
		}
}
