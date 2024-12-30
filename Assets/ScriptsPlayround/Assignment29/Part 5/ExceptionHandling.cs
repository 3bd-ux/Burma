using System;
using UnityEngine;

public class ExceptionHandling : MonoBehaviour
{
    int playerScore = 100;
    int diviser = 0;
    void Start()
    {
        try
        {
            Debug.Log("Attempting to calculate score multiplier...");
            int totalScore = playerScore / diviser;
        }
        catch (Exception error)
        {
            Debug.LogError("Error: Division by zero occurred while calculating score multiplier.");
            Debug.LogError(error.Message);
        }
        finally
        {
            Debug.Log("Score calculation complete. Clearing up resources");
        }

    }
}