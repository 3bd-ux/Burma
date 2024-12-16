using System.Collections.Generic;
using UnityEngine;

public class CreatureManager : MonoBehaviour
{
    void Start()
    {
        List<Creature> creatures = new List<Creature>();

        Kangaroo kangaroo = new Kangaroo();
        Duck duck = new Duck();

        creatures.Add(kangaroo);
        creatures.Add(duck);

        List<IRunnable> runners = new List<IRunnable>();
        List<IJumpable> jumpers = new List<IJumpable>();
        List<ISwimmable> swimers = new List<ISwimmable>();


        runners.Add(kangaroo);
        jumpers.Add(kangaroo);

        runners.Add(duck);
        swimers.Add(duck);

        foreach (Creature creature in creatures)
        {
            creature.Speak();
        }
        foreach (IRunnable runner in runners)
        {
            runner.Run();
        }
        foreach (IJumpable jumper in jumpers)
        {
            jumper.Jump();
        }
        foreach (ISwimmable swimer in swimers)
        {
            swimer.Swim();
        }

    }
}
