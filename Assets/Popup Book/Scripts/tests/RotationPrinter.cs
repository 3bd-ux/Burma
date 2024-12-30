using UnityEngine;

public class RotationPrinter : MonoBehaviour
{
    void Update()
    {
        // Get the object's rotation as a Quaternion
        Quaternion objectRotation = transform.rotation;

        // Extract the Z rotation from the Quaternion
        float zRotationQuaternion = objectRotation.eulerAngles.z;

        // Print the Z rotation in Quaternion form (as the full Quaternion)
        //    Debug.Log("Rotation in Quaternion: " + objectRotation);

        // Print the Z rotation in Euler form (only the Z component)
        Debug.Log("Rotation in Euler Angles (Z): " + zRotationQuaternion);
    }
}
