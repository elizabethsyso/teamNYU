using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {
	private int hits;
	ShipBehavior ship;
	RaceTime current;

	// Use this for initialization
	void Start () {
		hits = 0;
		ship = GameObject.FindWithTag ("Player").GetComponent<ShipBehavior> ();
		current = GameObject.FindWithTag ("Player").GetComponent<RaceTime> ();
	}
	
	// Update is called once per frame
	void Update () {
		print ( hits );
		if (ship.stop) {
			hits += 1;
		}
		if (hits == 72) {
			Application.LoadLevel(1);

		}
	}
}
