using UnityEngine;
using System.Collections;

public class WeaponMovement : MonoBehaviour {

	bool hasThrown = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) {
			hasThrown = true;
		}
		if(hasThrown)
			transform.Translate ( new Vector3(0,1,0) * Time.deltaTime)  ;
	}
}
