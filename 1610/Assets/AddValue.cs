
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class AddValue : ScriptableObject {

	public FloatData ValueObj;
	public FloatData Maxvalue;
	public FloatData MinValue;

	public UnityEvent EventMax;
	public UnityEvent EventMin;


	public void AddValueToObj (FloatData data)
	 {
		ValueObj.Value += data.Value;

		if (ValueObj.Value >= Maxvalue.Value)
		{
			EventMax.Invoke();
		}

		if (ValueObj.Value <= MinValue.Value)
		{
			EventMin.Invoke();
		}

	}
}
