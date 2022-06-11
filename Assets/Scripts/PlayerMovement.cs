using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] [Range(1f, 25f)] float speed = 10f;

    float horizontalSpeed = 0f;
    float verticalSpeed = 0f;

    public void HandleMovement()
    {        
        horizontalSpeed = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        verticalSpeed = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
        transform.Translate(horizontalSpeed, verticalSpeed, 0, Space.World);
    }
}
