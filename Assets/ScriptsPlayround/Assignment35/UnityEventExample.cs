using UnityEngine;
using UnityEngine.Events;
namespace Assignment35
{
    public class UnityEventExample : MonoBehaviour
    {
        UnityEvent onEventTriggered;
        void Start()
        {
            onEventTriggered = new UnityEvent();
            onEventTriggered.AddListener(OnEventResponse);
        }

        void OnEventResponse()
        {
            Debug.Log("The event has been triggered!");
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space)) onEventTriggered?.Invoke();
        }
    }
}