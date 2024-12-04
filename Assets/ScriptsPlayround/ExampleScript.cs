using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int numberOfSmiles = 1;
        int numberOfSmilesMultiplier = 10;
        string teacherCompliment = "You are a fantastic teacher, just thought you should know!";

        // Performing an arithmetic operation
        int bonusSmiles = numberOfSmiles * numberOfSmilesMultiplier;

        Debug.Log("Why do game developers prefer dark mode? Because the light attracts bugs!");
        Debug.Log(teacherCompliment);
        Debug.LogWarning("Warning: The compliment above may cause slight blushing. Proceed with caution.");
        Debug.Log("You’ve earned: " + bonusSmiles + " bonus smiles today! Keep up the great work!");
        Debug.LogError("Error: Smile detected! Debugging happiness now.");

    }
}