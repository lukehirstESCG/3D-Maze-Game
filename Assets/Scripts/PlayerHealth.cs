using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float health;
    public float maxHealth = 100;
    public Image healthBar;

    private void Start()
    {
        health = maxHealth;
    }

    public void Update()
    {
        UpdateHealth();
    }

    void UpdateHealth()
    {
        healthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
