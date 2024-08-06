using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    Vector3 startPosition;
    float repeatWidth;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        repeatWidth = 34.98756f / 2;
    }

    // Update is called once per frame
    // void Update()
    // {
        
    // }

    void FixedUpdate()
    {
        if (transform.position.x < startPosition.x - repeatWidth)
        {
            transform.position = startPosition;
        }
    }
}