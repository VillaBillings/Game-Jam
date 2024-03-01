using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpamDelete : MonoBehaviour
{
    private bool _cursorIN;

    void Update()
    {
        if (_cursorIN && Input.GetMouseButtonDown(0))
        {
			GameObject parentObject = gameObject.transform.parent.gameObject;
			Destroy(gameObject);
			Destroy(parentObject);
		}
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("Cursor"))
		{
			_cursorIN = true;
		}
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("Cursor"))
		{
			_cursorIN = false;
		}
	}
}
