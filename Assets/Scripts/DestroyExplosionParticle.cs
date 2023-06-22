using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyExplosionParticle : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 2); // destroy particle after 2 seconds
    }


}
