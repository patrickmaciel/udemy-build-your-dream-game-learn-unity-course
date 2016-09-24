using UnityEngine;
using System.Collections;

public class TeddyAnimationManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Animator animator = this.GetComponent<Animator>();
        animator.SetTrigger("No");
	}
}
