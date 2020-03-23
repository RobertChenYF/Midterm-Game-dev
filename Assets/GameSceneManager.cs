using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    public static GameObject Player;
    public static Animator animator;
    public static AudioSource elevatorSound;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void LoadScene(int a)
    {
        SceneManager.LoadScene(a, LoadSceneMode.Additive);
        elevatorSound.Pause();
        animator.speed = 0;
        Player.SetActive(false);
    }

    [System.Obsolete]
    public static void UnLoadScene(int a)
    {
        Player.SetActive(true);
        elevatorSound.Play();
        animator.speed = 1;
        SceneManager.UnloadScene(a);
    }
}
