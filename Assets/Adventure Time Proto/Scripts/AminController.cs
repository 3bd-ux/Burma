using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform player;
    public float speed = 0.01f;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            player.Translate(Vector3.right * speed, Space.Self);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            player.Translate(Vector3.left * speed, Space.Self);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            player.Translate(Vector3.forward * speed, Space.Self);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            player.Translate(Vector3.back * speed, Space.Self);
        }

    }
}