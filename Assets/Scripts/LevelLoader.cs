using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
	private GameManager _gameManager;

	public void LoadLevel(string scenename)
	{
		LoadScene(scenename);
	}

	public void Awake()
	{
		_gameManager = FindObjectOfType<GameManager>();
	}

	void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
		Debug.Log("Load Scene: " + scene.name);
	}

	void LoadScene(string sceneToLoad)
	{
		SceneManager.sceneLoaded += OnSceneLoaded;

		if (sceneToLoad != null)
		{
			if (sceneToLoad.StartsWith("GrassLevel"))
			{
				_gameManager.gameState = GameManager.GameState.GamePlay;
			}
			else if (sceneToLoad.StartsWith("MainMenu"))
			{
				_gameManager.gameState = GameManager.GameState.MainMenu;
			}

			SceneManager.LoadScene(sceneToLoad);
		}
	}
}
