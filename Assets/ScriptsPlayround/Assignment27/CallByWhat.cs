using UnityEngine;

public class CallByWhat : MonoBehaviour
{
    void Start()
    {
        int a = 3;
        int b = 5;
        ByValue(a);
        Debug.Log(a);
        ByRef(ref b);
        Debug.Log(b);

        int c;
        ByOut(out c);
        Debug.Log(c);
    }
    void ByValue(int num)
    {
        num += 10;
    }
    void ByRef(ref int num)
    {
        num += 10;
    }
    void ByOut(out int num)
    {
        num = 10;
    }
}
