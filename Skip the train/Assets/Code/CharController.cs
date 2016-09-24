using UnityEngine;
using System.Collections;

public class CharController : MonoBehaviour {

    bool alive = true;
    bool grounded = true;
    int jump = 0;
    int maxJumpCycles = 15;
    int left = 0;
    int right = 0;
    int maxLeftCycles = 5;
    int maxRightCycles = 5;

    public Camera mainCamera;

	// Use this for initialization
	void Start () {
        jump = maxJumpCycles;
        left = maxLeftCycles;
        right = maxRightCycles;
	}

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            right = 0;
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            left = 0;
        }

        if (Input.GetKeyUp(KeyCode.Space) && grounded)
        {
            jump = 0;
        }
	}

    void FixedUpdate()
    {
        if (alive)
        {
            this.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 10);
        }

        if (jump < maxJumpCycles)
        {
            this.GetComponent<Animator>().speed = 0;
            this.GetComponent<Rigidbody>().AddForce(0, 600, 500);
            jump++;
            grounded = false;
        }

        if (left < maxLeftCycles)
        {
            this.GetComponent<Rigidbody>().MovePosition(
                new Vector3(
                    this.gameObject.transform.position.x - (2.7f / maxLeftCycles),
                    this.gameObject.transform.position.y,
                    this.gameObject.transform.position.z
                )
            );
            left++;
        }

        if (right < maxRightCycles)
        {
            this.GetComponent<Rigidbody>().MovePosition(
                new Vector3(
                    this.gameObject.transform.position.x + (2.7f / maxRightCycles),
                    this.gameObject.transform.position.y,
                    this.gameObject.transform.position.z
                )
            );
            right++;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            grounded = true;
            this.GetComponent<Animator>().speed = 1;
        }
    }
}
