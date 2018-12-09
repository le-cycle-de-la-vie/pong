using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test_collision : MonoBehaviour 
{
    Image sprite;

    void Start()
    {
        sprite = GetComponent<Image>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        updateColor(Color.red);
    }

    void OnTriggerExit2D(Collider2D col)
    {
        updateColor(Color.blue);
    }

    void updateColor(Color color){
        sprite.CrossFadeColor(color,0,false,false);
        Test_game_manager.instance.updateSelectedPlayer(color);
    }
}
