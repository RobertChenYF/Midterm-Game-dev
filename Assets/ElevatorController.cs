using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ElevatorController : MonoBehaviour
{
    private Animator animator;
    public GameObject Player;
    public Animator elevatorDoor;
    public AudioSource elevatorSound;
    public GameObject buttonRing;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        GameSceneManager.animator = animator;
        GameSceneManager.elevatorSound = elevatorSound;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void LoadScene(int sceneNumber)
    {
        //Time.timeScale = 0;
        //SceneManager.LoadScene(sceneBuildIndex: sceneNumber, LoadSceneMode.Additive);
        GameSceneManager.LoadScene(sceneNumber);
       
    }
    public void OpenDoor()
    {
        elevatorDoor.SetTrigger("open");
    }
    public void PlaySound()
    {
        elevatorSound.Play();
    }
    public void StopPlaySound()
    {
        elevatorSound.Stop();
    }
    public void DisableButton()
    {
        buttonRing.SetActive(false);
    }
}
