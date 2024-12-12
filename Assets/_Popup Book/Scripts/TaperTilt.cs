using UnityEngine;

public class TaperTilt : MonoBehaviour
{
    public Transform parentObject; // Parent object to scale
    public Transform childObject; // Child object to rotate
    public float rotationAngle = 45f; // Target rotation angle for the child
    public float squashFactor = 0.5f; // Target squash scale for the parent (Y-axis)
    public float duration = 0.5f; // Duration for the effect
    private Vector3 parentOriginalScale;
    private Quaternion childOriginalRotation;
    private bool isSquashing = false;

    public bool triggerEffect = false; // Tick this in the Inspector to trigger the effect

    void Start()
    {
        if (parentObject != null)
            parentOriginalScale = parentObject.localScale;
        if (childObject != null)
            childOriginalRotation = childObject.localRotation;
    }

    void Update()
    {
        if (triggerEffect && !isSquashing)
        {
            triggerEffect = false; // Reset the toggle in the Inspector
            StartCoroutine(GradualRotateAndSquash());
        }
    }

    System.Collections.IEnumerator GradualRotateAndSquash()
    {
        isSquashing = true;

        // Prepare target values
        Quaternion targetRotation = Quaternion.Euler(0, 0, rotationAngle) * childOriginalRotation;
        Vector3 squashedScale = new Vector3(parentOriginalScale.x, parentOriginalScale.y * squashFactor, parentOriginalScale.z);

        // Gradually apply the effect
        float elapsedTime = 0f;
        while (elapsedTime < duration)
        {
            float t = elapsedTime / duration;

            // Interpolate between original and target states
            parentObject.localScale = Vector3.Lerp(parentOriginalScale, squashedScale, t);
            childObject.localRotation = Quaternion.Lerp(childOriginalRotation, targetRotation, t);
            Debug.Log(parentObject.localScale);
            Debug.Log(childObject.localRotation);
            elapsedTime += Time.deltaTime;
            yield return null; // Wait for the next frame
        }

        // Ensure final states
        parentObject.localScale = squashedScale;
        childObject.localRotation = targetRotation;

        // Pause for the duration, if needed
        yield return new WaitForSeconds(0.1f); // Optional delay before resetting

        // Gradually reset to the original states
        elapsedTime = 0f;
        while (elapsedTime < duration)
        {
            float t = elapsedTime / duration;

            // Interpolate back to original states
            parentObject.localScale = Vector3.Lerp(squashedScale, parentOriginalScale, t);
            childObject.localRotation = Quaternion.Lerp(targetRotation, childOriginalRotation, t);

            elapsedTime += Time.deltaTime;
            yield return null; // Wait for the next frame
        }

        // Ensure original states are restored
        parentObject.localScale = parentOriginalScale;
        childObject.localRotation = childOriginalRotation;

        isSquashing = false;
    }
}
