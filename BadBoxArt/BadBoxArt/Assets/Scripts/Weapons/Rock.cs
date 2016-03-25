using UnityEngine;
using System.Collections;

public class Rock : MonoBehaviour {

	[SerializeField]
	GameObject rock;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButtonDown (0)) {
			Instantiate (rock, transform.position, transform.rotation);
		}
	}
}
