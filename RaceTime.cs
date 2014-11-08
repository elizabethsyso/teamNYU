using UnityEngine;
using System.Collections;

public class RaceTime : MonoBehaviour {
	private float startTime;
	public bool stop;
	float gameTime;
	GUIText textTime;
	// Use this for initialization
	void Start () {
		startTime = Time.time;
		stop = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		gameTime = (Time.time - startTime) % 60;
		if (gameTime >= 40) {
			stop = true;
		}
	}
	void OnGUI(){
		GUIStyle a = new GUIStyle();
		a.normal.background = null;
		a.normal.textColor = new Color(1,0,0);
		a.fontSize = 20;
		if (stop) {
			GUI.TextField (new Rect(50, 50, 100, 100), "Stop", a);		
		}
	//	GUI.TextField(new Rect(320,280,200,200), guiTime.ToString, a);
		
		//		if (GUI.Button(new Rect(500,300,50,50), "Restart", a))  
		//			Application.LoadLevel(0);
	}
}
