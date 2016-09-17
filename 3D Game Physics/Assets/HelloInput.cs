using UnityEngine;
using System.Collections;

public class HelloInput : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        this.gameObject.transform.Translate(horizontal, 0, vertical);
    }
}
