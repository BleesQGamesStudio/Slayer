using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IDamageable<float>
{
    [SerializeField] PlayerMovement myMovement = null;
    [SerializeField] PlayerRotation myRotation = null;

    private void FixedUpdate()
    {
        myMovement.HandleMovement();
        myRotation.HandleRotating();
    }

    public void TakeDamage(float amount)
    {
        Debug.Log($"Uderzono Gracza za ${amount}");
    }
}
