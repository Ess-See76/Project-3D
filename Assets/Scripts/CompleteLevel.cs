using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteLevel : MonoBehaviour
{
    public GameManager gameManager;

    [SerializeField] GameObject music;

    [SerializeField] GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            music.SetActive(false);
            gameManager.Win();
        }
    }

}