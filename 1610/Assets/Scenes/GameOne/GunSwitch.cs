using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GunSwitch : MonoBehaviour {
	
	public WeaponTypes.wTypes WeaponType;

	public UnityEvent Pew, uzi, Shotgun;
	//refrencing the C# script gameStates

	private void Update()
	{
		switch (WeaponType)
		{
			case WeaponTypes.wTypes.Pew:
				print("Starting the game now");
				Pew.Invoke();
				break;
             
             
			case WeaponTypes.wTypes.uzi:
				print("Play The game!");
				uzi.Invoke();
				
				break;
            
            
			case WeaponTypes.wTypes.Shotgun:
				print("Loading.....");
				Shotgun.Invoke();
				break;

		}
	}
}
