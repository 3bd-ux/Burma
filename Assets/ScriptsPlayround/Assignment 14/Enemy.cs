using UnityEngine;
using Assignment16;
public class Enemy : Character
{
    public Enemy(string characterName, int characterHealth) : base(characterName, characterHealth)
    {
        Debug.Log($"Creating player: {characterName}, Health= {characterHealth}.");
    }

    int _damageAmount = 30;
    public int DamageAmount
    {
        //set { Amount = amount; }
        get { return _damageAmount; }
    }
    public void Attack(int amount, Player1 player1)
    {
        Debug.Log($"*{this.CharacterName} dealt {this.DamageAmount} damage to the mouse!*");
        player1.Health -= amount;
    }

}