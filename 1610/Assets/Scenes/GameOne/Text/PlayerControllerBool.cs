using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class PlayerControllerBool : MonoBehaviour
{
   public FloatData Mode;
   
   
   public void Start()
   {
   
      GameObject Chara = GameObject.FindWithTag("Player");
      
      while (true)
      {
        if (Mode.Value != 1 || Mode.Value != 3)
             Chara.GetComponent<FlatMover>().enabled = true;
        else
        {
           Chara.GetComponent<FlatMover>().enabled = false;
        }
      }
     
   }
}
