
using UnityEngine;

[CreateAssetMenu]
public class ChangeText : ScriptableObject
{
    public StringData Output;

    public void StringUpdate (StringData Input)
    {
         Input.Value = Output.Value;
    }
}
