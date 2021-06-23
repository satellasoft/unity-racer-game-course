using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int maxEnemyCarInScene = 5;
    public GameObject enemyCarPrefabs;
    public Transform spawnPosition;

    [Space(10)]
    public float timeToSpawn = 4.0f;

    [Space(10)]
    public float[] spawn3DPosition = new float[3] {
        -4.5f,
        0.0f,
        4.5f
    };

    private GameObject[] listEnemyCars;

    void Start()
    {

        listEnemyCars = new GameObject[maxEnemyCarInScene];

        for (int i = 0; i < maxEnemyCarInScene; i++)
        {
            GameObject go = Instantiate(enemyCarPrefabs,
            spawnPosition.position,
            spawnPosition.rotation
            );

            go.SetActive(false);

            go.name = string.Format("EnemyCar-0{0}", (i + 1).ToString());

            listEnemyCars[i] = go;
        }

        InvokeRepeating("SpawnCar", timeToSpawn, timeToSpawn);
    }

    void SpawnCar()
    {
        for (int i = 0; i < listEnemyCars.Length; i++)
        {
            if (!listEnemyCars[i].activeInHierarchy)
            {
                GameObject go = listEnemyCars[i];

                go.SetActive(true);

                float posX = spawn3DPosition[Random.Range(0, spawn3DPosition.Length)];

                go.transform.position = new Vector3(posX, spawnPosition.position.y, spawnPosition.position.z);

                go.GetComponentInChildren<Renderer>().materials[1].color = GetRandonColor();

                return;
            }
        }
    }

    private Color GetRandonColor()
    {
        return Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }
}
