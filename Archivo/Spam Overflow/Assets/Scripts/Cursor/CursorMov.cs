using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorMov : MonoBehaviour
{
	private Vector3 mousePosition;
	public Vector2 velocity;

	public float moveSpeed = 100f;
	
	[HideInInspector] public Rigidbody2D rb;


	private void Awake()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	private void Start()
	{
		Cursor.visible = false;
		mousePosition = transform.position;
	}

	private void FixedUpdate()
	{
		//mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		//direction = (mousePosition - transform.position).normalized;
		//rb.velocity = direction * moveSpeed;


		//Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		//transform.position = new Vector2(cursorPos.x, cursorPos.y);


		Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		transform.position = cursorPos;

		// Calcula la velocidad basada en el cambio de posici�n
		velocity = (transform.position - mousePosition) / Time.deltaTime;
		mousePosition = transform.position;
	}
}
