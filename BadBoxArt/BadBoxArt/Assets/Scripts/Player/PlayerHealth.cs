using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

	float maxHealth = 100.0f;
	float currentHealth;

	[SerializeField]
	Text playerHealthText;

	// Use this for initialization
	void Start () 
	{
		currentHealth = maxHealth;

		if (playerHealthText == null) {
			Debug.LogError ("NOT ASSIGNED");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void dead()
	{
		Debug.LogError ("You DIED");
		gameObject.SetActive (false);
	}

	void damage(float _val)
	{
		currentHealth -= _val;
		if (currentHealth >= 0) {
			int percent = (int)(currentHealth / maxHealth * 100);
			playerHealthText.text = "Health : "+percent+"%";
		} else {
			playerHealthText.text = "Health : 0%";
		}

		if (currentHealth <= 0) {
			dead ();
		}
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "Enemy") {
			if (coll.gameObject.name == "WildBull") {
				damage (40.0f);
			} else if (coll.gameObject.name == "Dog") {
				damage (10.0f);
			}
		}
	}
}
