using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 100f;

    Camera myCamera = null;

    private void Awake()
    {
        myCamera = Camera.main;
    }

    public void HandleRotating()
    {
        Vector2 mousePosition = Input.mousePosition;
        Vector2 worldPosition = myCamera.ScreenToWorldPoint(mousePosition);
        // Vector2 offset = new Vector2(worldPosition.x - transform.position.x, worldPosition.y - transform.position.y);
        // transform.up = Vector2.MoveTowards(transform.up, offset, rotationSpeed);

        // float angle = AngleBetweenTwoPoints(transform.position, worldPosition);
        // transform.LookAt(mousePosition);




        // Vector2 pos = Camera.main.WorldToScreenPoint(transform.position);
        // Vector2 worldPosition = Input.mousePosition - pos;
        Vector2 direction = worldPosition - (Vector2)transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle - 90f, Vector3.forward);
    }
}
