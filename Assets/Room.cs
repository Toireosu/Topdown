using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour {

    public Light[] lights;
	
	void Start () {
        foreach (Light light in lights)
        {
            light.enabled = false;
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            foreach (Light light in lights)
            {
                light.enabled =true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            foreach (Light light in lights)
            {
                light.enabled = false;
            }
        }
    }
}
