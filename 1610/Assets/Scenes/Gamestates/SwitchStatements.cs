using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SwitchStatements : MonoBehaviour
{
   
    public GameStates.States GameState;

    public UnityEvent Starting, Loading, Playing, Dieing, Ending;
    //refrencing the C# script gameStates

    private void Update()
    {
        switch (GameState)
        {
             case GameStates.States.Starting:
                 print("Starting the game now");
                 break;
             
             
            case GameStates.States.Playing:
                 print("Play The game!");
                 break;
            
            
            case GameStates.States.Loading:
                print("Loading.....");
                break;

            case GameStates.States.Dieing:
                print("Your Dead");
                break;
            
            case GameStates.States.Ending:
                 print("Ending Game");
                 break;
        }
    }
}
