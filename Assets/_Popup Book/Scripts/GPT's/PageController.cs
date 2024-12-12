using UnityEngine;

public class PageController : MonoBehaviour
{
    [SerializeField] private float speed = -360f; // Rotation speed
    private Transform hinge;

    private void Awake()
    {
        hinge = transform.parent; // Parent is the hinge
    }

    public void RotatePage(float input)
    {
        float currentAngle = hinge.localEulerAngles.z;
        currentAngle = currentAngle > 180 ? currentAngle - 360 : currentAngle; // Convert to -180 to 180

        float newAngle = Mathf.Clamp(currentAngle + input * speed * Time.deltaTime, 0, 180);
        hinge.localRotation = Quaternion.Euler(0, 0, newAngle);
    }

    public bool IsFullyOpenOrClosed()
    {
        float currentAngle = hinge.localEulerAngles.z;
        currentAngle = currentAngle > 180 ? currentAngle - 360 : currentAngle; // Convert to -180 to 180

        return Mathf.Approximately(currentAngle, 0) || Mathf.Approximately(currentAngle, 180);
    }
}
