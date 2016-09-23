using UnityEngine;
using System.Collections;

public class MicController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        AudioSource aud = GetComponent<AudioSource>();
        aud.clip = Microphone.Start(Microphone.devices[1], true, 100, 44100);
        aud.Play();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
