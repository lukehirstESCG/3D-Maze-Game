using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public Image healthBar;

    private void Start()
    {
        maxHealth = health;
    }

    public void Update()
    {
        UpdateHealth();
    }

    void UpdateHealth()
    {
        healthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 100);

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
