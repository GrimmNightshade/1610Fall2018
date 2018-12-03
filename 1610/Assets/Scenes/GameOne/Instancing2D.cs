using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instancing2D : MonoBehaviour {
	public GameObject Instance;

	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.F)) {

			Instantiate(Instance, transform.position, transform.rotation);
			{
	 
			}
		}
	}

}
