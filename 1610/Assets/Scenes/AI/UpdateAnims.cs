using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAnims : MonoBehaviour
{

	private Animator anims;
	public float speed;

	private void Start()
	{
		anims = GetComponent<Animator>();
	}

	void Update()
	{
		anims.SetFloat("speed", speed);
	}

}
