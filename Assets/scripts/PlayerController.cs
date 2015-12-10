using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	private Rigidbody2D body;
	private bool isFloor;
	public LayerMask isGround;
	public GameObject groundCheck;
	public float radiusCheck;
	void Start () {
		isFloor = false;
		body = GetComponent<Rigidbody2D> ();
	}

	void Update () {
		isFloor = Physics2D.OverlapCircle (groundCheck.transform.position, radiusCheck, isGround);
		if (Input.GetKey (KeyCode.LeftArrow)) {
			body.velocity = new Vector2(-2,body.velocity.y);
			transform.localScale = new Vector3(-1,1,1);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.localScale = new Vector3(1,1,1);
			body.velocity = new Vector2(2,body.velocity.y);
		}
		if (Input.GetKey (KeyCode.Space) && isFloor) {
			body.velocity = new Vector2(body.velocity.x,9);
		}
	}

	void OnCollisionEnter2D(Collision2D collide){
		if (collide.gameObject.tag == "coin") {
			Destroy(collide.gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D collide){
		if (collide.gameObject.tag == "coin") {
			Destroy(collide.gameObject);
		}
	}
}
