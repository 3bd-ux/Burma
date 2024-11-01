using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{

    [SerializeField] private int number;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string RESULT = null;

        if (number == 0) number = 5;

        for (int i = 1; i <= 10; i++)
        {
            RESULT += i + " X " + number + " = " + (Multiply(i, number));
            Debug.Log(Multiply(i, number));
            if(i==10)continue;
            RESULT +=",   ";
        }
        Debug.Log(RESULT);
        Debug.LogError("Donzos");

        // Debug.Log($"|{Multiply(number, i)}");
        // Debug.Log(number + " * " + temp + " = " + Multiplier(number, temp));
    }

    private int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }


}
