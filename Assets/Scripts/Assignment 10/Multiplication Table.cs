using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{

    [SerializeField] private int number;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //string 
        int temp = 0;
        if (number == 0) number = 5;
        for (int i = 1; i <= 10; i++)
        {
            Debug.Log($"|{Multiplier(number, i)}");
            temp = i;
        }

        // Debug.Log(number + " * " + temp + " = " + Multiplier(number, temp));
        Debug.LogError("Donzos");
    }

    private int Multiplier(int num1, int num2)
    {
        return num1 * num2;
    }


}
