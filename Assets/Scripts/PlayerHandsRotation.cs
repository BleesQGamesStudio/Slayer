using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandsRotation : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 100f;
    [SerializeField] GameObject myHands = null;
    [SerializeField] GameObject myRotatePoint = null;

    Camera myCamera = null;

    private void Awake()
    {
        myCamera = Camera.main;
    }

    public void HandleRotating(bool isFacingRight)
    {
        Vector2 mousePosition = Input.mousePosition;
        Vector2 worldPosition = myCamera.ScreenToWorldPoint(mousePosition);
        Vector2 offset = new Vector2(worldPosition.x - transform.position.x, worldPosition.y - transform.position.y);
        
        if (isFacingRight)
        {
            myRotatePoint.transform.right = Vector2.MoveTowards(transform.up, offset, rotationSpeed);
        }
        else
        {
            myRotatePoint.transform.right = -Vector2.MoveTowards(transform.up, offset, rotationSpeed);
        }
    }
}
