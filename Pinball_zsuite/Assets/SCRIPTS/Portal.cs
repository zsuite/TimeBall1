using UnityEngine;
using System.Collections;

public class Portal : MonoBehaviour {
	public GameObject myExit;
	public static bool teleported;
	public static float portalTimer = 5;
	// Use this for initialization
	void Start () {
		teleported = false;
	}
	
	// Update is called once per frame
	void Update () {

		if(teleported){
			portalTimer -= Time.deltaTime;
			if(portalTimer<1){
				teleported = false;
			}

		}
	}

	void OnTriggerEnter(Collider collider){
		if(collider.gameObject.name == "MetalBall" && !teleported){
			audio.Play();
			collider.gameObject.transform.position = myExit.transform.position;
			collider.gameObject.rigidbody.AddExplosionForce(20,myExit.transform.position, 5);
			teleported = true;
		}
	}
}
