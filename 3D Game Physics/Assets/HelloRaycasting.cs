using UnityEngine;
using System.Collections;

public class HelloRaycasting : MonoBehaviour {

    bool doorClosed = true;
    public GameObject sphere;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 backward = new Vector3(0, 0, -1);
        Vector3 position = sphere.transform.position;
        Vector3 origin = this.gameObject.transform.position;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        Vector3 distant = transform.TransformDirection(Vector3.forward);

        //if (Physics.Raycast(backward, origin, 1f) && doorClosed)
        if (Physics.Raycast(position, fwd, 1f) && doorClosed)
        {
            doorClosed = false;
            GameObject.Find("DoorL").transform.Translate(new Vector3(-.8f, 0, 0));
            GameObject.Find("DoorR").transform.Translate(new Vector3(.8f, 0, 0));
        }
        else if (Physics.Raycast(origin, backward, 3f) && !doorClosed)
        {
            doorClosed = true;
            GameObject.Find("DoorL").transform.Translate(new Vector3(0, 0, 0));
            GameObject.Find("DoorR").transform.Translate(new Vector3(0, 0, 0));
        }

    }
}
