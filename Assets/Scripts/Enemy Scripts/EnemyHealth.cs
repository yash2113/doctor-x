using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField]
    private float health = 100f;

    [SerializeField]
    private GameObject boost;

   // [SerializeField]
    //private Transform boostTracker,spawnPosition;

    private Enemy enemyScript;
    [SerializeField]
    private Slider enemyHealthSlider;

    private void Awake()
    {
        enemyScript = GetComponent<Enemy>();
        
    }
    private void Update()
    {
       // boostTracker.position = spawnPosition.position;
    }

    public void TakeDamage(float damageAmount)
    {
        if(health<=0)
        {
            return;
        }

        health -= damageAmount;
        if(health <= 0f)
        {
            health = 0f;


            //kill the enemy
            enemyScript.EnemyDied();

            EnemySpawner.instance.EnemyDied(gameObject);
            
            //HealthBoost.instance.BoostTrue();
            Gameplaycontroller.instance.EnemyKilled();
            AudioCOntroller.instance.EnemyKillSound();

        }

        enemyHealthSlider.value = health;
    }
    
    
       
    
}
