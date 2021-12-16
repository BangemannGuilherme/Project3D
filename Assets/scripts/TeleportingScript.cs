using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportingScript : MonoBehaviour {

	public Transform teleportTarget;
	public GameObject thePlayer;

	void OnTriggerEnter(Collider other)
	{
		thePlayer.transform.position = teleportTarget.transform.position;
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
