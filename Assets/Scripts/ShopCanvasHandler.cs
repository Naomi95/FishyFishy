using UnityEngine;
using System.Collections;

public class ShopCanvasHandler : MonoBehaviour {

	public GameObject ShopCanvas;

	// Use this for initialization
	void Start () {
	
	}

	public void OnClick(){

		Debug.Log ("klopt");
		ShopCanvas.SetActive (true);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
