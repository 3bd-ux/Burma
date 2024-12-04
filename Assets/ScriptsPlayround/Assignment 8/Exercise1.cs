using UnityEngine;

public class Exercise1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int randomNumber;
        while (true)
        {
            randomNumber = Random.Range(1, 20);
            if (randomNumber == 5)
            {
                Debug.Log("Found (5)!, Skipping..");
                continue;
            }
            else if (randomNumber == 15)
            {
                Debug.Log("Found (15)!, Exiting loop..");
                break;
            }
            else
            {
                Debug.Log(randomNumber);
            }
        }
    }
}