using Unity.Mathematics.Geometry;
using UnityEngine;

public class OscillateScale : MonoBehaviour
{
    public float oscillationSpeed = 5f;
    public float amplitude = 0.5f;
    private Vector3 originalScale;
    private void Start()
    {
        originalScale = transform.localScale;
    }
    private void Update()
    {
        //ChatGPT's code:-

        // Calculate the new scale on the Y-axis using a sine wave
        float newYScale = originalScale.y + Mathf.Sin(Time.deltaTime * oscillationSpeed) * amplitude;
        // Apply the new scale to the object
        transform.localScale = new Vector3(originalScale.x, newYScale, originalScale.z);
    }
}
