using UnityEngine;

public class Player1 : Character
{
    public Player1(string characterName, int characterHealth) : base(characterName, characterHealth)
    {
        Debug.Log($"Creating player: {characterName}, Health= {characterHealth}.");
    }
    int _healAmount = 50;
    public int HealAmount
    {
        set { HealAmount = _healAmount; }
        get { return _healAmount; }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void EatCheese(int healAmount)
    {
        Debug.Log($"+{healAmount} heal");
        Health += healAmount;
    }

}
