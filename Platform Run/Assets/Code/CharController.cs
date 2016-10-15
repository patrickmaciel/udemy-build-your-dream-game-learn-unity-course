using UnityEngine;
using System.Collections;

public class CharController : MonoBehaviour {
	bool jump = false;
	bool down = false;
	bool grounded = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			jump = true;
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			down = true;
		}

		if (this.transform.position.y <= -30) {
			Application.LoadLevel(0);
		}
	}

	/// <summary>
	/// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
	/// </summary>
	void FixedUpdate()
	{
		this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(5f, this.gameObject.GetComponent<Rigidbody2D>().velocity.y);

		if (jump && grounded) {
			this.GetComponent<Animator>().speed = 0;
			this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(500f, 1000f));
			jump = false;
			grounded = false;
		}

		if (down) {
			this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -500f));
			down = false;
		}
	}

	/// <summary>
	/// Sent when an incoming collider makes contact with this object's
	/// collider (2D physics only).
	/// </summary>
	/// <param name="other">The Collision2D data associated with this collision.</param>
	void OnCollisionEnter2D(Collision2D other)
	{
		grounded = true;
		this.GetComponent<Animator>().speed = 1;
	}

	/// <summary>
	/// Sent when another object enters a trigger collider attached to this
	/// object (2D physics only).
	/// </summary>
	/// <param name="other">The other Collider2D involved in this collision.</param>
	void OnTriggerEnter2D(Collider2D other)
	{
		Destroy(other.gameObject);
	}
}
