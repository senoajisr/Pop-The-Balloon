using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour {
    public float speed = -0.01f;
    public Material[] materials;

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start() {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        randomMaterial();
    }

    // Update is called once per frame
    void Update() {
        transform.position += new Vector3(0, 0, speed);

        if (transform.position.y <= -21) {
            Destroy(gameObject);
        }
    }

    public void OnClick() {
        Destroy(gameObject);
    }

    void randomMaterial() {
        int theChosenOne = Random.Range(0, materials.Length-1);
        gameObject.GetComponent<MeshRenderer>().material = materials[theChosenOne];
    }
}