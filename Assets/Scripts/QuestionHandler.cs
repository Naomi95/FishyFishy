using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class QuestionHandler : MonoBehaviour {

	private static QuestionHandler instance;
	public Text questionText;
	public uint questionNumber;
	public MedalHandler medalHandler;


	// Use this for initialization
	void Start () {
		questionNumber = 1;
		questionText = gameObject.GetComponent<Text> ();
		setQuestionText ();

		medalHandler = MedalHandler.Getinstance ();

	
	}

	void Awake(){
		if (instance == null)
			instance = this;
		else if (instance != this) {
			Destroy (this);
		}
	}

	public static QuestionHandler Getinstance(){
		return instance;
	}

	public void NextQuestion(uint number){

		questionNumber += number;

		if(questionNumber == 11){

			questionNumber -= 10;
			medalHandler.AddMedal (1);
			Debug.Log("Reset now");
		}

		setQuestionText ();

	}

	void setQuestionText(){

		questionText.text = "Question " + questionNumber + "/10";
	}

	// Update is called once per frame
	void Update () {
	
	}
}
