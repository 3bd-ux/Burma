using UnityEngine;

public class AudioController : MonoBehaviour
{//GPT's
    private AudioSource audioSource;

    private void Start()
    {
        // Get the AudioSource component attached to this GameObject (e.g., the Camera)
        audioSource = GetComponent<AudioSource>();
    }

    // Method to play the audio
    public void PlayAudio()
    {
        if (audioSource != null && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    // Method to stop the audio
    public void StopAudio()
    {
        if (audioSource != null && audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }
}
