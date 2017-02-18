using UnityEngine;
using System.Collections;

public class CoinAdder : MonoBehaviour {

	// Use this for initialization
	public CoinHandler coinHandler;
	public QuestionHandler questionHandler;
	public AudioClip goodSound;

	private AudioSource source;

	void Start () {
		questionHandler = QuestionHandler.Getinstance ();
		source = GetComponent<AudioSource> ();

	}

	public void OnClick(){

		coinHandler.AddCoins (1);
		questionHandler.NextQuestion (1);
		source.PlayOneShot (goodSound, 0.5F);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
