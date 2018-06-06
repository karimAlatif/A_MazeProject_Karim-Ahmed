using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour {

	[HideInInspector]
	public int Coins;
	[HideInInspector]
	public bool KeyCollected;


	public Text CoinText;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void UpdateCoinText(){

		Coins++;
		CoinText.text = "Coins : " + Coins;

	}
}
