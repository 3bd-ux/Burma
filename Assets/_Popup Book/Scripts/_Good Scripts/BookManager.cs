using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class BookManager : MonoBehaviour
{
    private Stack<GameObject> rightStack; //>>
    private Stack<GameObject> leftStack; //<<
    private List<GameObject> temp; //<<

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rightStack = new Stack<GameObject>();
        leftStack = new Stack<GameObject>();

        foreach (Transform child in transform)
        {
            rightStack.Push(child.gameObject);
        }
        temp = new List<GameObject>(rightStack);

        foreach (var item in temp)
        {
            Debug.Log(item.name);
        }
        Debug.Log(rightStack.Peek());
    }
}
