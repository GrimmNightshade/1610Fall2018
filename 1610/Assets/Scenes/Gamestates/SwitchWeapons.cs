using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SwitchWeapons : MonoBehaviour {
	
	public Weapons.WeaponTypes GameState;

	public UnityEvent Starting, Loading, Playing, Dieing, Ending;
	//refrencing the C# script gameStates

	private void Update()
	{
		/*switch (GameState)
		{
			case Weapons.WeaponTypes.Starting:
				print("Starting the game now");
				break;
             
             
			case Weapons.WeaponTypes.Playing:
				print("Play The game!");
				break;
            
            
			case Weapons.WeaponTypes.Loading:
				print("Loading.....");
				break;

			case Weapons.WeaponTypes.Dieing:
				print("Your Dead");
				break;
            
			case Weapons.WeaponTypes.Ending:
				print("Ending Game");
				break;
		} */
	}
}
