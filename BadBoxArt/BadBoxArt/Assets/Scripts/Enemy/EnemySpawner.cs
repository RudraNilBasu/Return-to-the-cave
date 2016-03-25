using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

	float waitingTime = 10.0f;

	[SerializeField]
	GameObject dog;
	[SerializeField]
	GameObject bull;

	// Use this for initialization
	void Start () 
	{
		StartCoroutine (Spawn());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator Spawn()
	{
		Debug.LogError ("Spawning....");
		yield return new WaitForSeconds (waitingTime);

		// Will spawn from a Random of three positions
		// will spawn 3 Yellow, 1 Red
		int i,rand;
		string posn;
		GameObject spawnPosn;

		for (i = 1; i <= 3; i++) {

			rand = (int)Random.Range (1.0f, 3.9f);

			posn = "SpawnPoint" + rand;
			spawnPosn = GameObject.Find ("EnemySpawnPoints/"+posn);

			Instantiate (dog, spawnPosn.transform.position, spawnPosn.transform.rotation);

			yield return new WaitForSeconds (1.0f);
		}

		rand = (int)Random.Range (1.0f, 3.9f);

		posn = "SpawnPoint" + rand;
		spawnPosn = GameObject.Find ("EnemySpawnPoints/"+posn);

		Instantiate (bull, spawnPosn.transform.position, spawnPosn.transform.rotation);

		StartCoroutine (Spawn());

	}
}
