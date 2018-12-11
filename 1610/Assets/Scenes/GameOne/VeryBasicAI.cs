using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VeryBasicAI : MonoBehaviour
{
	public Rigidbody2D Controller; 
	public float startPos;
	public bool max;
	public float maxDistance;
	public float MoveSpeed;
	private bool faceforward = true;

	private void Start()
	{
		startPos = transform.position.x;
	}

	void Update ()
	{
		if(transform.position.x <= startPos - maxDistance)
		{
			max = true;
		}
		if (transform.position.x >= startPos)
		{
			max = false;
		}

		if (!max)
		{
			Controller.velocity = new Vector2(-MoveSpeed * Time.deltaTime, Controller.velocity.y);
			if (!faceforward)
			{
				faceforward = true;
				Vector3 CScale = transform.localScale;
				CScale.x *= -1;
				transform.localScale = CScale;
			}

		}
		else
		{
			
			Controller.velocity = new Vector2(MoveSpeed * Time.deltaTime, Controller.velocity.y);
			if (faceforward)
			{
				faceforward = false;
				Vector3 CScale = transform.localScale;
				CScale.x *= -1;
				transform.localScale = CScale;
			}
			
		}
	}
}
