using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeOfDayController : MonoBehaviour
{
    public Transform sunTransform;
    public Vector3 afternoonRotation = new Vector3(30f, 30f, 0f); // Example rotation for afternoon
    public Vector3 eveningRotation = new Vector3(90f, 0f, 0f); // Example rotation for evening
    public float transitionDuration = 60.0f; // Duration of transition from afternoon to evening in seconds

    private float elapsedTime = 0.0f;

    void Update()
    {
        // Increment elapsed time
        elapsedTime += Time.deltaTime;

        // Calculate interpolation factor based on elapsed time and transition duration
        float t = Mathf.Clamp01(elapsedTime / transitionDuration);

        // Interpolate between afternoon and evening rotations
        sunTransform.rotation = Quaternion.Euler(Vector3.Lerp(afternoonRotation, eveningRotation, t));
    }
}
