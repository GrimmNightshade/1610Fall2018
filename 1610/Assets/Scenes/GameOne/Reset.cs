using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Reset : MonoBehaviour
{
	public FloatData Health;
	public StringData Text;
	public FloatData GameMode;

	// Use this for initialization
	void Start()
	{
		Health.Value = 3;
		GameMode.Value = 2;
		Text.Value = "";

	}
}
	

