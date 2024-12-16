using UnityEngine;

public class Duck : Creature, ISwimmable, IRunnable
{
    void IRunnable.Run()
    {
        Debug.Log("Duck runs.");
    }
    void ISwimmable.Swim()
    {
        Debug.Log("Duck swims.");
    }

    public override void Speak()
    {
        Debug.Log("Duck says: Quack!");
    }
}