using UnityEngine;

public class Player
{
    private static int playerCount;
    string playerName;
    int health;
    public void InitializePlayer(string name, int initialHealth)
    {
        playerName = name;
        health = initialHealth;
        playerCount++;
    }

    public void Heal(int amount)
    {
        health += amount;
        Debug.Log(health);
    }

    public void Heal(bool fullRestore)
    {
        if (fullRestore == true)
        {
            health = 100;
        }
        Debug.Log(health);
        fullRestore = false;
    }
    static public void ShowPlayerCount()
    {
        Debug.Log(playerCount);
    }
}
