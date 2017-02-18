using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FishClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//OnMouseDown ();

	}

	void OnMouseDown(){
		//Destroy (gameObject);
		SceneManager.LoadScene ("MainGame");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
