using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GreenFishClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void OnMouseDown(){
		//Destroy (gameObject);
		SceneManager.LoadScene ("MainGame 3");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
