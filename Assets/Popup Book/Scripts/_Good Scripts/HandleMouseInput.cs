using Unity.VisualScripting;
using UnityEngine;

public class HandleMouseInput : MonoBehaviour
{

    [SerializeField] private bool isDragging;
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private Camera mainCamera;
    private GameObject page;
    private float raycastX;
    void Start()
    {

    }

    void Update()
    {
        raycastX = GetHorizontalMousePositition();
        Debug.Log(raycastX);
        if (raycastX < 0)
        {
            //if (bookManager.rightStack.peek() != null)
            {
                //grab the left
            }
            //control left side
            Debug.Log("left");
        }
        else if (raycastX > 0)
        {
            //control right side
            Debug.Log("right");
        }

        if (Input.GetMouseButtonDown(1)/*delete is dragging*/ &&isDragging)
        {
            isDragging = true;

        }
    }

    private float GetHorizontalMousePositition()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit raycastHit, float.MaxValue, layerMask))
        {
            //page = raycastHit.transform.parent.gameObject;

            return raycastHit.point.x;

        }
        else return 0;
    }
}
