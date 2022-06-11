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
        horizontalSpeed = Input.GetAxisRaw("Horizontal");
        verticalSpeed = Input.GetAxisRaw("Vertical");

        Vector2 direction = new Vector2(horizontalSpeed, verticalSpeed);
        direction.Normalize();
        direction *= speed * Time.deltaTime;

        transform.Translate(direction, Space.World);
    }
}
