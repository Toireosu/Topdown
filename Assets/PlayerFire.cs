using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour {
    
    //public GameObject currWeapon;
    public GameObject[] weapons;
	PlayerAim.Direction direction;
    private KeyCode[] keyCodes = {
         KeyCode.Alpha1,
         KeyCode.Alpha2,
         KeyCode.Alpha3,
         KeyCode.Alpha4,
         KeyCode.Alpha5,
         KeyCode.Alpha6,
         KeyCode.Alpha7,
         KeyCode.Alpha8,
         KeyCode.Alpha9,
     };
    public int currWeapon = 0;

    private void Start()
    {
        direction = GetComponent<PlayerAim>().direction;
    }

    void Update() {

        // Renders only the current weapon
        for (int i = 0; i < weapons.Length; i++)
        {
            weapons[i].SetActive(false);
        }
        weapons[currWeapon].SetActive(true);

        direction = GetComponent<PlayerAim>().direction;
        if (Input.GetButtonDown("Fire1"))
        {
            weapons[currWeapon].GetComponent<Weapon>().Fire(direction);
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            currWeapon = (currWeapon + 1 == weapons.Length) ? 0 : ++currWeapon;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            currWeapon = (currWeapon == 0) ? weapons.Length - 1 : --currWeapon;
        }
        for (int i = 0; i < keyCodes.Length; i++)
        {
            if (Input.GetKeyDown(keyCodes[i]))
            {
                if (i < weapons.Length)
                    currWeapon = i;
                
            }
        }
    }
}
