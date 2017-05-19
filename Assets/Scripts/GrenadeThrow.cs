using UnityEngine;

public class GrenadeThrow : MonoBehaviour
{

    public GameObject grenade;
    public Transform pos1;
    public Transform pos2;
    public Vector3 mousePosOnThrow;
    int grenadeCount = 1000;

    private void Update()
    {
        ThrowGrenade();
    }

    void ThrowGrenade()
    {
        if (Input.GetKeyDown(KeyCode.G) && grenadeCount >= 1)
        {
            Transform grenadePos = pos1;

            if (GetComponent<PlayerAim>().direction == PlayerAim.Direction.RIGHT)
            {
                grenadePos = pos2;
            }

            Instantiate(grenade, grenadePos.position, Quaternion.identity);
            grenadeCount--;
            mousePosOnThrow = Input.mousePosition;
        }

        
    }
}
