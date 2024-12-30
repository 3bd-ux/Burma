using UnityEngine;

public class CustomObjectTest : MonoBehaviour
{
    void Start()
    {
        CustomObject obj1 = new CustomObject(5646532, "Sob7i");
        CustomObject obj2 = new CustomObject(5646532, "Sob7i");
        CustomObject obj3 = new CustomObject(3279126, "Wrwr");

        print(obj1.ToString()); // Expected: CustomObject [ID: 1, Name: Object A]
        print(obj2.ToString()); // Expected: CustomObject [ID: 1, Name: Object A]
        print(obj3.ToString()); // Expected: CustomObject [ID: 2, Name: Object B]

        print("obj1 equals? obj2");
        print(obj1 == obj2); //true 

        print("obj1 equals? obj3");
        print(obj1 == obj3); //false

        print("obj1 notEquals? obj2");
        print(obj1 != obj2); //false

        print("obj1 notEquals? obj3");
        print(obj1 != obj3); //true

    }
}
