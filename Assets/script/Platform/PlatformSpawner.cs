
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject cam;
    public List<GameObject> platformPrefabs;
    public float gap = 2f;
    public float spawnAhead = 6f;
    float nextY = 2f;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float camTop = cam.transform.position.y + spawnAhead;

        while (nextY < camTop) {
            float x = Random.Range(-2.5f, 2.5f);
            int idx = Random.Range(0, platformPrefabs.Count);
            Instantiate(platformPrefabs[idx],new Vector3(x, nextY,  0f), Quaternion.identity);
            nextY += gap;
        }
    }
}
