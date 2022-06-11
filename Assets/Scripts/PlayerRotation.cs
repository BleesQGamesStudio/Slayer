using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    Camera myCamera = null;

    private void Awake()
    {
        myCamera = Camera.main;
    }

    public void HandleRotating()
    {
        Vector2 mousePosition = Input.mousePosition;
        Vector2 worldPosition = myCamera.ScreenToWorldPoint(mousePosition);
        Vector2 direction = worldPosition - (Vector2)transform.position;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle - 90f, Vector3.forward);
    }
}
