using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

	private GameObject player;
	public float jumpPower;
	private Vector3 pos;
	//private Vector3 force;
	private float checkpos = -2.0f;

	void Start () {
		Time.timeScale = 1.5f;
		player = GameObject.FindGameObjectWithTag("Player");
	
	}

	void FixedUpdate()
	{
		if (Input.GetMouseButtonDown(0)) 
			gameObject.GetComponent<AudioSource> ().Play ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0)) {
			//gameObject.GetComponent<AudioSource> ().Play ();
			if (player.transform.position.y > checkpos) {
			

				player.GetComponent<Rigidbody> ().AddForce (Vector2.up * jumpPower * 0.2f);

			} else {

				player.GetComponent<Rigidbody> ().AddForce ((Vector2.up + (new Vector2 (0, 0.3f))) * jumpPower);
			}
		} else {
			player.transform.position = player.transform.position + new Vector3 (0, -0.01f, 0);
		}
		checkpos = player.transform.position.y;

	}
}
