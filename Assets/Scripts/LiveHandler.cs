using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class LiveHandler : MonoBehaviour {

	private static LiveHandler instance;
	public Text liveText;
	private uint live;

	// Use this for initialization
	void Start () {
		live = 5;
		liveText = gameObject.GetComponent<Text> ();


	}

	void Awake(){
		if (instance == null)
			instance = this;
		else if (instance != this) {
			Destroy (this);
		}
	}

	public static LiveHandler GetInstance(){
		return instance;
	}

	public void DecreaseLive(){
		if (live > 0) {
			live--;
		} 

		if (live == 0){
			Debug.Log("Game Over");
			SceneManager.LoadScene ("GameOverScene");
		}
		setLiveText ();
	}

	 void setLiveText(){

		liveText.text = "Lives: " + live.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
