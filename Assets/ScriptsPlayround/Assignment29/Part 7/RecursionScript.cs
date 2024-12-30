using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RecursionScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PrintFibonacciAndLength(10);
        PrintFibonacciAndLength(30);
    }
    public List<int> FibonacciRecursive(int n)
    {
        List<int> fibonacciSequence = new List<int> { n };

        if (n <= 0) return fibonacciSequence;

        fibonacciSequence.Add(0);

        if (n > 1) fibonacciSequence.Add(1);
        
        int temp = n - 2;
        //fibonacciSequence.Add(Fibonacci(int n));
        temp -= 1;

        //fibonacciSequence.Add(fibonacciSequence[i - 1] + fibonacciSequence[i - 2]);

        return fibonacciSequence;
    }
    void Fibonacci(int n)
    {

    }

    void PrintFibonacciAndLength(int n)
    {
        string fibonacciSequenceString = string.Join(", ", FibonacciRecursive(n));

        print($"Fibonacci Sequence({n}): {fibonacciSequenceString}");
    }

}
