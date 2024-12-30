using UnityEngine;

public class TypeCastingTest : MonoBehaviour
{
    void Start()
    {
        Cat myCat = new Cat();

        Animal animal = myCat;

        animal.MakeSound();
        animal.Move();

        Cat downcastedCat = animal as Cat;

        downcastedCat.MakeSound();
        downcastedCat.Move();
    }
}