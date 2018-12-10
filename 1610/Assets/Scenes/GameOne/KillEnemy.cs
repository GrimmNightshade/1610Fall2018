using System.Collections;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{
	IEnumerator Start () {

		yield return new WaitForSecondsRealtime(1);
		Destroy(gameObject);
	
	}
	
	private void OnCollisionEnter2D(Collision2D other)
	{
		
		print("Collid");
		if (other.gameObject.layer == 14)
		{
			Destroy(other.gameObject);
			print("Enemy");
			
		}
		Destroy(gameObject);
	}

}
