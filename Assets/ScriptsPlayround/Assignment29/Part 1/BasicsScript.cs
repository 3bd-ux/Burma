using System;
using UnityEngine;

public class BasicsScript : MonoBehaviour
{
    DateTime currentDate = DateTime.Now;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var num = 1;
        var name = "Sob7i";
        var flag = true;
        Debug.Log($"The variable ({nameof(num)}) is of type: {num.GetType()}");
        Debug.Log($"The variable ({nameof(name)}) is of type: {name.GetType()}");
        Debug.Log($"The variable ({nameof(flag)}) is of type: {flag.GetType()}");

        Debug.Log(OddOrEven(num));

        Debug.Log($"The current Date is: {currentDate.ToString("yyyy/MMM/d")}");
        Debug.Log($"The current Time is: {currentDate.ToString("t")}");
        Debug.Log($"The current Day is: {currentDate.ToString("dddd")}");
    }
    private string OddOrEven(int number) => number % 2 == 0 ? $"the number {number} is Even" : $"the number {number} is Odd";
}
