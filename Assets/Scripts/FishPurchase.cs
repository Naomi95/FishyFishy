using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishPurchase : MonoBehaviour {

	// Use this for initialization
	private MedalHandler medalHandler;

	public GameObject yellowFish;
	GameObject fishPrefab;

	void Start () {

		medalHandler = MedalHandler.Getinstance ();
	}

	public void OnClick(){

		if(medalHandler.medals >= 1){
			medalHandler.DecreaseMedal (1);
			fishPrefab = Instantiate (yellowFish, transform.position, transform.rotation) as GameObject;

		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
