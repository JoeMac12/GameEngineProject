using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum GameState { MainMenu, PauseMenu, OptionsMenu, WinMenu, LoseMenu }
    public GameState gameState;
    void Update()
    {
        switch (gameState)
        {
            case GameState.MainMenu: MainMenu();
                break;
            case GameState.PauseMenu: PauseMenu();
                break;
            case GameState.OptionsMenu: OptionsMenu();
                break;
            case GameState.WinMenu: WinMenu(); 
                break;
            case GameState.LoseMenu: LoseMenu();
                break;
        }
    }

    private void MainMenu()
    {
    }

    private void PauseMenu()
    {
    }

    private void OptionsMenu()
    {
    }

    private void WinMenu()
    {
    }
    private void LoseMenu()
    {
    }
}
