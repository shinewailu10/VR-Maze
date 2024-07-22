using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingingLight : MonoBehaviour
{
    public float swingSpeed = 3.0f; // Speed of the swinging motion
    public float swingAngle = 20.0f; // Maximum angle of swing

    private Quaternion startRotation;
    private float rotationDirection = 1.0f;

    void Start()
    {
        startRotation = transform.rotation;
    }

    void Update()
    {
        float angle = Mathf.Sin(Time.time * swingSpeed) * swingAngle * rotationDirection;
        transform.rotation = startRotation * Quaternion.Euler(0, angle, 0);
    }
}
