using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class OnCollision : MonoBehaviour {

    public UnityEvent Hit;
    public UnityEvent Heal;

    void OnCollisionStay(Collision col)
   {
        if (col.gameObject.name == "bullet")
        {
            Hit.Invoke();
        }
        if (col.gameObject.name == "medkit")
        {
            Heal.Invoke();
        }

    }

}
