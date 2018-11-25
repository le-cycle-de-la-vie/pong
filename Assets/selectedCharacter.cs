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

	// prends le trésor et manipule le
	// si la couleur est changé, ne la change pas (loop to do)
	void Update(){
		updateColor(Test_game_manager.instance.selectedPlayer);
	}

    void updateColor(Color color){
        sprite.CrossFadeColor(color,0,false,false);
		Debug.Log("n'importe quoi");
    }
}
