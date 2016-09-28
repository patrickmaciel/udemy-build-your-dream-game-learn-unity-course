using UnityEngine;
using System.Collections;

public class TrainController : MonoBehaviour {

    public bool moving = false;
    // private float speed = 1f;

    private bool signaledToMove = false;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate()
    {
        if (moving && signaledToMove)
        {
            float speed = Random.Range(1, 3);
            Debug.Log("speed = " + speed);
            this.GetComponent<Rigidbody>().AddForce(Vector3.back * 250 * speed);
        }

        if (this.gameObject.transform.position.z < -520 || 
            this.gameObject.transform.position.y < -20)
        {
            Destroy(this.gameObject);
        }
    }

    public void SignalToMove()
    {
        this.signaledToMove = true;
    }
}
