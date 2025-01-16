using UnityEngine;
namespace Assignment35
{
    public class BoxingUnboxing : MonoBehaviour
    {
        int length = 4;
        void Start()
        {
            Debug.Log("normal int= " + length);
            object boxedInt = length;
            Debug.Log("boxed int= " + boxedInt);
            length = (int)boxedInt + 3;
            Debug.Log("unboxed int= " + length);
        }
    }
}