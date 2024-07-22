using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChanging : MonoBehaviour
{
    public Color[] colors; // Array of colors to cycle through
    public float changeInterval = 2f; // Time interval between color changes

    private Light lightComponent;
    private int currentIndex = 0;

    void Start()
    {
        lightComponent = GetComponent<Light>();
        InvokeRepeating("ChangeColor", 0, changeInterval);
    }

    void ChangeColor()
    {
        lightComponent.color = colors[currentIndex];
        currentIndex = (currentIndex + 1) % colors.Length;
    }
}