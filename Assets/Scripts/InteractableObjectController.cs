﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObjectController : MonoBehaviour
{
    public Animator animator;
    public GameObject lightSource;
    public bool ifOn;
    // Start is called before the first frame update
    void Start()
    {
       // animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void ClickOn()
    {
        if (GetComponent<InteractableObjectName>().Alternative)
        {
            if (GetComponent<InteractableObjectName>().CurrentStateNumber == 0)
            {
                lightSource.SetActive(true);
                GetComponent<InteractableObjectName>().CurrentStateNumber = 1;
            }
            else
            {
                lightSource.SetActive(false);
                GetComponent<InteractableObjectName>().CurrentStateNumber = 0;
            }
        }
        ifOn = !ifOn;
        animator.SetBool("On",ifOn);
    }
}