using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrownPurchase : MonoBehaviour {


	private CoinHandler coinHandler;
	public GameObject fishWithCrown, fishy;
	// Use this for initialization
	void Start () {
		coinHandler = CoinHandler.Getinstance ();
		
	}


	public void OnClick(){

		if (coinHandler.coins >= 5){
			coinHandler.DecreaseCoins (5);
			Transform fishyTransform = fishy.transform;
			Destroy (fishy);
			fishy = Instantiate (fishWithCrown, fishyTransform.position, 	fishyTransform.transform.rotation) as GameObject;

		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
