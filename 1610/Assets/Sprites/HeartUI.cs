using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class HeartUI : MonoBehaviour
{

	public GameObject Heart3, Heart2, Heart1;
 	public FloatData Health;
	
	void Update () {
		if (Health.Value == 3f)
		{
			Heart3.SetActive(true); 
			Heart2.SetActive(true);
			Heart1.SetActive(true);
		}

		if (Health.Value == 2f)
		{
			Heart3.SetActive(false); 
			Heart2.SetActive(true);
			Heart1.SetActive(true);
		}

		if (Health.Value == 1f)
		{
			Heart3.SetActive(false); 
			Heart2.SetActive(false);
			Heart1.SetActive(true);
		}
		if (Health.Value <= 0f)
		{
			Heart3.SetActive(false); 
			Heart2.SetActive(false);
			Heart1.SetActive(false);
		}
	}
}
