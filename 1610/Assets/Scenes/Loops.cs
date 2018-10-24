using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Loops : MonoBehaviour {

    public string[] Names;
    public GameObject[] Things;   
    public GameObject[] Thing; 
    void Start()
    {

        
        for (int i = 0; i <= Names.Length; i++)
        {
            print(Names[i]);
        }

        foreach (GameObject Thing in Things)
        {
            
        }

       /* while (count != 25)
        {
            var count = 0;
            count += 1;
            print("Word " + count);   
        }
        
        */
        
    }
}
