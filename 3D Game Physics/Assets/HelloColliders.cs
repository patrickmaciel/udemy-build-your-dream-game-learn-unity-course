using UnityEngine;
using System.Collections;

public class HelloColliders : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision c)
    {
        Debug.Log("Enter");
    }

    void OnCollisionStay(Collision c)
    {
        Debug.Log("Stay");
    }

    void OnCollisionExit(Collision c)
    {
        Debug.Log("Exit");
    }

    void OnTriggerEnter(Collider c)
    {
        Debug.Log("Triggered");
    }
}
