using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DeathChecker : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (this.gameObject.transform.position.y < -5)
        {
            SceneManager.LoadScene(0);
        }	
	}
}
