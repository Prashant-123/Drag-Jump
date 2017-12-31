using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTimings : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate()
	{ 
		// If the left mouse button is pressed down...
		if(Input.GetMouseButtonDown(0)==true)
		{
			GetComponent<AudioSource>().Play();
		}
	}
}