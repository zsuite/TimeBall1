using UnityEngine;
using System.Collections;

public class RestartPosition : MonoBehaviour {
	// Use this for initialization
	Vector3 originalPos;

	void Start () {
		originalPos = gameObject.transform.position;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.P)){
			gameObject.transform.position = originalPos;

		}
	}
}
