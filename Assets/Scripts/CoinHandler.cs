using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CoinHandler : MonoBehaviour {

	private static CoinHandler instance;
	public Text coinText;
	public uint coins;


	// Use this for initialization
	void Start () {

		coins = 0;
		coinText = gameObject.GetComponent<Text> ();
		setCoinText ();
	
	}

	void Awake(){
		if (instance == null)
			instance = this;
		else if (instance != this) {
			Destroy (this);
		}
	}

	public static CoinHandler Getinstance(){
		return instance;
	}

	public void AddCoins(uint amount){
		
		coins += amount;
		setCoinText ();

	}

	public void DecreaseCoins(uint amount){

		coins -= amount;
		setCoinText ();

	}

	void setCoinText(){

		coinText.text = "Coins: " + coins;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
