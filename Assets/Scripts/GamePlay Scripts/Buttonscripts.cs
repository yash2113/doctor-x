using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttonscripts : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("Gameplay");
    }
}
