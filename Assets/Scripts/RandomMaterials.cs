using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMaterials : MonoBehaviour
{
    public Material[] materials;

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start() {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        randomMaterial();
    }

    void randomMaterial() {
        int theChosenOne = Random.Range(0, materials.Length-1);
        gameObject.GetComponent<MeshRenderer>().material = materials[theChosenOne];
    }
}