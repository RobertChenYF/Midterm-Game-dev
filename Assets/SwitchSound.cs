using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchSound : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource audioSource;
    [SerializeField] private AudioClip[] switchSounds;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayOnSound()
    {
        audioSource.clip = switchSounds[0];
        audioSource.Play();
    }

    public void PlayOffSound()
    {
        audioSource.clip = switchSounds[1];
        audioSource.Play();
    }

}
