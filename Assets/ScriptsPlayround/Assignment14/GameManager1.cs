using UnityEngine;

public class GameManager1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player1 Mouse = new("Jerry", 100);
        Enemy Cat = new("Tom", 100000);
        Enemy Human = new("Smi7", -543);

        Debug.Log($"The human is called {Human.CharacterName}, he has {Human.Health} Health.");
        Debug.Log($"The Mouse is called {Mouse.CharacterName}, he has {Mouse.Health} Health.");
        Debug.Log($"The Cat is called {Cat.CharacterName}, he has {Cat.Health} Health.");

        Cat.Attack(Cat.DamageAmount, Mouse);
        Debug.Log($"OH NO! {Cat.CharacterName} scratched {Mouse.CharacterName} dealing {Cat.DamageAmount} damage.");
        Debug.Log($"{Mouse.CharacterName}'s health now is= {Mouse.Health}");

        Debug.Log($"{Mouse.CharacterName} escaped and ate some cheese. He heald by {Mouse.HealAmount}");
        Mouse.EatCheese(Mouse.HealAmount);
        Debug.Log($"{Mouse.CharacterName}'s health now is= {Mouse.Health}");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
