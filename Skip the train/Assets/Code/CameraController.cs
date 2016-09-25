using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject justin;
    bool cameraAttached = true;

	// Use this for initialization
	void Start () {
        Vector3 justinPosition = justin.transform.position;
        this.gameObject.transform.position = new Vector3(
            justinPosition.x,
            justinPosition.y + 2.2f,
            justinPosition.z - 8f);
	}
	
	// Update is called once per frame
	void Update () {
	    if (cameraAttached)
        {
            Vector3 justinPosition = justin.transform.position;
            this.gameObject.transform.position = new Vector3(
                this.gameObject.transform.position.x,
                this.gameObject.transform.position.y,
                justinPosition.z - 4f);
        }
	}

    public void AdjustCamera(float xValue)
    {
        this.gameObject.transform.Translate(xValue, 0, 0);
    }

    public void DetachCamera()
    {
        cameraAttached = false;
    }
}
