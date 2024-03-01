using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private bool _isPlay;

	public string sceneName;

    void Update()
    {
		if (_isPlay && Input.GetKeyDown(KeyCode.W))
		{
			SceneManager.LoadScene(sceneName);
		}
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("Player"))
		{
			_isPlay = true;
		}
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("Player"))
		{
			_isPlay = false;
		}
	}
}
