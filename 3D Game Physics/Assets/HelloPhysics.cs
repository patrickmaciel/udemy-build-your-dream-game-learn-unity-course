using UnityEngine;
using System.Collections;

public class HelloPhysics : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate()
    {
        Vector3 force = new Vector3(-10, 10, 0);
        this.gameObject.GetComponent<Rigidbody>().AddForce(force);

        Vector3 torque = new Vector3(-10, 0, 0);
        this.gameObject.GetComponent<Rigidbody>().AddTorque(torque);
    }
}
