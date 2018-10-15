using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

[CreateAssetMenu]
public class AddToCollection : ScriptableObject
{

    public ObectCollection Collection;
    
    public void Call(ScriptableObject obj)
    {
        Collection.ObjectList.Add(obj);
    }
}
