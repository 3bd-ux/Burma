using UnityEngine;

public class Cat : Animal, ICanFight
{
    public override void MakeSound()
    {
        Debug.Log("Meow!");
    }
    public new void Move()
    {
        Debug.Log("Cat runs quickly");
    }
    public void Attack()
    {
        Debug.Log("Cat swings claws!");
    }
}