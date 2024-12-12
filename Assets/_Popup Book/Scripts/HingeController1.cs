using UnityEngine;

public class HingeController1 : MonoBehaviour
{
    [SerializeField] private float speed = -360f; // Degrees per second for responsiveness
    [SerializeField] private float minAngle = 0f; // Minimum rotation angle
    [SerializeField] private float maxAngle = 180f; // Maximum rotation angle

    private float currentAngle;

    private void Start()
    {
        // Initialize the current angle
        currentAngle = transform.localEulerAngles.z;
    }

    void Update()
    {
        if (Input.GetMouseButton(0)) // Left mouse button pressed
        {
            HandleRotation();
        }
    }

    private void HandleRotation()
    {
        // Get mouse input
        float xAxis = Input.GetAxis("Mouse X");

        // Calculate the desired angle change, scaled by speed and Time.deltaTime
        float angleChange = xAxis * speed * Time.deltaTime;

        // Update and clamp the current angle
        currentAngle = Mathf.Clamp(currentAngle + angleChange, minAngle, maxAngle);

        // Apply the rotation
        transform.localRotation = Quaternion.Euler(0, 0, currentAngle);
    }
}
