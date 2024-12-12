using UnityEngine;
using Assignment24;
public class RacingGame : MonoBehaviour
{
    [SerializeField] private RaceState raceState;
    private RaceState previousRaceState;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        previousRaceState = raceState;
        SimulateRace();
    }

    // Update is called once per frame
    void Update()
    {
        if (raceState != previousRaceState)
        {
            SimulateRace();
            previousRaceState = raceState; 
        }
    }
    private void SimulateRace()
    {
        switch (raceState)
        {
            case RaceState.Start:
                Debug.Log("The engines roar to life. Get set for an epic race!");
                for (int i = 5; i > 0; i--)
                {
                    Debug.Log("Countdown: " + i);
                }
                Debug.Log("Blast off!");
                break;

            case RaceState.Accelerate:
                Debug.Log("You push the pedal to the metal. The car surges forward!");
                Debug.Log("Speedometer: 100 km/h... 150 km/h... 200 km/h!");
                break;

            case RaceState.Turn:
                Debug.Log("You encounter a tricky curve. Precision is key here!");
                Debug.Log("You skillfully steer through the turn. Smooth handling!");
                break;

            case RaceState.Crash:
                Debug.Log("Oh no! You lose control and hit the guardrail.");
                Debug.Log("Smoke rises from the hood. Hard Luck!");
                break;

            case RaceState.Finish:
                Debug.Log("The crowd goes wild as you approach the finish line!");
                Debug.Log("Victory! You’ve claimed the gold medal!");
                break;

            default:
                Debug.Log("Warning: The race is in an unknown state. Check your systems!");
                break;
        }

    }
}
