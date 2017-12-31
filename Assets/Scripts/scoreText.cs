using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scoreText : MonoBehaviour {
	public Score _score;
	public Text scoretext1, scoretext2;
	// Use this for initialization
	void Start () {
		_score = GameObject.Find ("Capsule").GetComponent<Score> ();
	}
	
	// Update is called once per frame
	void Update () {
		scoretext1.text = _score.score.ToString();
		scoretext2.text = _score.score.ToString();
	}
}