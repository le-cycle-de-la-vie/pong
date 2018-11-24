using UnityEngine;
using UnityEngine.SceneManagement;
public class Game_manager : MonoBehaviour 
{
	// Update is called once per frame
	void Update () 
	{
		Scene Screen = SceneManager.GetActiveScene();

		if(Screen.buildIndex == 0 && Input.GetMouseButton(0))
		{
			SceneManager.LoadScene(1, LoadSceneMode.Single);
		}
		
		if(Screen.buildIndex == 1 && Input.GetMouseButton(0))
		{
			SceneManager.LoadScene(2, LoadSceneMode.Single);
		}
	}
}
