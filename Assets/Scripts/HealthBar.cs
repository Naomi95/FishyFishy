using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {



	public float fillAmount;


	public Image content;


	// Use this for initialization
	void Start () {
		
	}

	public void HandleBar(){
		content.fillAmount = fillAmount;

	}

	public void DecreaseBar(float number){
		
		fillAmount -= number;
	}
	
	// Update is called once per frame
	public void Update () {
		
		HandleBar ();

	}
}
