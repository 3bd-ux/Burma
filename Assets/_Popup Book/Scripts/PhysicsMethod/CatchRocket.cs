using UnityEngine;

public class CatchRocket : MonoBehaviour
{
    [SerializeField] private GameObject vfx;
    [SerializeField] private GameObject starship;
    [SerializeField] private Transform newParent;
    [SerializeField] private Transform rocket;
    [SerializeField] private float altitude;
    [SerializeField] private Transform landingSpot;
    [SerializeField] private bool landingSequence;
    [SerializeField] private float timer;

    void Update()
    {
        altitude = rocket.transform.position.y;
        if (altitude > 200 && !landingSequence)
        {
            rocket.gameObject.SetActive(false);
            rocket.transform.SetParent(null);
        }
        if (Input.GetKeyDown(KeyCode.KeypadEnter) && !landingSequence)
        {
            // Initiate landing Sequence
            rocket.gameObject.SetActive(true);

            landingSequence = true;
            rocket.GetComponent<RocketLaunch>().enabled = false;
            starship.gameObject.SetActive(false);
        }
        Land();
    }
    private void Land()
    {
        if (landingSequence)
        {
            rocket.transform.SetParent(null);
            float distanceToLandingSpot = Vector3.Distance(rocket.transform.position, landingSpot.position);
            float speed = 25;

            if (distanceToLandingSpot < 20f)
            {
                speed = Mathf.Lerp(0.5f, 25f, distanceToLandingSpot / 20f);
                if (!vfx.activeSelf)
                {
                    vfx.SetActive(true);
                }
            }
            rocket.transform.position = Vector3.MoveTowards(rocket.transform.position, landingSpot.position, speed * Time.deltaTime);


            if (distanceToLandingSpot < 0.01f)
            {
                rocket.transform.SetParent(newParent);
                Debug.Log("Rocket has Landed!");
                landingSequence = false;
                vfx.SetActive(false);
            }
        }
    }

}
