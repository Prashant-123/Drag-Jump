using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;
public class GameOver : MonoBehaviour {

	public GameObject movementManager;
	public GameObject overCanvas;
	public GameObject prevCanvas;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnCollisionEnter (Collision other) {
	//	SceneManager.LoadScene ("Over");
		movementManager.GetComponent<movement>().enabled = false;
		Time.timeScale = 0;
		Advertisement.Show ();
		overCanvas.SetActive (true);
		prevCanvas.SetActive (false);
		GameObject.FindGameObjectWithTag ("Player").SetActive (false);
		//Destroy(gameObject);

	}
}
