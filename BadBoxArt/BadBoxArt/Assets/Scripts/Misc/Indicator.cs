using UnityEngine;
using System.Collections;

public class Indicator : MonoBehaviour {

	[SerializeField]
	GameObject theSpear;

	int rotationOffset = -90;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!theSpear.activeInHierarchy) {
			gameObject.SetActive (false);
		}

		Vector3 difference = theSpear.transform.position - transform.position;
		difference.Normalize ();

		float rotZ = Mathf.Atan2 (difference.y, difference.x) * Mathf.Rad2Deg;

		transform.rotation = Quaternion.Euler (0f, 0f, rotZ + rotationOffset);
	}
}
