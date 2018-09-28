using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class ValueChange : ScriptableObject
{

    public FloatData ValueObj;


    public UnityEvent EventMax;
    public UnityEvent EventMin;


    public void AddValueToObj(FloatData data)
    {
        ValueObj.Value += data.Value;
    }
    public void SubractValueToObj(FloatData data)
    {
        ValueObj.Value -= data.Value;
    }
    public void MultiplyValueToObj(FloatData data)
    {
        ValueObj.Value *= data.Value;
    }
    public void DivideValueToObj(FloatData data)
    {
        ValueObj.Value /= data.Value;
    }
}
