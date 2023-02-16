using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{
    [SerializeField] GameObject player;

    [SerializeField] List<GameObject> checkpoints;

    [SerializeField] Vector3 vectorPoint;

    [SerializeField] float dead;

    void Update()
    {
        if (player.transform.position.y < -dead)
        {
            player.transform.position = vectorPoint;
        }
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            player.transform.position = vectorPoint;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        vectorPoint = player.transform.position;
    }
}
