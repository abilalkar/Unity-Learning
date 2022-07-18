using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelixManager : MonoBehaviour
{
    public GameObject[] helixRings;
    public float spawnY = 0;
    public float ringDistance = 5;
    public int numberOfRings = 7;

    void SpawnRing(int ringIndex)
    {
        GameObject go = Instantiate(helixRings[ringIndex], transform.up * spawnY, Quaternion.identity);
        go.transform.parent = transform;
        spawnY -= ringDistance;
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfRings; i++)
        {
            if (i == 0)
            {
                SpawnRing(0);
            }
            else
            {
                SpawnRing(Random.Range(1, helixRings.Length - 1));

            }
        }
        SpawnRing(helixRings.Length - 1);
    }
}
    