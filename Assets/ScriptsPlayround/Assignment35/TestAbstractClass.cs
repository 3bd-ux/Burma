using UnityEngine;
using Assignment35;

public class TestAbstractClass : MonoBehaviour
{
    void Start()
    {
        DerivedClassExample test = new DerivedClassExample();
        test.PerformAction();
        test.PrintInfo();
    }
}