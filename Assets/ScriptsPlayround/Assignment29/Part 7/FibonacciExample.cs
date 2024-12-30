using UnityEngine;

public class FibonacciExample : MonoBehaviour
{
    void Start()
    {
        print($"Fibonacci of 10  is: {Fibonacci(10)}");
        print($"Fibonacci of 10  is: {Fibonacci(30)}");
        PrintFibonacci(10);
        PrintFibonacci(30);
    }

    // Recursive Fibonacci method
    int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
    void PrintFibonacci(int n)
    {
        for (int i = 0; i <= n; i++)
        {
            Debug.Log("Fibonacci of " + i + " is: " + Fibonacci(i));
        }
    }

}
