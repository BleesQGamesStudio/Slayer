using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] [Range(1f, 25f)] float speed = 10f;

    public void HandleMovement()
    {
        float horizontalSpeed = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        float verticalSpeed = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
        transform.Translate(horizontalSpeed, verticalSpeed, 0);
    }
}
