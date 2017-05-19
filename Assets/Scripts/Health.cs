using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    public float maxHealth;
    public float minHealth;
    public float currentHealth;

    public Slider healthBar;

    private void Start()
    {
        healthBar.interactable = false;
        currentHealth = maxHealth;
        healthBar.maxValue = maxHealth;
    }

    private void Update()
    {
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
