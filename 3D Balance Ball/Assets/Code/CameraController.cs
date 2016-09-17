using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GameObject ball = GameObject.Find("Ball");
        Vector3 ballPosition = ball.transform.position;
        this.gameObject.transform.position = new Vector3(ballPosition.x, ballPosition.y + 3f, ballPosition.z - 3f);	
	}
}
