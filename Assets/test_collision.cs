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

    // je vais dans le script GameManager.cs, j'accède à l'instance de la classe et j'utilise la méthode.
    void updateColor(Color color){
        sprite.CrossFadeColor(color,0,false,false);
        Test_game_manager.instance.updateSelectedPlayer(color);
        return;
    }
}
