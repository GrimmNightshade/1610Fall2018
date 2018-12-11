
using UnityEngine;

[CreateAssetMenu]
public class ChangeText : ScriptableObject
{
    public StringData Output;

    public void StringUpdate (StringData Input)
    {
        Output.Value = Input.Value;
    }
}
