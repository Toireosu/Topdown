using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public float maxHealth;
    public float minHealth;
    public float currentHealth;

    float hp;

    public Slider healthBar;

    private void Start()
    {
        hp = GetComponent<Health>().maxHp;
        maxHealth = hp;
        healthBar.interactable = false;
        healthBar.maxValue = maxHealth;
    }

    private void Update()
    {
        currentHealth = hp;
        Slider();
        //Testa slidern
        RemoveHealth();
    }

    void Slider()
    {
        healthBar.value = currentHealth;
    }

    void RemoveHealth()
    {
        if (Input.GetKey(KeyCode.H))
        {
            currentHealth -= 0.05f;
        }
    }

}
