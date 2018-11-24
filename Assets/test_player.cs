using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_player : MonoBehaviour {
	
	Rigidbody2D rb;
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void OnMouseDrag(){
		Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		rb.MovePosition(new Vector2(mousePosition.x,mousePosition.y));
	}
}