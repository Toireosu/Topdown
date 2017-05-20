using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthBar;

    private void Start()
    {
        healthBar.interactable = false;
        healthBar.maxValue = GetComponent<Health>().maxHp;
    }

    private void Update()
    {
        Slider();
        //Testa slidern
    }

    void Slider()
    {
        healthBar.value = GetComponent<Health>().currHp; ;
    }

}
