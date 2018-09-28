using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlterForce : MonoBehaviour {

    public float ZMomentum;
    public float XMomentum;
    public float YMomentum;
    public Rigidbody FuckPhysics;

    private void FixedUpdate()
    {
        FuckPhysics.AddForce(XMomentum, YMomentum, ZMomentum * Time.deltaTime);
    }
}
