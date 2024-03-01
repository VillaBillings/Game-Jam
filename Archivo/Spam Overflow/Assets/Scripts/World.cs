using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour
{
	void Start()
	{
		Cursor.visible = false;  // Makes the mouse cursor invisible
		Cursor.lockState = CursorLockMode.Confined;  // Locks the cursor within the game window
	}
}
