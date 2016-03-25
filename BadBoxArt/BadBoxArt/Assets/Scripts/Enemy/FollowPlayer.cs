using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

	[SerializeField]
	float speed=200.0f;
	Transform target;
	float damping = 1.0f;

	// Use this for initialization
	void Start () {
		target = GameObject.Find ("player").transform;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (!gameObject.GetComponent<EnemyHealth> ().isDead) {
			Vector3 difference = (target.position) - transform.position;
			difference.Normalize ();

			float rotZ = Mathf.Atan2 (difference.y, difference.x) * Mathf.Rad2Deg;

			transform.rotation = Quaternion.Euler (0f, 0f, rotZ);

			//transform.Translate (Vector3.forward * Time.deltaTime * speed);

			transform.Translate (new Vector2 (speed * Time.deltaTime, 0) * Time.deltaTime);
		}
	}
}
