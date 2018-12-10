using UnityEngine;
using UnityEngine.Events;
using System.Collections;



public class Kill : MonoBehaviour {
   
    public UnityEvent Damage;

    private IEnumerator OnCollisionEnter2D(Collision other)
    {
        print("ye");
        if (other.gameObject.layer == 11)
        {
            print("there");
            Damage.Invoke();
            yield return new WaitForSeconds(1);  
        }

      
    }



}
