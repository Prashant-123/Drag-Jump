using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveAll : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position = gameObject.transform.position + new Vector3 (0.05f, 0, 0);
	}
}
