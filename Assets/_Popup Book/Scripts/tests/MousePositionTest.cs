using UnityEngine;

public class MousePositionTest : MonoBehaviour
{
//     [SerializeField] private LayerMask layerMask; // To detect pages
//     [SerializeField] private Camera mainCamera;
//     [SerializeField] private PageManager pageManager; // Reference to PageManager
//     private Page currentPage = null;
//     private bool isDragging = false;
//     private Vector3 initialMousePosition;
//     private float currentRotation = 0.0f;

//     void Update()
//     {
//         if (Input.GetMouseButtonDown(0))
//         {
//             // Cast a ray and check for the topmost page
//             currentPage = GetTopPage();
//             if (currentPage != null && CanInteractWithPage(currentPage))
//             {
//                 isDragging = true;
//                 initialMousePosition = Input.mousePosition;
//             }
//         }

//         if (Input.GetMouseButton(0) && isDragging)
//         {
//             RotatePage(currentPage.Parent);
//         }

//         if (Input.GetMouseButtonUp(0))
//         {
//             isDragging = false;
//             currentPage = null;
//         }
//     }

//     private Page GetTopPage()
//     {
//         Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
//         if (Physics.Raycast(ray, out RaycastHit hit, float.MaxValue, layerMask))
//         {
//             GameObject hitObject = hit.transform.gameObject;
//             return pageManager.GetPageFromParent(hitObject);
//         }
//         return null;
//     }

//     private bool CanInteractWithPage(Page page)
//     {
//         // Check if the page is the topmost and adjacent pages are at valid states
//         return pageManager.IsTopPage(page) && pageManager.AreAdjacentPagesValid(page);
//     }

//     private void RotatePage(GameObject hinge)
//     {
//         Vector3 currentMousePosition = Input.mousePosition;
//         float dragDistance = (currentMousePosition.x - initialMousePosition.x);
//         currentRotation = Mathf.Clamp(currentRotation + dragDistance, 0.0f, 180f);

//         hinge.transform.localRotation = Quaternion.Euler(0, 0, currentRotation);
//         initialMousePosition = currentMousePosition;
//     }
}
