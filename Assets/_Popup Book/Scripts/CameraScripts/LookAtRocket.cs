using UnityEngine;

public class LookAtRocket : MonoBehaviour
{
    [SerializeField] private Transform rocket;
    void Update()
    {
        transform.LookAt(rocket);
    }
}
