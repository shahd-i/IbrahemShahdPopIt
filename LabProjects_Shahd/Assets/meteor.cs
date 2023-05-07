using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class meteor : MonoBehaviour
{
    public float oscillationSpeed = 0.1f;
    public float oscillationMagnitude = 1.0f;

    private float initialXPosition;
    private float initialYPosition;

    void Start()
    {
        initialXPosition = transform.position.x;
        initialYPosition = transform.position.y;
    }

    void Update()
    {
        float x = initialXPosition + Mathf.Sin(Time.time * oscillationSpeed) * oscillationMagnitude;
        float y = initialYPosition + Mathf.Cos(Time.time * oscillationSpeed) * oscillationMagnitude;

        transform.position = new Vector3(x, y, transform.position.z);
    }
}