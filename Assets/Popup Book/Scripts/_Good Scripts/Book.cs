using System.Collections.Generic; // Needed for Stack
using System.Linq;
using UnityEngine;

public class Book
{
    [SerializeField] private List<Transform> rightPages; //>>
    private Stack<Transform> rightStack; //>>
    private Stack<Transform> rightHinges; //>>
    private Stack<Transform> leftStack; //<<
    private Stack<Transform> leftHinges; //<<
    private Transform heldPage; //<<


    public Book()
    {
        rightStack = new Stack<Transform>();
        rightHinges = new Stack<Transform>();
        leftStack = new Stack<Transform>();
        leftHinges = new Stack<Transform>();

        foreach (var page in rightPages)
        {
            rightStack.Push(page);
        }
        foreach (var hinge in rightStack)
        {
            rightHinges.Push(hinge);
        }
        foreach (var hinge in leftStack)
        {
            leftHinges.Push(hinge);
        }
    }

    // private void Update()
    // {
    //     // Example: Press "Space" to move an element from rightStack to leftStack
    //     if (Input.GetKeyDown(KeyCode.Space) && rightStack.Count > 0)
    //     {
    //         leftStack.Push(rightStack.Pop());
    //         Debug.Log("Moved " + leftStack.Peek() + " from right stack to left stack.");
    //     }
    //     if (Input.GetKeyDown(KeyCode.CapsLock))
    //     {Vector3(2.45000005,0.000500000082,0)
    //         List<Transform> stackCopy = leftStack.ToList();
    //         foreach (Transform item in stackCopy)
    //         {
    //             Debug.Log("Item in stack: " + item.name);
    //         }
    //     }

    // }
    public Transform holdPage(Stack<Transform> stack)
    {
        heldPage = stack.Pop();
        Debug.Log($"Grapped {heldPage}");
        return heldPage;
    }
    public void releasePage(Transform page, Stack<Transform> stack)
    {
        Debug.Log($"released {page}");
        stack.Push(page);
    }
}
