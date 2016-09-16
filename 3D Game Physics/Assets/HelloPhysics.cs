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
        var randomX = Random.Range(0, 10);
        Debug.Log("randomX = " + randomX);
        var randomY = Random.Range(0, 10);
        Debug.Log("randomY = " + randomY);
        var randomZ = Random.Range(0, 10);
        Debug.Log("randomZ = " + randomZ);

        Vector3 force = new Vector3(randomX, randomY, randomZ);
        this.gameObject.GetComponent<Rigidbody>().AddForce(force);

        Vector3 rotation = new Vector3(randomX, randomY, 0);
        this.gameObject.GetComponent<Rigidbody>().MoveRotation(Quaternion.LookRotation(rotation));
    }
}
