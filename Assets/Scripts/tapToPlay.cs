using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class tapToPlay : MonoBehaviour {

	public void tap()
	{
		SceneManager.LoadScene ("main1");
	}
}
