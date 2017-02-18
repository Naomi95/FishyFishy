using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public void ChangetoScene(int sceneToChangeTo){
		SceneManager.LoadScene (sceneToChangeTo);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
