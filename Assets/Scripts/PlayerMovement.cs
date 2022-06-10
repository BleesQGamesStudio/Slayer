using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] [Range(1f, 25f)] float speed = 10f;
    [SerializeField] SpriteRenderer myPlayerSprite;

    bool isFacingRight = true;
    float horizontalSpeed = 0f;
    float verticalSpeed = 0f;

    public void HandleMovement()
    {        
        horizontalSpeed = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        verticalSpeed = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;

        if (horizontalSpeed > 0) isFacingRight = true;
        else if (horizontalSpeed < 0) isFacingRight = false;

        transform.Translate(horizontalSpeed, verticalSpeed, 0);
    }

    public void HandleFlipping()
    {
        if (isFacingRight)
        {
            myPlayerSprite.flipX = false;
        }
        else
        {
            myPlayerSprite.flipX = true;
        }
    }
}
