using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_control : MonoBehaviour 
{
    // Character movement control where we can setup 2 players easily

    public KeyCode move_up;
    public KeyCode move_down;

    public float speed = 10;
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(move_up))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2 (0,speed);
        }
        else if (Input.GetKey(move_down))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,speed * -1);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
        }
    }


}
