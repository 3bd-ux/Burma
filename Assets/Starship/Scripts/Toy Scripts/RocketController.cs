using UnityEngine;

public class RocketController : MonoBehaviour
{
    /// <summary>
    /// GPT's code
    /// </summary>

    private Vector3 initialVelocity;
    private float hoverTimer;
    /// <summary>
    ///  my code
    /// </summary>
    [SerializeField] GameObject rocket; // za BFR
    [SerializeField] GameObject LaunchVFX; // VFX GameObjects group
    [SerializeField] bool isHovering = false; // Toggle for hover mode
    [SerializeField] float hoverTime = 3f; // Time in seconds to cancel velocity
    [SerializeField] float baseAcceleration = 0.1f;
    [SerializeField] float currentThrust = 0f;
    [SerializeField] float acceleration = 9.8f;

    private Rigidbody rocketRb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rocketRb = rocket.GetComponent<Rigidbody>();
    }

    void Update()
    {   // H toggle to hover
        if (Input.GetKeyDown(KeyCode.H))
        {
            isHovering = !isHovering; // switch hover mode
            if (isHovering)
            {
                LaunchVFX.SetActive(true);
                hoverTimer = hoverTime;
                initialVelocity = rocketRb.linearVelocity; //capture velocity at the start of hover
            }
            else
            {
                LaunchVFX.SetActive(false);
            }
        }
        if (!isHovering) //if not hovering
        {
            if (Input.GetKey(KeyCode.Space)) // if player hold space
            {
                acceleration += baseAcceleration * Time.deltaTime;
                currentThrust += acceleration * Time.deltaTime;
                LaunchVFX.SetActive(true);
                Debug.Log("Speeding up!");
                rocketRb.AddForce(Vector3.up * currentThrust * Time.deltaTime, ForceMode.VelocityChange);
                //Debug.Log($"Velocity Change: {currentThrust * Time.deltaTime}");
                Debug.Log(currentThrust * Time.deltaTime * rocketRb.mass);

            }
            else if (!Input.GetKey(KeyCode.Space)) // if player is not holding space >> Gravity takes over
            {
                // currentSpeed -= gravityAcceleration * Time.deltaTime;
                Debug.Log("Falling!");
            }
            if (Input.GetKeyUp(KeyCode.Space)) // if player releases space
            {
                acceleration = 9.8f;
                LaunchVFX.SetActive(false);
                currentThrust = 0;
            }
        }
        //rocketRb.AddForce(0, acceleration * Time.deltaTime, 0, ForceMode.VelocityChange);
        //rocket.transform.position += new Vector3(0, currentSpeed * Time.deltaTime, currentSpeed * Time.deltaTime * 0.1f);

    }
    void FixedUpdate()
    {
        //Implement hover in fixed Update
        if (isHovering)
        {
            Hover();
        }
    }

    private void Hover()
    {
        if (hoverTimer > 0)
        {
            // Calculate the force required to negate velocity over time
            Vector3 decelerationForce = -(initialVelocity / hoverTime) * rocketRb.mass;

            // Apply the force
            rocketRb.AddForce(decelerationForce * Time.fixedDeltaTime, ForceMode.Force);

            // Update the hover timer
            hoverTimer -= Time.fixedDeltaTime;
            if (hoverTimer < 0 && hoverTime > -1)
            {            // Calculate the force required to negate velocity over time
                 decelerationForce = -(initialVelocity / hoverTime) * rocketRb.mass;

                // Apply the force
                rocketRb.AddForce(decelerationForce * Time.fixedDeltaTime, ForceMode.Force);
            }
        }
        else
        {
            // Once velocity is zero, maintain hover by canceling gravity
            rocketRb.linearVelocity = Vector3.zero;    //makes velocity =0
            // Vector3 antiGravityForce = -Physics.gravity * rocketRb.mass  //Push rb up = fall rb down; 
            // rocketRb.AddForce(antiGravityForce, ForceMode.Force);
        }
    }
}
