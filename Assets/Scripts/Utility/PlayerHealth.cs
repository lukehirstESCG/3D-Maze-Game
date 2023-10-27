using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float health;
    public float maxHealth = 100;
    public EndGame gameOver;
    public Image healthBar;
    public GameObject target;

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
            Time.timeScale = 0;
            gameOver.PacmanFail.SetActive(true);
        }
    }
}
