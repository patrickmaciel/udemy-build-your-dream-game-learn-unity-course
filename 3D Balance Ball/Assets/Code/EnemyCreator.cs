using UnityEngine;
using System.Collections;

public class EnemyCreator : MonoBehaviour {

    public int count = 0;
    public GameObject prefab;

	// Use this for initialization
	void Start () {
	    for (int i = 0; i < this.count; i++)
        {
            GameObject newGameObject = (GameObject)GameObject.Instantiate(prefab);
            newGameObject.transform.position = new Vector3(0, 1, 12);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
