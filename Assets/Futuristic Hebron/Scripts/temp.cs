using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class currentRigidbody : MonoBehaviour
{
    float steerSpeed = 15f;
    public Transform wheelFrontRight;
    float maxSteerAngle = 60f; 
    void Update()
    {
        steerWheels();
    }

    void steerWheels()
    {
        float currentAngleY = wheelFrontRight.localEulerAngles.y;

        // Ensure that the current angle is always within 0-360 degrees
        if (currentAngleY > 180f) 
        {
            currentAngleY -= 360f; // Converts angles > 180 to negative values for ease of calculation
        }

        // Clamp the steering to within -maxSteerAngle and maxSteerAngle
        if (Input.GetKey(KeyCode.RightArrow))
        {
            float newAngle = Mathf.Clamp((currentAngleY + steerSpeed * Time.deltaTime), -maxSteerAngle, maxSteerAngle);
            wheelFrontRight.localEulerAngles = new Vector3(0f, newAngle, 90f);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            float newAngle = Mathf.Clamp(currentAngleY - steerSpeed * Time.deltaTime, -maxSteerAngle, maxSteerAngle);
            wheelFrontRight.localEulerAngles = new Vector3(0f, newAngle, 90f);
        }
    }
}
