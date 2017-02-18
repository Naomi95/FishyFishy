using UnityEngine;
using System.Collections;

public class BackButtonShop : MonoBehaviour {

	public GameObject ShopCanvas;

	// Use this for initialization
	void Start () {

	}

	public void OnClick(){

		Debug.Log ("Hello");
		ShopCanvas.SetActive (false);


	}

	// Update is called once per frame
	void Update () {

	}
}
