using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class selectedCharacter : MonoBehaviour {

    Image sprite;

    void Start()
    {
        sprite = GetComponent<Image>();
    }

	void Update(){
        updateColor(Test_game_manager.instance.selectedPlayer);
	}

    void updateColor(Color color){
        sprite.CrossFadeColor(color,0,false,false);
        Test_game_manager.instance.isColored = false;
    }
}
