using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestryoOutOfBounds : MonoBehaviour
{

    public float topBound = 30; //for projectiles
    public float lowerBound = -10; //for ani

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //destroy fruits when out of bounds
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }

        //destroy animals when out of bound
        if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
    }
}
