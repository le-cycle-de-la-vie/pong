using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_game_manager : MonoBehaviour {

	public static Color selectedPlayer = Color.yellow;
	public static Test_game_manager instance = null;

	void Awake(){
		if(instance == null){
			instance = this;
		}
	}

	public void updateSelectedPlayer(Color color){
			selectedPlayer = color;
	}
}

