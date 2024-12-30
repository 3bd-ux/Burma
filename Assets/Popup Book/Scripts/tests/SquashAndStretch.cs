using UnityEngine;

public class RotateAndSquash : MonoBehaviour
{
    public Transform parentObject; // Parent object to scale
    public Transform childObject; // Child object to rotate
    public float rotationAngle = 45f; // Target rotation angle for the child
    public float squashFactor = 0.5f; // Target squash scale for the parent (Y-axis)
    public float duration = 0.5f; // Duration for the effect

    private Vector3 parentOriginalScale;
    private Quaternion childOriginalRotation;
    //private bool isSquashing = false;

    void Start()
    {
        if (parentObject != null)
            parentOriginalScale = parentObject.localScale;
        if (childObject != null)
            childOriginalRotation = childObject.localRotation;
    }

    // Call this method to update the effect based on page progress
    public void UpdateEffect(float progress)
    {
        if (progress >= 0 && progress <= 1)
        {
            // Interpolate between the original and target states based on progress
            ApplyEffect(progress);
        }
    }

    private void ApplyEffect(float progress)
    {
        // Calculate the target rotation and squash scale based on progress
        Quaternion targetRotation = Quaternion.Euler(0, 0, rotationAngle * progress) * childOriginalRotation;
        Vector3 squashedScale = new Vector3(parentOriginalScale.x, parentOriginalScale.y * (1 - (squashFactor * progress)), parentOriginalScale.z);

        // Apply gradual effect by using the progress value
        parentObject.localScale = squashedScale;
        childObject.localRotation = targetRotation;
    }
}
