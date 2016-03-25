using UnityEngine;
using System.Collections;

public class WeaponThrow : MonoBehaviour {

	bool isEquiped;
	bool hasThrown = false;
	bool shouldMove = false;
	bool canEquipe = false;

	float range = 15.0f;
	float equipDistance = 1.0f;

	Vector3 shootPosn;

	GameObject Player;

	// Use this for initialization
	void Start () 
	{
		isEquiped = true;
		Player = GameObject.Find ("player");
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButton (0)  && isEquiped) {
			shootPosn = transform.position;
			transform.parent = null;
			hasThrown = true;
			shouldMove = true;
			isEquiped = false;
		}

		if (hasThrown && shouldMove) {
			transform.Translate (new Vector3 (0, 1, 0));

			/*
				if the distance moved is > Range, stop moving
			*/

			float distance = Vector3.Distance (shootPosn, transform.position);

			if (distance >= range) {
				shouldMove = false;
				canEquipe = true;
			}

			// if it collides with other stuff
		}

		if (canEquipe) {

			float distance = Vector3.Distance (transform.position, Player.transform.position);

			//if (Input.GetKey (KeyCode.E) && distance < equipDistance) {
			if ( distance < equipDistance) {
				transform.parent = GameObject.Find ("player/Weapons").transform;
				transform.localPosition = new Vector3 (0,0,0);
				transform.localRotation = new Quaternion (0, 0, 0, 0);
				isEquiped = true;
				hasThrown = false;
				shouldMove = false;
				canEquipe = false;
			}
			Debug.Log ("Keep option for exchanging weapons");
		}
			
	}
	/*
	void OnCollisionEnter2D()
	{
		Debug.LogError ("lelwa coll");
	}

	void OnTriggerEnter2D()
	{
		Debug.LogError ("lelwa Trigger");
	}
	*/
}
