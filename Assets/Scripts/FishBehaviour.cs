using UnityEngine;
using System.Collections;

public class FishBehaviour : MonoBehaviour {

	private Rigidbody2D rigidBody;
	private SpriteRenderer spriteRenderer;
	private float speed = 1f;

	public float minForce = 1f;
	public float maxForce = 3f;
	public float DirectionChangeInterval = 1f;


	private float directionChangeInterval;



	// Use this for initialization
	void Start () {
		rigidBody = gameObject.GetComponent<Rigidbody2D> ();
		spriteRenderer = gameObject.GetComponent<SpriteRenderer> ();
	

		directionChangeInterval = DirectionChangeInterval;

		RandomMovement ();

	}

	void OnCollisionEnter2D(Collision2D col){

		/*if (col.gameObject.name == "RightBorder") {
			speed = -2;
			spriteRenderer.flipX = true;
		}
		else if(col.gameObject.name == "LeftBorder"){
			speed = 2;
			spriteRenderer.flipX = false;
		}*/

		if (col.gameObject.tag == "Border") {
			speed = speed * -1;
			//RandomMovement();
		}

		if (col.gameObject.tag == "Fishy") {

			Physics2D.IgnoreCollision(col.collider, GetComponent<Collider2D>());
		}
	}

	public void RandomMovement(){
		
		float force = Random.Range (minForce, maxForce);
		float x = Random.Range (-1f, 1f);
		float y = Random.Range (-1f, 1f);


		GetComponent<Rigidbody2D>().AddForce(force * new Vector2(x, y));





	}
	void Update(){
		if (speed < 1f) {

			spriteRenderer.flipX = true;
		} else {
			spriteRenderer.flipX = false;
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		Vector2 tempVelocity = rigidBody.velocity;

		directionChangeInterval -= Time.deltaTime;

		if (directionChangeInterval < 0) {
			RandomMovement ();
			directionChangeInterval = DirectionChangeInterval;
		}

	

//		Vector3 pos = Camera.main.WorldToViewportPoint (transform.position);
//		if(pos.x > 1){
//			Debug.Log ("1");
//			speed *= -1;
//			pos.x = 1;
//
//		}
//
//		if(pos.x < 0){
//			Debug.Log ("1");
//			speed *= -1;
//			pos.x = 0;
//
//		}
//
//		if(pos.y > 1){
//			Debug.Log ("1");
//			speed *= -1;
//			pos.y = 1;
//
//		}
//
//		if(pos.y < 0){
//			Debug.Log ("1");
//			speed *= -1;
//			pos.y = 0;
//
//		}
//		transform.position = Camera.main.ViewportToWorldPoint(pos);

		tempVelocity.x = speed;
		rigidBody.velocity = tempVelocity;

	}
}
