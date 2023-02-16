using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject gameWinUI;
    public GameObject gameLoseUI;

    public void Win()
    {
        gameWinUI.SetActive(true);
    }

    public void Lose()
    {
        gameLoseUI.SetActive(true);
    }
}
