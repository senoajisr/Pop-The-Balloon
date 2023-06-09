﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {
    public List<GameObject> balloons;
    private bool spawning = true;
    private float spawnDelay = 10;
    private float spawnDelayReduction = 0.1f;
    private float currentSpawnDelay;
    private List<Vector3> spawnRange = new List<Vector3> {new Vector3(-23.54f, 22.5f, 55.7f), new Vector3(-23.54f, 10.7f, -60.5f)};

    // Start is called before the first frame update
    void Start() {
        currentSpawnDelay = spawnDelay;
        Global.balloonsPopped = 0;
        Global.Hearts = 3;
    }

    // Update is called once per frame
    void Update() {
        if (!spawning) return;
        currentSpawnDelay -= Time.deltaTime;

        if (currentSpawnDelay < 0) {
            SpawnBaloon();
            spawnDelay = Mathf.Max(1, spawnDelay - spawnDelayReduction);
            currentSpawnDelay = spawnDelay;
        }
    }

    public void StartSpawning() {
        spawning = true;
    }

    public void StopSpawning() {
        spawning = false;
    }

    private void SpawnBaloon() {
        int chosen_one = Random.Range(0, balloons.Count-1);
        GameObject balloon = Instantiate(balloons[chosen_one], generateSpawnPosition(), balloons[chosen_one].transform.rotation);
    }

    private Vector3 generateSpawnPosition() {
        return new Vector3(
            Random.Range(spawnRange[0].x, spawnRange[1].x),
            Random.Range(spawnRange[0].y, spawnRange[1].y),
            Random.Range(spawnRange[0].z, spawnRange[1].z)
        );
    }
}