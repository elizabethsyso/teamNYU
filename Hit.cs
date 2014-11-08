using UnityEngine;
using System.Collections;

public class Hit : MonoBehaviour {
	private bool stop = false;
	private float startTime;
	float gameTime;
	Rigidbody player;
	ShipBehavior ship;
	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag ("Player").rigidbody;
		ship = GameObject.FindWithTag ("Player").GetComponent<ShipBehavior> ();
	}
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag.CompareTo("Player")==0)
		{	
			stop = true;
			ship.stop = true;
			startTime = Time.time;
			Debug.Log(other.gameObject.tag+" hit Mercury");
		}
	}
	void FixedUpdate(){
		gameTime = (Time.time - startTime)%60;
		if (gameTime >= 8) {
			stop = false;
			ship.stop = false;
		}
		if (stop) {
			player.drag = 10;
			ship.force = 0;	
			ship.stop = true;
		} else {
			player.drag = 0;
			ship.force = 10;
		}
	}
}
