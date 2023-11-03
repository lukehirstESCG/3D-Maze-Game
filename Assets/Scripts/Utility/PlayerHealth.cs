using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float health;
    public float maxHealth = 100;
    public EndGame gameOver;
    public Image healthBar;
    public GameObject target;

    public void Start()
    {
        health = 100;
    }

    public void Update()
    {
        UpdateHealth();
    }

    public void UpdateHealth()
    {
        healthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 100);
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        Debug.Log("OW!");
        if (health <= 0)
        {
            Destroy(target);
            gameOver.PacmanFail.SetActive(true);
        }
    }
}
