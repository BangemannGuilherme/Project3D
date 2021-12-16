using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
	public int points = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	/*public void OnTriggerEnter(Collider points)
	{
		if (points.gameObject.tag == "Coins") {
			Debug.Log ("Moeda coletada!");
			points = points + 1;
			Destroy(points.gameObject);
		}
	}*/

	private void OnGUI()
	{
		GUI.Label (new Rect(10, 10, 100, 20), "Pontuação: " + points);		
	}
}
