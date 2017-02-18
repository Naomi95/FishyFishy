using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaAngelBehaviour : MonoBehaviour {


	private Rigidbody2D rigidBody;
	private float speed = 0.3f;
	private float directionChangeInterval;

	public float minForce = 1f;
	public float maxForce = 3f;
	public float DirectionChangeInterval = 1f;

	// Use this for initialization
	void Start () {

		rigidBody = gameObject.GetComponent<Rigidbody2D> ();

		directionChangeInterval = DirectionChangeInterval;

		RandomMovement ();
		
	}

	void OnCollisionEnter2D(Collision2D col){


		if (col.gameObject.tag == "Border") {
			speed = speed * -1;
		}

		if (col.gameObject.tag == "Fishy") {

			Physics2D.IgnoreCollision (col.collider, GetComponent<Collider2D> ());
		}
	}

	public void RandomMovement(){

		float force = Random.Range (minForce, maxForce);
		float x = Random.Range (-1f, 1f);
		float y = Random.Range (-1f, 1f);


		GetComponent<Rigidbody2D>().AddForce(force * new Vector2(x, y));





	}

	
	// Update is called once per frame
	void Update () {

		Vector2 tempVelocity = rigidBody.velocity;

		directionChangeInterval -= Time.deltaTime;

		if (directionChangeInterval < 0) {
			RandomMovement ();
			directionChangeInterval = DirectionChangeInterval;
		}

		tempVelocity.y = speed;
		rigidBody.velocity = tempVelocity;
		
	}
}
