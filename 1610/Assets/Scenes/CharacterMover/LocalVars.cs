using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalVars : MonoBehaviour
{
   string Name;

   public void Call()
   {
      Name = "Bob";
      
   }

   public void Call(string NewName)
   {
      print(NewName);
      print(Name);
   }

}
