using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Spawn22[] pillars;

    private void Start() {
        
    }

    void SpawnPillar() {
        int i = Random.Range(0, 100);

        for (int j = 0; j < pillars.Length; j++) {
            if (i >= pillars[j].minProbabilityRange && i <= pillars[j].maxProbabilityRange) {
                Instantiate(pillars[j].spawnObject, transform.position, transform.rotation);

            }
        }
    }

}

[System.Serializable]
public class Pillars {
    public GameObject spawnObject;
    public int minProbabilityRange = 0;
    public int maxProbabilityRange = 0;
}
