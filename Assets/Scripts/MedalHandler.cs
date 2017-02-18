using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MedalHandler : MonoBehaviour {

	// Use this for initialization
	private static MedalHandler instance;
	public Text medalText;
	public uint medals;

	void Start () {
		medals = 0;
		medalText = gameObject.GetComponent<Text>();
		setMedalText ();
	
	}

	void Awake(){
		if (instance == null)
			instance = this;
		else if (instance != this) {
			Destroy (this);
		}
	}

	public static MedalHandler Getinstance(){
		return instance;
	}

	public void AddMedal(uint amount){

		medals += amount;
		setMedalText ();

	}

	public void DecreaseMedal(uint amount){

		medals -= amount;
		setMedalText ();

	}

	void setMedalText(){

		medalText.text = "Medals: " + medals;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
