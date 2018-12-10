using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using UnityEngine.Events;
using UnityEngine;

public class FlatMover : MonoBehaviour {

	public Rigidbody2D Controller;
	public float Gravity = 9.5f;
	public float MoveSpeed = 10f;
	public float JumpSpeed = 100f;
	public bool FaceRight = true;


	private bool OnGround = false, Grounded = false;
	public LayerMask IsGround;
	public Transform ObjectCheck;
	public Transform HeadCheck;
	

	private Vector3 C_Velocity = Vector3.zero;
	public float MoveSmoother = .5f;
	private float HeadCollider = .2f;

	public UnityEvent OnLandEvent, Walking, Idle, Attack;

// Finds the Object it needs to move
	void Start () {
		Controller = GetComponent<Rigidbody2D>();
	}	

	
	//Checks if grounded
	public void FixedUpdate()
	{
		bool Grounded = OnGround;
		OnGround = false;

		Collider2D[] colliders = Physics2D.OverlapCircleAll(ObjectCheck.position, HeadCollider, IsGround);
		for (int i = 0; i < colliders.Length; i++)
		{
			if (colliders[i].gameObject != gameObject)
			{
				OnGround = true;
				if (!Grounded)
				{
					OnLandEvent.Invoke();
				}
			}
		}

		if (OnGround == true)
		{
			//Attack Command
			if (Input.GetButtonDown("Fire1"))
			{
				Attack.Invoke();
				
			}
			
			
			Vector3 targetVelocity = new Vector2(MoveSpeed * Input.GetAxis("Horizontal"), Controller.velocity.y);
			
			//Moves Character
			Controller.velocity = Vector3.SmoothDamp(Controller.velocity, targetVelocity, ref C_Velocity, MoveSmoother);
			
			Walking.Invoke();
			
			//Flips Character direction
			if (Input.GetAxis("Horizontal") > 0 && !FaceRight || Input.GetAxis("Horizontal") < 0 && FaceRight)
			{
				FaceRight = !FaceRight;
				Vector3 CScale = transform.localScale;
				CScale.x *= -1;
				transform.localScale = CScale;
			}
			//Activate jump
			if (Input.GetButton("Jump"))
			{
				OnGround = false;
				Controller.AddForce(new Vector2(0f, JumpSpeed));
			}

			if (!Input.GetButton("Horizontal"))
			{
				Idle.Invoke();
			}
		}
	}
}
	
	
	


