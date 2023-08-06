using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCOntroller : MonoBehaviour
{
    public static AudioCOntroller instance;

    [SerializeField]
    private AudioClip shootSound;

    [SerializeField]
    private AudioClip enemyKillSound;

    [SerializeField]
    private AudioClip playerKillSound;

    private void Awake()
    {
        if(instance == null)    
            instance = this;
    }

    public void PlayerShootSound()
    {
        AudioSource.PlayClipAtPoint(shootSound,transform.position);
    }
    public void EnemyKillSound()
    {
        AudioSource.PlayClipAtPoint(enemyKillSound, transform.position);
    }
    public void PlayerKillSound()
    {
        AudioSource.PlayClipAtPoint(playerKillSound, transform.position);
    }
}
