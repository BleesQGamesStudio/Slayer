using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    //  public Image healthBarImage;
  public Player player;
  public void UpdateHealthBar() {
    // healthBarImage.fillAmount = Mathf.Clamp(player.health / player.maxHealth, 0, 1f);
  }
}

