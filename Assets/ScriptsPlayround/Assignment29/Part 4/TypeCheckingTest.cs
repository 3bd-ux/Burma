using System.Collections.Generic;
using UnityEngine;

public class TypeCheckingTest : MonoBehaviour
{
    List<ICanFight> fighters = new List<ICanFight> { new Cat(), new Warrior() };
    void Start()
    {
        foreach (ICanFight fighter in fighters)
        {
            fighter.Attack();
        }
        foreach (ICanFight fighter in fighters)
        {
            if (fighter is Cat) Debug.Log("The Object is a cat!");
            else if (fighter is Warrior) Debug.Log("The Object is a Warriror!");
        }
    }
}
