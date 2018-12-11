using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.Events;

public class GameModeSwitch : MonoBehaviour {
	
	public GameTypes.wTypes GameLoad;
	public FloatData Flipper;
	
	public UnityEvent Start, Play, Death, Win;
	//refrencing the C# script gameStates


	private void Update()
	{
		if (Flipper.Value == 1f)
		{
			GameLoad = GameTypes.wTypes.Starting;
		}
		else if (Flipper.Value == 2f)
		{
			GameLoad = GameTypes.wTypes.Playing;
		}
		else if (Flipper.Value == 3f)
		{
			GameLoad = GameTypes.wTypes.Death;
		}
		else if (Flipper.Value == 4f)
		{
			GameLoad = GameTypes.wTypes.Win;
		}
		else
		{
			print("Errrorr!!!!");
		}
	
		
	switch (GameLoad)
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
