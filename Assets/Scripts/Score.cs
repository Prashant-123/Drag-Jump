using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

	public float score = 0.0f;
	void OnTriggerExit()
	{
		score++;
		Debug.Log (score);
}
}