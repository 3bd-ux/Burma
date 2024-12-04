using UnityEngine;

public class RocketLaunch : MonoBehaviour
{

    [SerializeField] AudioController audioController; // Audio Script ref
    [SerializeField] GameObject LaunchVFX; // VFX GameObjects group
    [SerializeField] GameObject rocket; // za BFR
    [SerializeField] float countdown = 10f;
    [SerializeField] float baseAcceleration = 0.1f;
    [SerializeField] float maxSpeed = 300f; // not used 
    [SerializeField] float maxAltitude = 3000f;
    [SerializeField] float delayBeforeLiftOff = 3f;
    [SerializeField] bool isLaunching = false;

    // no tochies
    [SerializeField] private float currentSpeed = 0f;
    [SerializeField] private float acceleration = 0f;
    [SerializeField] private float liftoffTimer = 0f;

    void Update()
    {
        // begin countdown on click
        if (Input.GetKeyDown(KeyCode.Space) && !isLaunching)
        {
            isLaunching = true;
            audioController.PlayAudio();
        }

        if (isLaunching && countdown > 0)
        {
            countdown -= Time.deltaTime;
            Debug.Log(Mathf.Ceil(countdown));

            if (countdown <= 0)
            {
                Debug.Log("LIFTOFF!");
                liftoffTimer = delayBeforeLiftOff;

                LaunchVFX.SetActive(true);
            }
        }

        if (countdown <= 0 && liftoffTimer > 0)
        {
            liftoffTimer -= Time.deltaTime;
        }

        if (countdown <= 0 && liftoffTimer <= 0 && rocket.transform.position.y < maxAltitude)
        {
            if (currentSpeed < maxSpeed)
            {
                acceleration += baseAcceleration * Time.deltaTime;
                currentSpeed += acceleration * Time.deltaTime;
            }
            else
            {
                acceleration = 0;
            }

            rocket.transform.position += new Vector3(0, currentSpeed * Time.deltaTime, currentSpeed * Time.deltaTime * 0.1f);
        }
    }
}
