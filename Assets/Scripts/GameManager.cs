using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject music;

    public GameObject gameWinUI;
    public GameObject gameLoseUI;

    private IEnumerator coroutine;

    void Start()
    {
        coroutine = Timer();

        StartCoroutine(coroutine);
    }

    public void Win()
    {
        music.SetActive(false);
        gameWinUI.SetActive(true);
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(120f);
        music.SetActive(false);
        gameLoseUI.SetActive(true);
    }
}
