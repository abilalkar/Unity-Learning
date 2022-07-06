using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestryoOutOfBounds : MonoBehaviour
{

    public float topBound = 30;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //destroy animals when out of bounds
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
    }
}
