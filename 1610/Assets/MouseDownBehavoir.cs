using UnityEngine;
using UnityEngine.Events;

public class MouseDownBehavoir : MonoBehaviour {

	public UnityEvent Event;

	private void OnMouseDown()
	{
		Event.Invoke();
	}
}
