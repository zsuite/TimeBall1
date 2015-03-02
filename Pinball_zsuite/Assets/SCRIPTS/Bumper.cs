using UnityEngine;
using System.Collections;

public class Bumper : MonoBehaviour {
	public enum WhichBumper{
		Left,
		Right
	};

	bool hasPlayed = false;
	public WhichBumper bumper_o;
	JointSpring hJoint;
	// Use this for initialization
	void Start () {
		hJoint = hingeJoint.spring;
	}
	
	// Update is called once per frame
	void Update () {
		switch (bumper_o){
		case WhichBumper.Left:
			if(Input.GetKey(KeyCode.LeftShift)){
				if(!hasPlayed){
					audio.Play();
					hasPlayed = true;
				}
				hJoint.targetPosition = -30;
				hJoint.spring = 10000;
			}
			else{
				hasPlayed = false;
				hJoint.targetPosition = 30;
				hJoint.spring = 500;
			}
			break;
		case WhichBumper.Right:
			if(Input.GetKey(KeyCode.RightShift)){
				if(!hasPlayed){
					audio.Play();
					hasPlayed = true;
				}
				hJoint.targetPosition = 30;
				hJoint.spring = 10000;

			}
			else{
				hasPlayed = false;

				hJoint.targetPosition = -30;
				hJoint.spring = 500;
			}
			break;
		}
		hingeJoint.spring = hJoint;
	}
}
