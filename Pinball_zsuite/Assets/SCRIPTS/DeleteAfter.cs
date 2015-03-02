using UnityEngine;
using System.Collections;

public class DeleteAfter : MonoBehaviour {
	Vector3 startPos;
	// Use this for initialization
	void Start () {
		startPos = gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody.AddExplosionForce(20,startPos,10);
		Destroy(gameObject, 1);
	}
}
