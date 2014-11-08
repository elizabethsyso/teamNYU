using UnityEngine;
using System.Collections;

public class RaceTime : MonoBehaviour {
	Hit text;
	private bool stop = false;
	private float startTime;
	float gameTime;
	GUIText textTime;
	// Use this for initialization
	void Start () {
		startTime = Time.time;
		text = GameObject.FindGameObjectWithTag ("Planets").GetComponent<Hit> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		gameTime = (Time.time - startTime)%60;
		if (gameTime >= 3) {
			stop = true;
		}
        
	}
	void OnGUI(){
		GUIStyle a = new GUIStyle();
		a.normal.background = null;
		a.normal.textColor = new Color(1,0,0);
		a.fontSize = 20;
		if (stop == true) {
			GUI.TextField (new Rect(50, 50, 100, 100), "Stop", a);		
		}
		if(text.stop1 == true)
		{
			GUI.Label (new Rect(20, 20, 100,20), "Mercury" +
				"This is the smallest and closest planet to the Sun.");
		}

	//	GUI.TextField(new Rect(320,280,200,200), guiTime.ToString, a);
		
		//		if (GUI.Button(new Rect(500,300,50,50), "Restart", a))  
		//			Application.LoadLevel(0);
	}
}
