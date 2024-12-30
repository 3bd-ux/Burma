using UnityEngine;

public class StarshipTest : MonoBehaviour
{
    [SerializeField] private Transform starship;

    [SerializeField] private Transform bookLeftHinge; // Reference to the book hinge.
    [SerializeField] private Transform targetObject; // Reference to the object to control.
    [Range(0.0f, 180.0f)]
    [SerializeField] private float maxRotation = 180.0f; // Maximum hinge rotation angle.
    //[SerializeField] private float maxAlt = 10.0f;/////////////////
    [SerializeField] private float sensitivity = 0.25f; // Sensitivity of the drag input.

    private Vector3 initialMousePosition; // Tracks the mouse position when the drag starts.
    private bool isDragging = false; // Tracks whether the mouse is dragging.
    private float currentRotation = 0.0f; // Tracks the current hinge rotation.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        HandleMouseInput();
        UpdateTargetObject();
    }
    private void UpdateTargetObject()
    {
        // Normalize the hinge rotation to a range of [0, 1].
        float normalizedRotation = currentRotation / maxRotation;

        // Lerp the target object's Z rotation from 0 to 90 degrees.
        float targetZRotation = Mathf.Lerp(0.0f, 90.0f, normalizedRotation);

        // Lerp the target object's X scale from 1 to 0.1.
        float targetYScale = Mathf.Lerp(0.01f, 1.0f, (normalizedRotation * 1.5f));

        // Apply the calculated rotation and scale to the target object.
        //targetObject.localRotation = Quaternion.Euler(0, 0, targetZRotation);
        targetObject.localScale = new Vector3(targetObject.localScale.x, targetYScale, targetObject.localScale.z);
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
            float dragDistance = (currentMousePosition.x - initialMousePosition.x) * sensitivity;
            float previousRotation = currentRotation;//////////////
            // Update the current rotation based on the drag distance.
            currentRotation = Mathf.Clamp(currentRotation + dragDistance, 0.0f, maxRotation);

            // Apply the rotation to the book hinge.
            bookLeftHinge.localRotation = Quaternion.Euler(0, 0, currentRotation);

            // Update the initial mouse position for smooth dragging.
            initialMousePosition = currentMousePosition;

            bool isIncreasing = currentRotation > previousRotation;////////////
            currentRotation = Mathf.Repeat(currentRotation + dragDistance, 360f);
            currentRotation = Mathf.Clamp(currentRotation, 0.0f, maxRotation);

            if (currentRotation > 120 && isIncreasing)
            {
                //launch ship
                starship.Translate(Vector3.up * Time.deltaTime);
            }
            else if (currentRotation > 120 && !isIncreasing)
            {
                //retrieve ship
                starship.Translate(Vector3.down * Time.deltaTime);
            }
        }
    }
}
