using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour {

	public GameObject fishWithCrown;
	GameObject fishPrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.A)){
			Debug.Log ("hoi");
			fishPrefab = Instantiate (fishWithCrown, transform.position, transform.rotation) as GameObject;

		}
		
	}
}
