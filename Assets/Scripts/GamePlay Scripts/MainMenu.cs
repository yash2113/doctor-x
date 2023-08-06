using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{   
    [SerializeField]
    private Slider sound;
    public AudioSource audiocontroller;

    private void Update()
    {
        sound.value = audiocontroller.volume;
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Gameplay");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
