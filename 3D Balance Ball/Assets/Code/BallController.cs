using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

    public float force = 5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Debug.Log("horizontal = " + horizontal);
        Debug.Log("vertical = " + vertical);

        if (vertical > 0)
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
        }

        if (vertical < 0)
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.back * force);
        }

        if (horizontal > 0)
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * force);
        }

        if (horizontal < 0)
        {
            this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.left * force);
        }
    }
}
