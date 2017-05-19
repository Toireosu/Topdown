using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAim : MonoBehaviour
{
    public enum Direction { LEFT, RIGHT }
    public Direction direction;
    GameObject arm1;
    GameObject arm2;

    // For the arms positions
    Transform armLeft;
    Transform armRight;
    public Transform pos1;
    public Transform pos2;
    public GameObject currWeapon;

    public Transform weaponHolder;
    [HideInInspector]
    public float angle;
    // Player Sprite
    SpriteRenderer sprite;

    void Start()
    {
        direction = Direction.LEFT;
        // Get the arm sprites
        arm1 = transform.Find("arm1").gameObject;
        arm2 = transform.Find("arm2").gameObject;
        // Get the arm position points
        armLeft = transform.Find("leftArm");
        armRight = transform.Find("rightArm");
        // Getting the players sprite renderer
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        PlayerFire playerFire = GetComponent<PlayerFire>();
        currWeapon = playerFire.weapons[playerFire.currWeapon];
        // Getting mouseposition
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Rotation calculation
        float adjacent = mousePosition.x - transform.position.x;
        float opposite = mousePosition.y - transform.position.y;
        angle = Mathf.Atan2(opposite, adjacent);
        angle = Mathf.Rad2Deg * angle;

        if (adjacent > 0)
        {
            direction = Direction.RIGHT;
            // Fliping the 'firing arm'
            arm1.GetComponent<SpriteRenderer>().flipX = true;
            // Changing position of arms
            arm1.transform.position = armLeft.position;
            arm2.transform.position = armRight.position;
            sprite.flipX = true;
            currWeapon.transform.position = pos2.position;
            currWeapon.GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            direction = Direction.LEFT;
            // Fliping the 'firing arm'
            arm1.GetComponent<SpriteRenderer>().flipX = false;
            angle += 180;
            // Changing position of arms
            arm1.transform.position = armRight.position;
            arm2.transform.position = armLeft.position;
            sprite.flipX = false;
            currWeapon.transform.position = pos1.position;
            currWeapon.GetComponent<SpriteRenderer>().flipX = false;
        }


        arm1.transform.rotation = Quaternion.Euler(0, 0, angle);

    }
}
