using UnityEngine;
namespace Assignment35
{
    public class MulticastDelegateExample : MonoBehaviour
    {
        delegate void MathOperation(int number);

        void DoubleNumber(int number)
        {
            number *= 2;
            Debug.Log("Double: " + number);
        }

        void SquareNumber(int number)
        {
            number *= number;
            Debug.Log("Square: " + number);
        }


        void CubeNumber(int number)
        {
            number *= number * number;
            Debug.Log("Cube: " + number);
        }

        void Start()
        {
            MathOperation operation = null;
            operation += DoubleNumber;
            operation += SquareNumber;
            operation += CubeNumber;

            operation(5);
        }
    }
}