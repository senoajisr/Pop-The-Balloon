using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public float speed = -0.01f;

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, speed);

        if (transform.position.z <= -21) {
            Destroy(gameObject);
        }
    }

    public void OnClick()
    {
        Destroy(gameObject);
    }
}
