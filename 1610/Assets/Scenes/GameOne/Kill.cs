using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System.Security.Cryptography.X509Certificates;


public class Kill : MonoBehaviour
{
    private bool hurt = false;
    public UnityEvent Damage;
   
    private float time = 2f;

    private void OnCollisionEnter2D(Collision2D other)
    {
        print("ye");
        if (other.gameObject.layer == 11)
        {
            if (!hurt)
            {
              Damage.Invoke();
               print("there");
                hurt = true;
            }
            
        }

    }

    void Update()
    {
        if (hurt)
        {
            time -= Time.deltaTime;
            if (time < 0)
            {
                hurt = false;
                time = 2f;
            }
        }

    }

    
            
        

    

}



