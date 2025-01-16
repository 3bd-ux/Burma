using UnityEditor.Callbacks;
using UnityEngine;

public class RigidBodyCharacterController : MonoBehaviour
{
    [SerializeField] private Vector3 input;
    [SerializeField] private float speed = 5f, jumpForce = 5f;
    [SerializeField] private bool jump, isOnGround;
    private Rigidbody rb;
    void Start()
    {
        jump = false;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        print(rb.GetPointVelocity(transform.position).y);
        if (rb.GetPointVelocity(transform.position).y != 0) // ground check
        {
            isOnGround = false;
        }
        else isOnGround = true;

        input = new Vector3(
                                Input.GetAxis("Horizontal"),
                                0,
                                Input.GetAxisRaw("Vertical")
                            );
        if (Input.GetKeyUp(KeyCode.Space) && isOnGround)
        {
            jump = true;
        }
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + input * Time.fixedDeltaTime * speed);
        if (jump)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jump = false;
        }
    }
}
