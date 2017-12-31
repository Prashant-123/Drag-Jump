using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeTex : MonoBehaviour {

	public Texture texture1, texture2;
	// Use this for initialization
	void Start () {
		//InvokeRepeating ("set", 0.3f, 0.3f);

	}
	/*
	IEnumerator Change()
	{
		gameObject.GetComponent<Renderer> ().material.SetTexture("_MainTex", texture1);
		yield return new WaitForSeconds (1);
		gameObject.GetComponent<Renderer> ().material.SetTexture("_MainTex", texture2);
		yield return new WaitForSeconds (1);

	}

	void Update()
	{
		//StartCoroutine(Change);
	}*/
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) {
			gameObject.GetComponent<Renderer> ().material.SetTexture("_MainTex", texture2);
		
		}
		else
		gameObject.GetComponent<Renderer> ().material.SetTexture("_MainTex", texture1);
	}

	/*void set()
	{

		Debug.Log ("2");
		//yield return new WaitForSeconds (1);
	}*/

}