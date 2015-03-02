using UnityEngine;
using System.Collections;

public class AddValues : MonoBehaviour {

	public int points = 0;
	public int pointMultiplier = 1;
	public int rewindPoints = 0;
	public GameObject spawnFeedback;
	public float scaleMultiplier = 1;
	Vector3 oldScale;
	float resizeTimer = 0;
	float maxTime = .25f;
	bool scaled;
	bool hasPlayed;
	public GameObject scorePrefab;
	// Use this for initialization
	void Start () {
		oldScale = transform.localScale;
	}
	
	// Update is called once per frame
	void Update () {
		audio.pitch = StateManager.globalPitch;

		if(transform.localScale.y > oldScale.y){
			resizeTimer += Time.deltaTime;
			if (resizeTimer > maxTime){
				hasPlayed = false;
				if(scaleMultiplier != 0){
					transform.localScale /= scaleMultiplier;
				}
				resizeTimer = 0;
				scaled = false;
			}
		}


	}

	void OnCollisionEnter(Collision collider){
		if(collider.gameObject.name == "MetalBall"){
			StateManager.score += (points * StateManager.scoreMultiplier);
			StateManager.scoreMultiplier += pointMultiplier;
			collider.rigidbody.AddExplosionForce(100,transform.position,5);
			GameObject scoreFeedback = Instantiate(scorePrefab, transform.position, Quaternion.LookRotation(Vector3.right)) as GameObject;
			scoreFeedback.transform.SetParent(GameObject.Find("Canvas").transform);

			if(!hasPlayed){
				audio.Play();
				StateManager.globalPitch += .02f;
				hasPlayed = true;
			}
			if(StateManager.rewindPercent  <100){
				if(StateManager.rewindPercent  <96){
				StateManager.rewindPercent += rewindPoints;
				}
				else{
					StateManager.rewindPercent =100;
				}
			}
			if(!scaled){
				transform.localScale *= scaleMultiplier;
				scaled = true;
			}

			//Instantiate(spawnFeedback);
		}

	}
}
