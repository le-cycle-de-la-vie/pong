using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class selectedCharacter : MonoBehaviour {

    Image sprite;
    Color initial;

    void Start()
    {
        initial = Test_game_manager.selectedPlayer;
        sprite = GetComponent<Image>();
        updateColor(initial);
    }

	void Update(){
        if(Test_game_manager.selectedPlayer != initial){
            updateColor(Test_game_manager.selectedPlayer);
        }
	}

    void updateColor(Color color){
        sprite.CrossFadeColor(color,0,false,false);
    }
}
