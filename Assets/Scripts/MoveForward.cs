using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public bool speedCanIncrease = true;
    public float speed = -0.1f;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(speed, 0, 0);

        if (transform.position.x <= -120) {
            Global.Hearts -= 1;
            Destroy(gameObject);
        }
    }
}
