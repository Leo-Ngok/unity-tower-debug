using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour {

	public static int EnemiesAlive = 0;

	public Wave[] waves;

	// TODO: Connect to instances on scene.
	public Transform spawnPoint;
	
	private int waveIndex = 0;

	void Update ()
	{
	}

	public void SpawnControl()
	{
		// TODO: Make it randomized and become an endless game
		if (waveIndex >= waves.Length)
			return;


		Wave wave = waves[waveIndex];

		EnemiesAlive = wave.count;

		for (int i = 0; i < wave.count; i++)
		{
			SpawnEnemy(wave.enemy);
		}

		waveIndex++;
	}
	void SpawnEnemy (GameObject enemy)
	{
		// TODO
		Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
	}

}
