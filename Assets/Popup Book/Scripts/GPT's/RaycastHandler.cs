using UnityEngine;

public class RaycastHandler : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private LayerMask pageLayer;
    [SerializeField] private PageManager pageManager;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            HandleMouseClick();
        }

        if (Input.GetMouseButton(0))
        {
            HandleMouseDrag();
        }

        if (Input.GetMouseButtonUp(0))
        {
            HandleMouseRelease();
        }
    }

    private void HandleMouseClick()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity, pageLayer))
        {
            GameObject hitPage = hit.collider.gameObject;

            if (pageManager.CanRotate(hitPage))
            {
                pageManager.SetActivePage(hitPage);
            }
        }
    }

    private void HandleMouseDrag()
    {
        GameObject activePage = pageManager.GetActivePage();
        if (activePage != null)
        {
            float xAxis = Input.GetAxis("Mouse X");
            PageController controller = activePage.GetComponent<PageController>();
            controller.RotatePage(xAxis);
        }
    }

    private void HandleMouseRelease()
    {
        pageManager.ClearActivePage();
    }
}
