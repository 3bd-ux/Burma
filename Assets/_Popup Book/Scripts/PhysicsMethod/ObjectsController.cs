using UnityEngine;

public class ObjectsController : MonoBehaviour
{
    [SerializeField] private GameObject[] page = new GameObject[3];
    [Range(0f, 1f)][SerializeField] public float[] pagePos = new float[3];
    [Range(0f, 1f)][SerializeField] private float[] tempPagePos = new float[3];
    [SerializeField] AddTorque addTorque;
    //[SerializeField] Rigidbody currentRigidbody = null;
    [SerializeField] bool flag = true;
    void Update()
    {
        if (flag) pagePos[0] = addTorque.GetAnimationDriver(page[0]);
        pagePos[1] = addTorque.GetAnimationDriver(page[1]);
        pagePos[2] = addTorque.GetAnimationDriver(page[2]);

        AR(1, ref pagePos); // there's no need for flag if this overrides addTorque.GetAnimationDriver()

    }

    public void AR(int index, ref float[] driver)
    {
        int previous = index - 1;
        float decrementValue = driver[index];
        if (previous >= 0)
        {
            driver[previous] -= decrementValue;
        }
    }
}