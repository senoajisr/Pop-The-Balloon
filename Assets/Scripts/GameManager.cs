using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameActive;

    private int score;
    private SpawnManager spawnManager;

    // Start is called before the first frame update
    void Start()
    {
        spawnManager = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame()
    {
        isGameActive = true;
        score = 0;

        spawnManager.StartSpawning();
    }

    public void StopGame()
    {
        isGameActive = false;
        spawnManager.StopSpawning();
    }
}
