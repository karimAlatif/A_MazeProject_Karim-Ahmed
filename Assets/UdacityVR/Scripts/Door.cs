using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

	public bool UnlockNow;
	public GameObject LeftDoor;
	public GameObject RightDoor;

	[Space]
	public AudioClip ClosedDoor;
	public AudioClip OpenedDoor;

	[Space]
	public float Timer;
	public float Duartion;


	private Quaternion S_LeftDoor;
	private Quaternion S_RightDoor;

	private Quaternion LeftDoorOpenedVector;
	private Quaternion RightDoorOpenedVector;


	void Start () {
		// TODO: Get a reference to the audio source
		// Use GetComponent<>() to get a reference to the AudioSource component and assign it to the 'audioSource'

		S_LeftDoor = LeftDoor.transform.rotation;
		S_RightDoor = RightDoor.transform.rotation;

		LeftDoorOpenedVector = Quaternion.Euler (-90, -90, 90);
		RightDoorOpenedVector = Quaternion.Euler (-90, 90, -90);


		// TODO: Set start and end rotation values used when animating the door opening
		// Use 'leftDoor' to get the start rotation of the 'Left_Door' game object and assign it to 'leftDoorStartRotation'
		// Use 'leftDoorStartRotation' and Quaternion.Euler() to set the end rotation of the 'Left_Door' game object and assign it to 'leftDoorEndRotation'
		// Use 'rightDoor' to get the start rotation of the 'Right_Door' game object and assign it to 'rightDoorStartRotation'
		// Use 'rightDoorStartRotation' and Quaternion.Euler() to set the end rotation of the 'Right_Door' game object and assign it to 'rightDoorEndRotation'
	}


	void Update () {


		if (UnlockNow) {

			StartCoroutine (Unlock ());
		}

		// TODO: If the door is opening, animate the 'Left_Door' and 'Right_Door' game objects rotating open
		// Use 'opening' to check if the door is opening...
		// ... use Quaternion.Slerp() to interpolate from 'leftDoorStartRotation' to 'leftDoorEndRotation' by the interpolation time 'timer / rotationTime' and assign it to the 'leftDoor' rotation
		// ... use Quaternion.Slerp() to interpolate from 'rightDoorStartRotation' to 'rightDoorEndRotation' by the interpolation time 'timer / rotationTime' and assign it to the 'leftDoor' rotation
		// ... use Time.deltaTime to increment 'timer'
	}


	public void OnDoorClicked () {

		if (Camera.main.transform.parent.transform.gameObject.GetComponent<PlayerManager> ().KeyCollected) {

			this.gameObject.GetComponent<AudioSource> ().clip = OpenedDoor;
			this.gameObject.GetComponent<AudioSource> ().Play ();
			UnlockNow = true;


		} else {

			this.gameObject.GetComponent<AudioSource> ().clip = ClosedDoor;
			this.gameObject.GetComponent<AudioSource> ().Play ();

		}

	}


	public IEnumerator Unlock () {


			while (Timer < 1) {
				LeftDoor.transform.rotation = Quaternion.Slerp (S_LeftDoor, LeftDoorOpenedVector, Timer );
				RightDoor.transform.rotation = Quaternion.Slerp (S_RightDoor, RightDoorOpenedVector, Timer );
				yield return null;
				Timer += Time.deltaTime/Duartion;
		}

	

	}
}
