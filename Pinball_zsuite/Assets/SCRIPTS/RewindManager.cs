using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RewindManager : MonoBehaviour {

	public GameObject objectToTrack;
	public GameObject activateObj;
	public GameObject rewind1;
	public GameObject rewind2;
	public AudioSource audioToDistort1;
	public AudioSource audioToDistort2;
	public AudioSource audioToDistort3;

	List<Vector3> positionsList;
	int positionsIndex;
	// Use this for initialization
	void Start () {
		positionsIndex = 0;
		positionsList = new List<Vector3>();

	}
	
	// Update is called once per frame
	void Update () {
		if(positionsIndex > positionsList.Count - 1)
		{
			positionsIndex = positionsList.Count;
		}

		if(Input.GetKey(KeyCode.R)){
			if(StateManager.rewindPercent> 0 && positionsIndex >0){
				positionsIndex--;
				objectToTrack.transform.position = positionsList[positionsIndex];
				positionsList.RemoveAt(positionsIndex);
				activateObj.SetActive(true);
				rewind1.transform.localEulerAngles = (new Vector3(0, -83, 180));
				rewind2.transform.localEulerAngles = (new Vector3(0, 263, 180));
				audioToDistort1.pitch = -1;
				audioToDistort2.pitch = -2;
				audioToDistort3.pitch = -1;
				StateManager.rewindPercent -= .5f;
			}



		}
		else{

			positionsIndex++;
			positionsList.Add(objectToTrack.transform.position);
			activateObj.SetActive(false);
			rewind1.transform.localEulerAngles = (new Vector3(0, 97, 180));
			rewind2.transform.localEulerAngles = (new Vector3(0, 83, 180));
			audioToDistort1.pitch = 1;
			audioToDistort2.pitch = 1;
			audioToDistort3.pitch = 1;

		}

	}
}
