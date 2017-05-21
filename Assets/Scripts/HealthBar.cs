using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    Canvas canvas;
    Slider healthBar;
    GameObject player;
    RectTransform sliderPos;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        healthBar = gameObject.GetComponent<Slider>();

        transform.SetParent(canvas.transform);

        sliderPos = GameObject.Find("HealthBarPos").GetComponent<RectTransform>();
        GetComponent<RectTransform>().position = sliderPos.position;

        healthBar.interactable = false;
        healthBar.maxValue = player.GetComponent<Health>().maxHp;
    }

    private void Update()
    {
        Slider();
    }

    void Slider()
    {
        healthBar.value = player.GetComponent<Health>().currHp;
    }
}
