using System;
using UnityEngine;
namespace Assignment35
{
    public class BuiltInDelegatesExample : MonoBehaviour
    {
        private Action<string> logMessage;
        private Func<int, int> square;
        private Predicate<int> isEven;
        void Start()
        {
            logMessage = (string message) => { Debug.Log(message); };
            square = (int num) => { return num * num; };
            isEven = (int num) => { return num % 2 == 0; };

            logMessage("Hello from Action delegate!");
            Debug.Log($"Square: {square(5)}");
            Debug.Log($"Is 4 even? {isEven(4)}");
        }
    }
}