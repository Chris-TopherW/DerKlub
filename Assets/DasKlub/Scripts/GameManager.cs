using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private enum GameStates {START_SCREEN, MAIN_GAME, PAUSE_SCREEN};
    public enum Names {FIRST_NAME, SIZE_OF_NAMES};
    public int GameState;
    public int CurrentClubberInLine = (int)Names.FIRST_NAME; //Index in clubbers list
    public int mVibeStartPercent = 50;


    public List<GameObject> Clubbers;
    public GameObject VibeSlider;

     
    private int mVibePercent;



    void Start()
    {
        GameState = (int)GameStates.START_SCREEN;
        mVibePercent = mVibeStartPercent;
        VibeSlider.GetComponent<Slider>().value = (float)(mVibeStartPercent / 100f);
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

    private void UpdateGame()
    {
    }

    private void ResetGameState()
    {
        CurrentClubberInLine = (int)Names.FIRST_NAME;
    }

    public void VibeMeterCallback()
    {
        mVibePercent = (int)(VibeSlider.GetComponent<Slider>().value * 100);
    }
}

public class GameState : MonoBehaviour
{

}
