using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

	// TODO: Create variables to reference the game objects we need access to
	// Declare a GameObject named 'coinPoofPrefab' and assign the 'CoinPoof' prefab to the field in Unity

	public AudioClip ItemSound;
	public GameObject ItemPrefab; //particualar object

	void Update () {

		this.transform.Rotate (Vector3.up, 25 * Time.deltaTime);

		// OPTIONAL-CHALLENGE: Animate the coin rotating
		// TIP: You could use a method from the Transform class
	}


	public void OnCoinClicked () {


	
		Camera.main.transform.parent.gameObject.GetComponent<PlayerManager> ().UpdateCoinText();


		GameObject TempObj = Instantiate (ItemPrefab, this.transform.position, Quaternion.Euler(0,0,75));
		TempObj.gameObject.GetComponent<AudioSource> ().clip = ItemSound;
		TempObj.gameObject.GetComponent<AudioSource> ().Play ();
		Destroy (this.gameObject,0.2f);



		/// Called when the 'Coin' game object is clicked
		/// - Displays a poof effect (handled by the 'CoinPoof' prefab)
		/// - Plays an audio clip (handled by the 'CoinPoof' prefab)
		/// - Removes the coin from the scene

		// Prints to the console when the method is called
		Debug.Log ("'Coin.OnCoinClicked()' was called");

		// TODO: Display the poof effect and remove the coin from the scene
		// Use Instantiate() to create a clone of the 'CoinPoof' prefab at this coin's position and with the 'CoinPoof' prefab's rotation
		// Use Destroy() to delete the coin after for example 0.5 seconds
	}
}
