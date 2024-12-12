using UnityEngine;

public class ObjectsController : MonoBehaviour
{
    [SerializeField] private GameObject[] page = new GameObject[3];
    [Range(0f, 1f)][SerializeField] private float[] pagePos = new float[3];
    [SerializeField] AddTorque addTorque;

    [SerializeField] Rigidbody currentRigidbody = null;

    void Update()
    {
        pagePos[0] = addTorque.GetAnimationDriver(page[0]);
        pagePos[1] = addTorque.GetAnimationDriver(page[1]);
        pagePos[2] = addTorque.GetAnimationDriver(page[2]);
    }
}