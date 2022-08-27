using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{

    public bool isOnGround = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isOnGround = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isOnGround = false;
    }
}
