using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
	public CharacterController Character;

	public Vector3 RotateSpeed;
	public Vector3 MoveSpeed;
	public float Speed;

	public void Update()
	{
		MoveSpeed.x = Speed * Input.GetAxis("Horizontal");
		MoveSpeed *= Time.deltaTime;

		Character.Move(MoveSpeed);
	}


}
	
//private void Update () {
//transform.Translate(1,0,1);
//MoveSpeed.x = Speed*Input.GetAxis("Horizontal");
//MoveSpeed *= Time.deltaTime;
//transform.Rotate(RotateSpeed);
//transform.Translate(MoveSpeed);
		
//}