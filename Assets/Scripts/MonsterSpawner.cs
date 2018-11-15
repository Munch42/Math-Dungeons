using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour {

    public GameObject ImpMonsterPrefab;
    public GameObject TrollMonsterPrefab;
    public GameObject DragonMonsterPrefab;

    private Vector2 monsterSpawnPoint;

	// Use this for initialization
	void Start () {
        monsterSpawnPoint = transform.position;

        int monsterNum = Random.Range(1,4);

        if (monsterNum == 1)
        {
            Instantiate(ImpMonsterPrefab, monsterSpawnPoint, Quaternion.identity);
            //Debug.Log(monsterNum);
        }

        if (monsterNum == 2)
        {
            Instantiate(TrollMonsterPrefab, monsterSpawnPoint, Quaternion.identity);
            //Debug.Log(monsterNum);
        }

        if (monsterNum == 3)
        {
            Instantiate(DragonMonsterPrefab, monsterSpawnPoint, Quaternion.identity);
            //Debug.Log(monsterNum);
        }
    }
	
	// Update is called once per frame
	void Update () {
        
    }
}
