using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player_select : MonoBehaviour 
{
	bool wasJustClicked = true;
    bool canMovep1;
    bool canMovep2;
    bool canSelect1;
    Color character_color;
    void Start()
    {
        GameObject character = GameObject.FindWithTag("Player1");

        if(character !=null)
        {
            character_color = character.GetComponent<Image>().color;
            Debug.Log("this is the character's color " + character_color);

        }
    }

    void Update () 
    {
		if (Input.GetMouseButton(0))
        {
            Vector2 mousePos= Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
               
            if (wasJustClicked)
            {
                wasJustClicked = false;
 
                if (Physics.Raycast(ray,out hit, 100) && hit.collider.tag =="Player1")
                {
                    canMovep1 = true;
                    canSelect1 = true;
                }
                else
                {
                    canMovep1 = false;
                }
                if(Physics.Raycast(ray,out hit, 100) && hit.collider.tag =="Player2")
                {
                    canMovep2 = true;
                }
                else
                {
                    canMovep2 = false;
                }
            }
 
            if (canMovep1)
            {
                GameObject.FindWithTag("Player1").transform.position = mousePos;
            }
            if (canMovep2)
            {
                GameObject.FindWithTag("Player2").transform.position = mousePos;
            }

            if(canSelect1)
            {
                if (Physics.Raycast(ray,out hit, 100) && hit.collider.tag =="Player1")
                {
                    Debug.Log("Contact was made");
                    character_color = new Color32(255,255,255,100);;
                    Debug.Log("this is the character's color " + character_color);

                    canSelect1 = false;
                }
            }
        }
        else
        {
            wasJustClicked = true;
        }
	}
}

