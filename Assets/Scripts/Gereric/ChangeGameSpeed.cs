using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGameSpeed : MonoBehaviour
{
    public float maxSpeed = 3.0f;

    public float speedMultiplier = 0.04f;

    private float currentSpeed = 1;

    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {

        currentSpeed += speedMultiplier * Time.deltaTime;

        Time.timeScale = Mathf.Clamp(
            currentSpeed,
            1,
            maxSpeed
        );
    }
}
