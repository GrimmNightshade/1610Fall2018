using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITextChanger : MonoBehaviour
{
    public Text text;
    public StringData Input;

    private void Update()
    {
        text.text = Input.Value;
    }
}
