using UnityEngine;

public class ArmsRetract : MonoBehaviour
{
    public float startAngle = 7f;
    public float targetAngle = 37f;
    public float duration = 2f;
    private float elapsedTime = 0f;
    private bool rotating = false;

    private void Update()
    {
        if (rotating)
        {
            elapsedTime += Time.deltaTime;

            float t = Mathf.Clamp01(elapsedTime / duration);

            float currentAngle = Mathf.Lerp(startAngle, targetAngle, t);

            transform.rotation = Quaternion.Euler(0f, currentAngle, 0f);

            if (t >= 1f)
            {
                rotating = false;
            }
        }
    }

    public void StartRotation()
    {
        elapsedTime = 0f;
        rotating = true;
    }
    public void ResetRotation()
    {
        transform.rotation = Quaternion.Euler(0f, startAngle, 0f);
    }
}
