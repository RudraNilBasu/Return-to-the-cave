using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

	[SerializeField]
	float health = 300.0f;
	float maxHealth = 300.0f;
	public bool isDead = false;

	[SerializeField]
	GameObject statusIndicator;
	// Use this for initialization
	void Start () 
	{
		isDead = false;
		if (statusIndicator == null) {
			Debug.LogError ("NOT ASSIGNED");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void damage(float damage)
	{
		health -= damage;
		// consider a spear does 100 damage and stones does 25, boomerang paralyses taking away 50 health
		if (health <= 0) {
			Debug.Log ("Dead");
			isDead = true;
		}
		if (health >= 0) {
			statusIndicator.GetComponent<StatusIndicator> ().SetHealth ((int)health, (int)maxHealth);
		} else {
			statusIndicator.GetComponent<StatusIndicator> ().SetHealth (0, (int)maxHealth);
		
		}
	}
	/*
	void OnTriggerEnter2D(Collider2D coll)
	{
		Debug.LogError ("huehuehuehuehuheuheuheu");
		if (coll.tag == "spear") {
			damage (100.0f);
		}
	}
	*/

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "spear") {
			damage (100.0f);
		}

		if (coll.gameObject.tag == "rock") {
			damage (25.0f);
		}
	}
}
