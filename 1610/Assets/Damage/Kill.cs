using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour {

    void OnCollisionStay(Collision col)
    {
        Destroy(col.gameObject);

    }


}
