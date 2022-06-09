using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] PlayerMovement myMovement;
    
    void Update()
    {
        myMovement.HandleMovement();
    }
}
