using UnityEngine;

public class RocketControl : MonoBehaviour
{
    [SerializeField] GameObject LaunchVFX; // VFX GameObjects group
    public float thrust = 1000f;        // Base thrust in newtons
    public float pitchTorque = 10f;    // Torque for pitch control
    public float yawTorque = 10f;      // Torque for yaw control
    public float rollTorque = 10f;     // Torque for roll control

    private Rigidbody rb;
    [SerializeField]private float currentThrust;

    void Start()
    {
        // Set mass to approximate the real full rocket mass (~5000 metric tons)
        rb.mass = 5000f;  // Adjust this as needed for gameplay purposes
    }

    void Update()
    {
        // Handle rotational inputs (Pitch, Yaw, Roll)
        float pitch = Input.GetAxis("Vertical");  // W/S keys
        float yaw = Input.GetAxis("Horizontal");  // A/D keys
        float roll = 0f;
        if (Input.GetKey(KeyCode.Q)) roll = 1f;
        if (Input.GetKey(KeyCode.E)) roll = -1f;

        // Apply torque for rotation
        rb.AddTorque(transform.right * pitch * pitchTorque);  // Pitch control
        rb.AddTorque(transform.forward * yaw * yawTorque);         // Yaw control
        rb.AddTorque(transform.up * roll * rollTorque);  // Roll control
    }

    void FixedUpdate()
    {
        // Apply thrust force only when the player holds space
        if (Input.GetKey(KeyCode.Space))
        {
            Vector3 thrustForce = transform.up * currentThrust;  // Up is typically the forward direction for rockets
            rb.AddForce(thrustForce);
            LaunchVFX.SetActive(true);

        }
    }
}
