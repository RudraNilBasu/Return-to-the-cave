using UnityEngine;
using System.Collections;

public class FoodManager : MonoBehaviour {

	int foodCollected;
	public bool foodPicked; // indicates whether the current food is taken up by the player

	int prev;

	[SerializeField]
	GameObject theFood;

	// Use this for initialization
	void Start () {
		foodCollected = 0;
		foodPicked = true; // to start spawning the first food

		prev = -1;
	}
	
	// Update is called once per frame
	void Update () {
		while (foodCollected <= 10) {
			if (foodPicked) {
				foodCollected++;
				Spawn (prev);
				foodPicked = false;
			}
		}
	}

	void Spawn(int prev)
	{
		int rand = (int)Random.Range (1f,10.9f);
		while (rand == prev) {
			rand = (int)Random.Range (1f,10.9f); // picking up a unique location
		}
		string foodPos = "FoodPos" + rand;
		GameObject pos = GameObject.Find ("FoodSpawnPositions/"+foodPos);
		Instantiate (theFood, pos.transform.position, pos.transform.rotation);

		prev = rand;
	}
}
