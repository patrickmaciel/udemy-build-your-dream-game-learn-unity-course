using UnityEngine;
using System.Collections;

public class Parallax : MonoBehaviour {
    public float scrollSpeed;

    // Use this for initialization
    void Start () {
    
    }
    
    // Update is called once per frame
    void Update () {
        float x = Mathf.Repeat(Time.time * scrollSpeed, 1);
        this.gameObject.GetComponent<Renderer>().sharedMaterial.SetTextureOffset("_MainTex", new Vector2(x, 0f));
    }
}
