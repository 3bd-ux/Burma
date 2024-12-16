using UnityEngine;

public class TreeShake : MonoBehaviour
{
    [SerializeField] private GameObject vfx;
    public float shakeIntensity = 2f; // How much it shakes
    public float shakeSpeed = 30f;     // How fast it shakes

    private Quaternion originalRotation;

    // Bool to control shaking from another script
    public bool isShaking = false;

    void Start()
    {
        // Store the original rotation
        originalRotation = transform.rotation;
    }

    void Update()
    {
        if (vfx.transform.position.y - transform.position.y < 20f && vfx.activeSelf)
        {
            isShaking = true;
        }
        else
        {
            isShaking = false;
        }
        // Keep shaking if the bool is true
        if (isShaking)
        {
            ShakeTree();
        }
        else
        {
            // Reset rotation when not shaking
            transform.rotation = originalRotation;
        }
    }

    private void ShakeTree()
    {
        // Create oscillating shake rotation
        float shakeX = Mathf.Sin(Time.time * shakeSpeed) * shakeIntensity;
        float shakeZ = Mathf.Cos(Time.time * shakeSpeed) * shakeIntensity;

        transform.rotation = originalRotation * Quaternion.Euler(shakeX, 0, shakeZ);
    }
}
