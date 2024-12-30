using UnityEngine;

public class UnitySpecificScript : MonoBehaviour
{
    void OnDisable()
    {
        print($"{gameObject.name} deactivated!");
    }
    void OnEnable()
    {
        print("GameObject Enabled");
    }

    void Start()
    {
        print("Game started!");

        //find by name
        GameObject targetObject = GameObject.Find("TargetObject");
        if (targetObject != null)
        {
            Debug.Log("Found object by name: " + targetObject.name);
        }
        else
        {
            Debug.Log("No TargetObject found.");
        }

        //find by tag
        GameObject jokerObject = GameObject.FindWithTag("Joker");
        if (jokerObject != null)
        {
            Debug.Log("Found object by tag: " + jokerObject.name);
        }
        else
        {
            Debug.Log("No Joker object found");
        }

        //find by type
        Light lightObject = GameObject.FindAnyObjectByType<Light>();
        if (lightObject != null)
        {
            Debug.Log("Found object of type Light: " + lightObject.name);
        }
        else
        {
            Debug.Log("No Light object found.");
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {            
            gameObject.SetActive(false);
        }
    }
}