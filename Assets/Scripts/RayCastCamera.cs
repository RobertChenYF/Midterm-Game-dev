using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RayCastCamera : MonoBehaviour
{
    public float castingDistance = 4;
    RaycastHit objectHit;
    private int interactableLayer;
    public GameObject uiText;
    public TextMeshProUGUI uiTextContent;

    // Start is called before the first frame update
    void Start()
    {
        interactableLayer = LayerMask.GetMask("InteractableObject");
    }

    // Update is called once per frame
    void Update()
    {
        Ray myRay = new Ray(transform.position, transform.forward);

        Debug.DrawRay(myRay.origin, myRay.direction * castingDistance, Color.magenta);

        if (Physics.Raycast(myRay,out objectHit ,castingDistance,interactableLayer))
        {
            uiText.SetActive(true);


             uiTextContent.text = objectHit.collider.gameObject.GetComponent<InteractableObjectName>().showText[objectHit.collider.gameObject.GetComponent<InteractableObjectName>().CurrentStateNumber];
             Debug.Log(objectHit.collider.gameObject.GetComponent<InteractableObjectName>().showText[0]);
            if (Input.GetMouseButtonDown(0))
            {
            objectHit.collider.gameObject.GetComponent<InteractableObjectController>().ClickOn();
            }

            
            
        }
        else
        {
          uiText.SetActive(false);
        }
    }
}
