using UnityEngine;
using System.Collections;

public class FoodPickup : MonoBehaviour {

	GameObject FM; // reference to Food Manager

	// Use this for initialization
	void Start () {
		FM = GameObject.Find ("FoodManager");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.name == "player" || coll.gameObject.tag == "Player") {
			FM.GetComponent<FoodManager> ().foodPicked = true;
		}
	}
}
