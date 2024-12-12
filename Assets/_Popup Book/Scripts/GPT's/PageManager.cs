using UnityEngine;
using System.Collections.Generic;

public class PageManager : MonoBehaviour
{
    [Header("Page Stacks")]
    [SerializeField] private List<GameObject> leftPages = new List<GameObject>();
    [SerializeField] private List<GameObject> rightPages = new List<GameObject>();

    private GameObject activePage = null;

    public bool CanRotate(GameObject page)
    {
        if (IsTopPage(page))
        {
            return IsOtherSideInCorrectState(page);
        }
        return false;
    }

    private bool IsTopPage(GameObject page)
    {
        if (leftPages.Contains(page))
        {
            return leftPages[leftPages.Count - 1] == page;
        }
        else if (rightPages.Contains(page))
        {
            return rightPages[rightPages.Count - 1] == page;
        }
        return false;
    }

    private bool IsOtherSideInCorrectState(GameObject page)
    {
        List<GameObject> otherStack = leftPages.Contains(page) ? rightPages : leftPages;

        if (otherStack.Count > 0)
        {
            PageController topPageController = otherStack[otherStack.Count - 1].GetComponent<PageController>();
            return topPageController != null && topPageController.IsFullyOpenOrClosed();
        }
        return true; // No pages on the other side
    }

    public void SetActivePage(GameObject page)
    {
        activePage = page;
    }

    public GameObject GetActivePage()
    {
        return activePage;
    }

    public void ClearActivePage()
    {
        activePage = null;
    }
}
