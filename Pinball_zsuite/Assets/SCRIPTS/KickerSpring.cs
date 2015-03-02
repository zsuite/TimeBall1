using UnityEngine;
using System.Collections;

public class KickerSpring : MonoBehaviour {
	SpringJoint springJoint;
	bool hasPlayed = true;
	// Use this for initialization
	void Start () {
		springJoint = GetComponent<SpringJoint>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("space")){
			springJoint.minDistance = 5;
			rigidbody.AddRelativeForce(0,-1000,0);
			hasPlayed = false;
		}
		else{
			springJoint.minDistance = 0;
			if(!hasPlayed){
				audio.Play();
				hasPlayed = true;
			}
		}
	}
}
