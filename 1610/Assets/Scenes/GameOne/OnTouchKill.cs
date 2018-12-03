
using UnityEngine;

public class OnTouchKill : MonoBehaviour {

    private void OnCollisionEnter(Collision other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
