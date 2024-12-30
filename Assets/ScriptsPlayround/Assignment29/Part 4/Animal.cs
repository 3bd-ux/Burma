using UnityEngine;

public class Animal
{
    public virtual void MakeSound()
    {
        Debug.Log("Animal sound");
    }
    public void Move()
    {
        Debug.Log("Animal moves");
    }
}