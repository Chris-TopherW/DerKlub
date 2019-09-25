using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private enum GameStates {START_SCREEN, MAIN_GAME, PAUSE_SCREEN};
    public enum Names {FIRST_NAME, SIZE_OF_NAMES};
    public int gameState;
    public int currentClubberInLine = (int)Names.FIRST_NAME; //Index in clubbers list
    public int vibeStartPercent = 50;

    public List<Clubber> clubbers;
    public GameObject  vibeSlider;
    public DialogueImplementation dialogueImplementation;
     
    private int vibePercent;


    void Start()
    {
        gameState = (int)GameStates.START_SCREEN;

        SetupVibeMeter();

        StartBouncerInteraction();
    }

    void Update()
    {
        switch (gameState)
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

    public void StartBouncerInteraction()
    {
        dialogueImplementation.StartTestNode();
        clubbers[currentClubberInLine].ArriveAtStartOfLine();
    }

    public void MoveToNextClubber()
    {
        currentClubberInLine++;
        if(currentClubberInLine >= (int)Names.SIZE_OF_NAMES)
        {
            Debug.Log("ERRORRRRRR, index overflow m88- too many clubbers");
        }
        StartBouncerInteraction();
    }

    private void ResetGameState()
    {
        currentClubberInLine = (int)Names.FIRST_NAME;
    }

    public void VibeMeterCallback()
    {
        vibePercent = (int)(vibeSlider.GetComponent<Slider>().value * 100);
    }

    private void SetupVibeMeter()
    {
        vibePercent = vibeStartPercent;
        vibeSlider.GetComponent<Slider>().value = (float)(vibeStartPercent / 100f);
    }
}

public class GameState : MonoBehaviour
{

}
