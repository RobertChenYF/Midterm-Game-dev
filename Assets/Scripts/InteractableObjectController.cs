using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractableObjectController : MonoBehaviour
{
    public Animator animator;
    public GameObject lightSource;
    public bool ifOn;
    public bool Terminal;
    private bool pressed = false;
    public string TriggerName;
    public bool switchScene = false;
    // Start is called before the first frame update
    void Start()
    {
       // animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [System.Obsolete]
    public void ClickOn()
    {

        if (switchScene)
        {
            GameSceneManager.UnLoadScene(2);
        }
        else if (GetComponent<InteractableObjectName>().Alternative)
        {
            if (Terminal == false)
            {
            if (GetComponent<InteractableObjectName>().CurrentStateNumber == 0)
            {
                lightSource.SetActive(true);
                GetComponent<InteractableObjectName>().CurrentStateNumber = 1;
                    ifOn = !ifOn;
                    if (animator != null)
                    {
                        animator.SetBool(TriggerName, ifOn);
                    }
                }
            else
            {
                lightSource.SetActive(false);
                GetComponent<InteractableObjectName>().CurrentStateNumber = 0;
                    ifOn = !ifOn;
                    if (animator != null)
                    {
                        animator.SetBool(TriggerName, ifOn);
                    }
                }
            }
            else
            {
                if (pressed == false)
                {
                    if (GetComponent<InteractableObjectName>().CurrentStateNumber == 0)
                    {
                        lightSource.SetActive(true);
                        GetComponent<InteractableObjectName>().CurrentStateNumber = 1;
                        pressed = true;

                        if (animator != null)
                        {
                            animator.SetTrigger(TriggerName);
                        }
                    }
                    else
                    {
                        lightSource.SetActive(false);
                        GetComponent<InteractableObjectName>().CurrentStateNumber = 0;
                        pressed = true;
                    }
                }
            }
            
        }
        
        
    }
}
