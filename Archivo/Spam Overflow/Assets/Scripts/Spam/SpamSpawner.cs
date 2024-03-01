using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpamSpawner : MonoBehaviour
{
	private bool _hasSpawn = false;

	public GameObject[] Spams;
	private BoxCollider2D spawnArea;

	public float spawnRate = 5;
	public float timer = 5;


	void Awake()
	{
		spawnArea = GetComponent<BoxCollider2D>();
	}

	void Update()
	{
		if (timer > spawnRate)
		{
			if (Input.GetButtonDown("Jump") || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow)
			|| Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.A))
			{
				SpawnSpam();
				_hasSpawn = true;
			}
		}

		if (_hasSpawn)
		{
			timer = 0;
			_hasSpawn = false;
		}
		else
		{
			timer = timer + Time.deltaTime;
		}
	}

	void SpawnSpam()
	{
		GameObject spamToSpawn = Spams[Random.Range(0, Spams.Length)];

		// Calcula las posiciones x e y dentro del Collider
		float x = Random.Range(spawnArea.bounds.min.x, spawnArea.bounds.max.x);
		float y = Random.Range(spawnArea.bounds.min.y, spawnArea.bounds.max.y);

		// Crea el objeto Spam en una posición aleatoria dentro del BoxCollider2D
		Instantiate(spamToSpawn, new Vector2(x, y), Quaternion.identity);
	}
}
