using UnityEngine;

public class LaunchDirector : MonoBehaviour
{
    //Ready-To-Launch Transforms
    [SerializeField] Transform fullRocketTransform;
    [SerializeField] GameObject fullRocket;
    [SerializeField] Transform Starship;
    [SerializeField] Transform Booster;
    [SerializeField] Transform MechArm;


    void Start()
    {
        //Save the transform at start of game
        fullRocketTransform = fullRocketTransform.transform;
        Starship = Starship.transform;
        Booster = Booster.transform;
        MechArm = MechArm.transform;
        Debug.Log($"For Manual Launch: Press 1!");
        Debug.Log($"For Automatic Launch: Press 2!");
        Debug.Log($"For RUD : Press 3!");
        Debug.Log($"For Banana : Press 4!");
        Debug.Log($"For Buying Dogecoin : Press 5!");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            fullRocket.GetComponent<Rigidbody>();
            //fullRocket.
        }
        if (Input.GetKeyDown(KeyCode.Keypad2)) { }
        if (Input.GetKeyDown(KeyCode.Keypad3)) { }
        if (Input.GetKeyDown(KeyCode.Keypad4)) { }
        if (Input.GetKeyDown(KeyCode.Keypad5)) { }
    }
}
