using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float time = 0.0f;
    private float timer = 2.0f;


    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > timer)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // On spacebar press, send dog
                Instantiate(dogPrefab, new Vector3(17, 0, 0), dogPrefab.transform.rotation);
                time = 0.0f;
            }
        }
    }
}
