using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    Canvas canvas;
    Slider healthBar;
    GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        healthBar = gameObject.GetComponent<Slider>();

        transform.SetParent(canvas.transform);

        GetComponent<RectTransform>().position = new Vector3(100, 582, 0);

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
