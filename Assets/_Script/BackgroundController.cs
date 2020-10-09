using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public float verticalSpeed;
    public float verticalBoundary;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }


    private void _Move()
    {
        //var newPosition = new Vector3(0.0f, verticalSpeed, 0.0f);
        //transform.position -= newPosition;
        transform.position -= new Vector3(0.0f, verticalSpeed); ;
    }


    private void _Reset()
    {
        transform.position = new Vector3(0.0f, verticalBoundary, 0.0f);
    }


    private void _CheckBounds()
    {
        // If the background is lower than the bottom of the screen then reset
        if(transform.position.y <= -verticalBoundary)
        {
            _Reset();
        }
    }
}
