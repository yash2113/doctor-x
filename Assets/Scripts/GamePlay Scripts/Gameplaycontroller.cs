using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gameplaycontroller : MonoBehaviour
{
    public static Gameplaycontroller instance;

    [SerializeField]
    private Text enemyKillCountTxt;

    private int enemyKillCount;

    private void Awake()
    {
        if(instance == null)
            instance = this;
    }
    public void EnemyKilled()
    {
        enemyKillCount++;
        enemyKillCountTxt.text = "Enemy Kill - " + enemyKillCount;
    }
    public void RestartGame()
    {
        Invoke("Restart", 3f);
    }

    void Restart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("End");
    }

}
