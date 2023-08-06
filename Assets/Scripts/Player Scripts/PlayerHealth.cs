using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    private float health = 100f;

    private PlayerMovement playerMovement;

    [SerializeField]
    private Slider healthSLider;

    private void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

    public void TakeDamage(float damageAmount)
    {
        if(health<=0f)
        {
            return;
        }
        health -= damageAmount;
        if(health <= 0f)
        {
            AudioCOntroller.instance.PlayerKillSound();
            playerMovement.PlayerDied();
            

            Gameplaycontroller.instance.RestartGame();
           
        }

        healthSLider.value = health;
    }
}
