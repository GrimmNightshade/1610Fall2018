using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhatCanSeeIt : ScriptableObject {

	// Use this for initialization
	public float Health;
	protected float PowerLevel;
	public float EnergyLevel;
	
	private void AddHealth()
	{
		Health += 100;
	}

	protected void AddPower()
	{
		AddHealth();
	}

	public void AddEnergy()
	{
		
	}

	public class ICanSeeIt: MonoBehaviour
	{


		private void Start()
		{
			//newobject.EnergyLevel = 100;
			//newobject.AddEnergy();
		}
	}

//	public class Child : WhatCanSeeIt()
	//{
	//	void CallThings()
	//	{
		//	PowerLevel = 200;
		//	EnergyLevel = 300;
		//	AddPower();
			//AddEnergy();
		//}
	//}
}
