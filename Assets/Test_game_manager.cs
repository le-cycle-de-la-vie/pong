using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_game_manager : MonoBehaviour {

	public Color selectedPlayer = Color.grey;
	public bool isColored = true;
	public static Test_game_manager instance = null;

	void Awake(){
		if(instance == null){
			instance = this;
		}
	}

	public void updateSelectedPlayer(Color color){
		if(isColored = true){
			selectedPlayer = color;
		}
	}
}

