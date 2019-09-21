using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private enum GameStates {START_SCREEN, MAIN_GAME, PAUSE_SCREEN};
    public enum Names {FIRST_NAME, SIZE_OF_NAMES};
    public int GameState;
    public List<GameObject> Clubbers;
    public int CurrentClubberInLine = (int)Names.FIRST_NAME; //Index in clubbers list

    void Start()
    {
        GameState = (int)GameStates.START_SCREEN;

    }

    void Update()
    {
        switch (GameState)
        {
            case (int)GameStates.START_SCREEN:
                break;

            case (int)GameStates.MAIN_GAME:
                UpdateGame();
                break;
            case (int)GameStates.PAUSE_SCREEN:
                break;

        }

    }

    void UpdateGame()
    {

    }

    void ResetGameState()
    {
        CurrentClubberInLine = (int)Names.FIRST_NAME;
    }
}

public class GameState : MonoBehaviour
{

}
