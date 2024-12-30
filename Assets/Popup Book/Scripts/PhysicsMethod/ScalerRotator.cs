using UnityEngine;

public class ScalerRotator : MonoBehaviour
{
    [SerializeField] ObjectsController objectsController;
    [Range(0f, 1f)][SerializeField] public float[] pagePos = new float[3];
    [SerializeField] private Transform[] scaler = new Transform[3];
    [SerializeField] private Transform[] Rotator = new Transform[3];

    void Update()
    {
        pagePos[0] = objectsController.pagePos[0];
        pagePos[1] = objectsController.pagePos[1];
        pagePos[2] = objectsController.pagePos[2];
        ToggleObject(scaler, pagePos, 0);
        ToggleObject(scaler, pagePos, 1);
        Squish(scaler, pagePos, 0);
        Squish(scaler, pagePos, 1);
        RotateZ(Rotator, pagePos, 0);
        RotateZ(Rotator, pagePos, 1);
    }

    private void ToggleObject(Transform[] transformArray, float[] positionsArray, int i)
    {
        if (positionsArray[i] > 0 && !transformArray[i].gameObject.activeSelf)
        {
            //enable group of objects
            transformArray[i].gameObject.SetActive(true);
        }
        else if (positionsArray[i] == 0 && transformArray[i].gameObject.activeSelf)
        {
            //enable group of objects
            transformArray[i].gameObject.SetActive(false);
        }
    }
    private void Squish(Transform[] transformArray, float[] positionsArray, int index)
    {
        if (transformArray[index].gameObject.activeSelf)
        {
            transformArray[index].localScale = new Vector3(
            transformArray[index].localScale.x
            , positionsArray[index]
            , transformArray[index].localScale.z
            );
        }
    }
    private void RotateZ(Transform[] transformArray, float[] positionsArray, int index)
    {
        if (transformArray[index].gameObject.activeSelf)
        {
            // Calculate the Z rotation angle (0 to 45 degrees based on positionsArray[0])
            float zRotation = Mathf.Lerp(-45f, 0f, positionsArray[index]);

            // Apply the rotation to the transform
            transformArray[index].localRotation = Quaternion.Euler(
                transformArray[index].localRotation.eulerAngles.x,
                 transformArray[index].localRotation.eulerAngles.y
                 , zRotation);
        }
    }

}
