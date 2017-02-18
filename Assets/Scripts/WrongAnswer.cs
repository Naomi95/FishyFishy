using UnityEngine;
using System.Collections;

public class WrongAnswer : MonoBehaviour {



	// Use this for initialization
	public LiveHandler liveHandler;
	public AudioClip badSound;

	private AudioSource source;
	public HealthBar healthBar;

	void Start () {
	
		source = GetComponent<AudioSource> ();
		liveHandler = LiveHandler.GetInstance ();

	}

	public void OnClick(){

		source.PlayOneShot (badSound, 0.5F);
		liveHandler.DecreaseLive ();
		healthBar.DecreaseBar (0.2f);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
