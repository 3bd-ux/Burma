using UnityEngine;

public class Car : MonoBehaviour
{
    float steerSpeed = 15;
    public Transform wheelFrontRight;
    void Update()
    {
        steerWheels();
    }
    void steerWheels()
    {
        float currentAngleY = wheelFrontRight.localEulerAngles.y;
        Debug.Log(currentAngleY);

        if (currentAngleY >= 300f || currentAngleY <= 60f)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                wheelFrontRight.localEulerAngles += new Vector3(0f, Time.deltaTime * steerSpeed, 0f);
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                wheelFrontRight.localEulerAngles -= new Vector3(0f, Time.deltaTime * steerSpeed, 0f);
            }
        }
    }
}