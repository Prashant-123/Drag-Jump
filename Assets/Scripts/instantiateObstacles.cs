using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiateObstacles : MonoBehaviour {
	public GameObject obstacle;
	private int randomValue;
	private GameObject player;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		//GameObject.Find ("Over").SetActive (false);
		inst();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void inst()
	{
		randomValue = Random.Range (0, 7);
		//yield return new WaitForSeconds (5);
		//if(player.activeSelf == true)

		Instantiate (obstacle,  new Vector3(player.transform.position.x + 3, Random.Range(1f, -3f), -9), Quaternion.identity);
		//yield return new WaitForSeconds (5);
		Invoke ("inst", 2.3f);
	}

}
