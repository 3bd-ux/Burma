using UnityEngine;

public class StreamDirector : MonoBehaviour
{
    public Camera[] cameras;
    private int currentCameraIndex = 0;

    void Start()
    {
        foreach (Camera cam in cameras)
        {
            cam.gameObject.SetActive(false);
        }
        cameras[0].gameObject.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            SwitchCamera();
        }
    }

    void SwitchCamera()
    {
        cameras[currentCameraIndex].gameObject.SetActive(false);
        currentCameraIndex = (currentCameraIndex + 1) % cameras.Length;
        cameras[currentCameraIndex].gameObject.SetActive(true);
    }
}