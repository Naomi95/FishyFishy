using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedFishClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void OnMouseDown(){
		//Destroy (gameObject);
		SceneManager.LoadScene ("MainGame 2");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
