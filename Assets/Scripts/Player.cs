using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] PlayerMovement myMovement = null;
    [SerializeField] PlayerHandsRotation myHands = null;

    void Update()
    {
        myMovement.HandleMovement();
        myMovement.HandleFlipping();
        myHands.HandleRotating(myMovement.isFacingRight);
    }
}
