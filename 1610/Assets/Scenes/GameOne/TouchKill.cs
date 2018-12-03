using UnityEngine;

public class TouchKill : MonoBehaviour {
	private void OnCollisionEnter2D(Collision2D other)
	{
		Destroy(other.gameObject);
		Destroy(gameObject);
	}		
}
