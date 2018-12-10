using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.Events;

public class GameModeSwitch : MonoBehaviour {
	
	public GameTypes.wTypes gameLoad;

	public UnityEvent Start, Play, Death, Win;
	//refrencing the C# script gameStates

	private void Update(String mode)
	{
	
		
		switch (gameLoad)
		{
			case GameTypes.wTypes.Starting:
				
				Start.Invoke();
				break;
             
             
			case GameTypes.wTypes.Playing:
				
				Play.Invoke();
				
				break;
            
            
			case GameTypes.wTypes.Death:
				
				Death.Invoke();
				break;
			
			case GameTypes.wTypes.Win :
				
				Win.Invoke();
				break;
				

		}
	}
}
