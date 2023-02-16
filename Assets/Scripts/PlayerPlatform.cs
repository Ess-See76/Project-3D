using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatform : MonoBehaviour
{
    // Sticks player to moving platform, will move with platform instead of player having to stay on
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            // Makes object parent of player
            collision.gameObject.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            // Removes player from parent of object
            collision.gameObject.transform.SetParent(null);
        }
    }
}
