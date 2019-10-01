using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarSpawner : MonoBehaviour
{
    int refr;
    public Spawn22[] pillars;
    public GameObject Coin;
    public int CoinSpawnProbability = 40;
    public float PillarRange;

    private void Start() {
        // spawn pillars at game start
        // spawn pillar di pos pertama
        // spawn pillar kedua dengan posisi di tambah pillar range
        // ulangi step diatas sampe total 6 pillar
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow)) {
            SpawnPillar();
            SpawnCoin();
        }
    }



    // spawn a pillar
    void SpawnPillar() {
        int i = Random.Range(0, 100);

        for(int j = 0; j < pillars.Length; j++) {
            if(i >= pillars[j].minProbabilityRange && i <= pillars[j].maxProbabilityRange) {
                Instantiate(pillars[j].spawnObject, transform.position, transform.rotation);
                refr = j;
            }
        }
    }
    
    // spawn a coin
    void SpawnCoin() {
        int rand = Random.Range(0, 100);
        if (refr == 0) { // safe pillars
            if(rand > CoinSpawnProbability) {
                rand = Random.Range(0, 100);
                if(rand > 50) {
                    // spawn left side
                    Instantiate(Coin, new Vector2(-1, 4.75f), transform.rotation);
                } else {
                    // spawn right side
                    Instantiate(Coin, new Vector2(1, 4.75f), transform.rotation);
                }
            }
        } 
        else if (refr == 1) { // left pillars
            if (rand > CoinSpawnProbability) {
                if (rand > 50) {
                    Instantiate(Coin, new Vector2(1, 4.75f), transform.rotation);
                }
            }
        } 
        else if (refr == 2) { // right pillars
            if (rand > CoinSpawnProbability) {
                if (rand > 50) {
                    Instantiate(Coin, new Vector2(-1, 4.75f), transform.rotation);
                }
            }
        }
    }
   
}

[System.Serializable]
public class Spawn22 {
    public GameObject spawnObject;
    public int minProbabilityRange = 0;
    public int maxProbabilityRange = 0;
}
