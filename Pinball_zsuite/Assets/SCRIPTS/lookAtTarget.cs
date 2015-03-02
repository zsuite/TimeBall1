using UnityEngine;
using System.Collections;

public class lookAtTarget : MonoBehaviour {
	public Transform target;
	Quaternion neededRotation;
	Quaternion interpolatedRotation;
	Transform currentPosition;

	Quaternion currentRotation;

	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
		currentPosition = gameObject.transform;
		currentRotation = transform.localRotation;
		neededRotation = Quaternion.LookRotation(target.position - currentPosition.position);

		interpolatedRotation = Quaternion.Slerp(currentRotation, neededRotation, Time.deltaTime * 1f);
		gameObject.transform.localRotation = interpolatedRotation;

	}
}
