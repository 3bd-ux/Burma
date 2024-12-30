using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class AddTorque : MonoBehaviour
{
    [SerializeField] private float rawX;
    [Range(0f, 1f)]
    [SerializeField] private float normalizedX;
    // [SerializeField] private float normalizedZ;
    [SerializeField] private GameObject page1; //temp
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private Camera mainCamera;
    [SerializeField] private float torqueStrength = -100f;

    private Rigidbody activeRb;
    private bool isDragging = false;

    void Update()
    {
        normalizedX = (GetAnimationDriver(page1));
        if (Input.GetMouseButtonDown(0))
        {
            activeRb = GetRigidbodyUnderMouse();
            if (activeRb != null)
            {
                isDragging = true;
                activeRb.useGravity = false;
            }

        }
        if (Input.GetMouseButtonUp(0) && activeRb != null)
        {
            isDragging = false;
            activeRb.useGravity = true;
            activeRb = null;
        }
    }

    void FixedUpdate()
    {
        if (isDragging && activeRb != null)
        {
            // Get mouse pos on X axis
            float mouseX = Input.GetAxis("Mouse X");

            Vector3 torque = mouseX * torqueStrength * Vector3.forward;
            activeRb.AddTorque(torque, ForceMode.Force);
        }
    }

    public Rigidbody GetRigidbodyUnderMouse()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity, layerMask);
        return hit.rigidbody;
    }

    public float GetAnimationDriver(GameObject gameObject)
    {
        // necessary calculations to get the Z angle
        // Quaternion objectRotation = gameObject.transform.rotation;
        // float zRotationQuaternion = objectRotation.eulerAngles.z;
        // return zRotationQuaternion;


        // normalize the z Angle
        // float rawZAngle = objectRotation.eulerAngles.z;
        // normalizedZ = Mathf.InverseLerp(-1, 180, rawZAngle);


        // normalize the x position
        rawX = gameObject.transform.position.x;
        normalizedX = Mathf.InverseLerp(2.5f, -2.5f, rawX);

        return normalizedX;
    }
}
