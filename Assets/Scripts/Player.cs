using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] PlayerMovement myMovement = null;
    [SerializeField] PlayerRotation myRotation = null;
  
    private void FixedUpdate()
    {
        myMovement.HandleMovement();
        myRotation.HandleRotating();
    }
}
