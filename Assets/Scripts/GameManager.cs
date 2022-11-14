using UnityEngine;
using System;

public class GameManager : Singleton<GameManager>
{


    public enum GameState { Start, InGame, End };
    public GameState currentState;

    void Start()
    {
        StartGame();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) == true && currentState == GameState.Start)
        {
            InGame();
        }
    }

    public void StartGame()
    {
        currentState = GameState.Start;
        UIController.instance.StartCanvasOn();

    }

    public void InGame()
    {
        currentState = GameState.InGame;
        UIController.instance.InGameCanvasOn();
      
    }

    public void endGame()
    {
        currentState = GameState.End;
        UIController.instance.EndCanvasOn();
    }

}