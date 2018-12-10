using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instancing2D : MonoBehaviour {
	public GameObject Instance;

	void Update ()
	{
		if (Input.GetButtonDown("Fire1")) {

			Instantiate(Instance, transform.position, transform.rotation);
			{
	 
			}
		}
	}

}
