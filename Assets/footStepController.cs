using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footStepController : MonoBehaviour
{

    public AudioSource footstep;
    public AudioClip[] footstepSound;
    private int b;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void PlayFootStepSound()
    {
        /* int a = Random.Range(0, footstepSound.Length);
         while (a==b)
         {
         a = Random.Range(0, footstepSound.Length);
         }
         footstep.clip = footstepSound[a];
         b = a; */

        footstep.mute = false;
    }
    public void StopFootStep()
    {
        footstep.mute = true;
    }
}
