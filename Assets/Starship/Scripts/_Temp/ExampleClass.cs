using UnityEngine;
using System.Collections;


public class ExampleClass : MonoBehaviour
{
    public float pitchTorque = 10f;    // Torque for pitch control
    public float yawTorque = 10f;      // Torque for yaw control
    public float rollTorque = 10f;     // Torque for roll control

    [SerializeField] Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // if (Input.GetKey(KeyCode.A)){} 
        // if (Input.GetKey(KeyCode.D)){} 
        // if (Input.GetKey(KeyCode.W)){} 
        // if (Input.GetKey(KeyCode.S)){} 
        // if (Input.GetKey(KeyCode.Q)){} 
        // if (Input.GetKey(KeyCode.E)){} 
        float pitch = Input.GetAxis("Vertical");  // W/S keys
        float roll = Input.GetAxis("Horizontal");  // A/D keys
        float yaw = 0f;
        if (Input.GetKey(KeyCode.Q)) yaw = 1f;
        if (Input.GetKey(KeyCode.E)) yaw = -1f;

        // Apply torque for rotation
        rb.AddTorque(transform.right * pitch * pitchTorque);  // Pitch control
        rb.AddTorque(transform.up * roll * rollTorque);         // roll control
        rb.AddTorque(transform.forward * yaw * yawTorque);  // yaw control
    }

}