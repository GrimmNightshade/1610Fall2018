using UnityEngine;
using UnityEngine.Events;

public class MouseDownBehavoir : MonoBehaviour {

	public UnityEvent MouseDown;
	public UnityEvent MouseUp;
	

	private void OnMouseDown()
	{
		MouseDown.Invoke();
		print("Test");
	}
	private void OnMouseUp()
	{
		MouseUp.Invoke();
	}
}
