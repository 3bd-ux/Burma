using UnityEngine;

public class HingeController : MonoBehaviour
{
    [SerializeField] private Transform bookLeftHinge; // Reference to the book hinge.
    [SerializeField] private Transform targetObject; // Reference to the object to control.
    [Range(0.0f, 180.0f)]
    [SerializeField] private float maxRotation = 180.0f; // Maximum hinge rotation angle.
    [SerializeField] private float sensitivity = 1.0f; // Sensitivity of the drag input.

    private Vector3 initialMousePosition; // Tracks the mouse position when the drag starts.
    private bool isDragging = false; // Tracks whether the mouse is dragging.
    private float currentRotation = 0.0f; // Tracks the current hinge rotation.

    void Update()
    {
        HandleMouseInput();
        UpdateTargetObject();
    }

    private void HandleMouseInput()
    {
        if (Input.GetMouseButtonDown(0)) // Left mouse button pressed.
        {
            // Start drag and record initial mouse position.
            isDragging = true;
            initialMousePosition = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0)) // Left mouse button released.
        {
            // End drag.
            isDragging = false;
        }

        if (isDragging)
        {
            // Calculate the drag delta.
            Vector3 currentMousePosition = Input.mousePosition;
            Debug.Log(currentMousePosition.x);
            float dragDistance = (currentMousePosition.x - initialMousePosition.x) * sensitivity;
            

            // Update the current rotation based on the drag distance.
            currentRotation = Mathf.Clamp(currentRotation + dragDistance, 0.0f, maxRotation);

            // Apply the rotation to the book hinge.
            bookLeftHinge.localRotation = Quaternion.Euler(0, 0, currentRotation);

            // Update the initial mouse position for smooth dragging.
            initialMousePosition = currentMousePosition;
        }
    }

    private void UpdateTargetObject()
    {
        // Normalize the hinge rotation to a range of [0, 1].
        float normalizedRotation = currentRotation / maxRotation;

        // Lerp the target object's Z rotation from 0 to 90 degrees.
        float targetZRotation = Mathf.Lerp(0.0f, 90.0f, normalizedRotation);

        // Lerp the target object's X scale from 1 to 0.1.
        float targetXScale = Mathf.Lerp(1.0f, 0.01f, normalizedRotation);

        // Apply the calculated rotation and scale to the target object.
        //targetObject.localRotation = Quaternion.Euler(0, 0, targetZRotation);
        targetObject.localScale = new Vector3(targetObject.localScale.x, targetXScale, targetObject.localScale.z);
    }
}
