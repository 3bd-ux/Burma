using UnityEngine;

public class Excercise3 : MonoBehaviour
{

    [SerializeField] private int playerLives = 3;
    [SerializeField] private float roundTimer = 0f;
    [SerializeField] private float roundTimerMax = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() 
    {
        Round();
    }

    // Update is called once per frame
    void Update()
    {
        roundTimer += Time.deltaTime;
        while (roundTimer > roundTimerMax && IsAlive())
        {
            roundTimer = 0f;
            playerLives--;
            Round();
        }
    }

    private void Round()
    {
        if (playerLives > 1)
        {
            Debug.Log("Many lives!");
        }
        else if (playerLives == 1)
        {
            Debug.Log("The last life!");
        }
        else
        {
            Debug.LogError("Game Over!");
        }
    }

    public bool IsAlive()
    {
        return playerLives > 0;
    }
}
