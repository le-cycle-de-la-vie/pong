using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Utilities : MonoBehaviour {

	public static Utilities instance = null;

	void Awake(){
		if(instance == null){
			instance = this;
		}
	}

    public void updateColor(Color color, Image sprite){
        sprite.CrossFadeColor(color,0,false,false);
        Test_game_manager.instance.updateSelectedPlayer(color);
    }
}   
