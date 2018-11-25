using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_game_manager : MonoBehaviour {

	// coffre dans un coffre
	public Color selectedPlayer = Color.grey;
	// c'est le coffre et la clé
	public static Test_game_manager instance = null;

	void Awake(){
		if(instance == null){
			instance = this;
		}
	}

	// coffre dans un coffre
	public void updateSelectedPlayer(Color color){
		selectedPlayer = color;
	}
}

