using UnityEngine;

public class Kangaroo : Creature, IRunnable, IJumpable
{
    void IRunnable.Run()
    {
        Debug.Log("Kangaroo runs.");
    }
    void IJumpable.Jump()
    {
        Debug.Log("Kangaroo jumps.");
    }
    public override void Speak()
    {
        Debug.Log("Kangaroo says: Hop!");
    }
}