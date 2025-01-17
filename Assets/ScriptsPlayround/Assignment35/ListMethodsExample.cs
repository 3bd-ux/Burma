using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{
    public class ListMethodsExample : MonoBehaviour
    {
        List<int> numbers = new() { 9, 5, 4, 3, 1, 1 };
        List<int> numbers1 = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6 };
        void Start()
        {
            numbers.Sort((x, y) => y.CompareTo(x));
            Debug.Log(string.Join(", ", numbers));

            List<int> filteredNumbers = numbers1.FindAll((x) => x % 2 == 0);
            Debug.Log(string.Join(", ", filteredNumbers));
        }
        void Update()
        {

        }
    }
}