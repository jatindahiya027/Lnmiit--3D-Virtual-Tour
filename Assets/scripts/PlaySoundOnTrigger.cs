using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnTrigger : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;
    public AudioSource _audioSource;
    public AudioClip _audioClip;
    int i = 0;
    private void OnTriggerStay(Collider other)
    {
        if (i == 0)
        {
            audioSource.PlayOneShot(audioClip);
           // Debug.Log("played audio");
            i = 1;
        }
        if (audioSource.isPlaying)
        {
            _audioSource.volume = 0.01f;
        }
        else
        {
            _audioSource.volume = 0.03f;
        }
        if (i == 1 && !audioSource.isPlaying)
        {
           
            
            if (Input.GetKeyDown(KeyCode.I))
            {
                audioSource.PlayOneShot(audioClip);
            }
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        _audioSource.volume = 0.03f;
    }
   
}
