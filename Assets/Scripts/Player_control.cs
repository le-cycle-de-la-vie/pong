using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player_control : MonoBehaviour
{
	bool drag = true;
	Vector3 player_position;
	
	void Start()
	{
		player_position = new Vector3(0,0,0);
	}

	void Update()
	{
		Drag_drop();
	}
	void Drag_drop()
	{
		Vector3 mousePos= Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		
		 if (Input.GetMouseButton(0))
		{
			drag = false;

			if (Physics.Raycast(ray,out hit, 100) && hit.collider.tag =="Player1")
			{
				drag = true;
			}
			else
			{
				drag = false;
			}

			if(drag)
			{
				player_position = new Vector3 (mousePos.x,mousePos.y,0);
			}
		}
		else
		{
			drag = true;
		}
	}

	void OnTriggerEnter(Collider other)
	{
		Debug.Log("I hit something");
	}

	void OnCollisionEnter(Collision other)
	{
		Debug.Log("this time, you hit something");
	}
}
