using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IDamageable<float>
{
    [SerializeField] PlayerMovement myMovement = null;
    [SerializeField] PlayerRotation myRotation = null;

public float health, maxHealth;
  
  public HealthBar healthBar;
  
  public void TakeDamage(){
    // Use your own damage handling code, or this example one.
    
    health -= Mathf.Min( Random.value, health / 4f );            
    healthBar.UpdateHealthBar();

  }
  
    private void FixedUpdate()
    {
        myMovement.HandleMovement();
        myRotation.HandleRotating();
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage();
        }
    }

    public void TakeDamage(float amount)
    {
        Debug.Log($"Uderzono Gracza za ${amount}");
    }
}
