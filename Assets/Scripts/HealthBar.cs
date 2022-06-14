using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour, IDamageable<float>
{
    [SerializeField] Canvas healthBarCanvas = null;
    [SerializeField] Vector2 healthBarOffset = Vector2.zero;
    [SerializeField] float maxHealth = 1f;
    float currentHealth = 0;

    Canvas myCanvas = null;

    private void Awake()
    {
        myCanvas = GameObject.Instantiate(healthBarCanvas, transform.position, Quaternion.identity);
        myCanvas.transform.SetParent(gameObject.transform);

        currentHealth = maxHealth;    
    }

    private void Update()
    {
        // TODO:
        // Dodać Offset jako osobną Funkcję lub do Awake
        // myCanvas.GetComponentInChildren<GameObject>().transform.position = healthBarOffset;
        // Debug.Log(myCanvas);
        // Debug.Log(myCanvas.GetComponentInChildren<RectTransform>().localPosition);
        // var pos = myCanvas.GetComponentInChildren<RectTransform>().position;
        // pos = healthBarOffset;
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        Debug.Log($"Uderzono {gameObject} za {amount}");
    }

    public void Heal(float amount)
    {
        currentHealth += amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        Debug.Log($"Uleczono {gameObject} za {amount}");
    }
}
