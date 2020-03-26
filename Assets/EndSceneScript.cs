using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndSceneScript : MonoBehaviour
{
    public Animator ani;
    public TextMeshProUGUI text;
    public GameObject dot;
    public GameObject player;
    public bool rotate = false;

    private float yawStart;
    private float pitchStart;
    private float t = 0;
    
    public float speed = 1.0F;
    private Vector3 playerPosition;
    private float journeyLength;
    private float target;
    public GameObject quitText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (quitText.activeSelf == true)
        {
            if (Input.anyKeyDown)
            {
                Application.Quit();
            }
        }


        if (rotate)
        {
            FirstPersonController.yaw = Mathf.Lerp(yawStart,target,t);
            FirstPersonController.pitch = Mathf.Lerp(pitchStart,-5,t);

            //player.transform.position = new Vector3(Mathf.Lerp(playerPosition.x, -1.7844f,t), Mathf.Lerp(playerPosition.y, -0.40135f, t), Mathf.Lerp(playerPosition.z, 2.08907f, t));

           // float distCovered = (Time.time - startTime) * 0.3f;

            // Fraction of journey completed equals current distance divided by total distance.
           // f = distCovered / journeyLength;

           // player.transform.position = Vector3.Lerp(playerPosition,new Vector3(-1.7844f,-0.40135f,2.08907f),f);
            t += 0.3f* Time.deltaTime;
            Debug.Log("move camera");
        }
    }

    public void DisableAnimator()
    {
        ani.enabled = false;
    }

    public void CameraLerp()
    {
        rotate = true;
        
        pitchStart = FirstPersonController.pitch;
        yawStart = FirstPersonController.yaw;
        target = Mathf.RoundToInt(yawStart/360) * 360;
        if (yawStart - target > 0)
        {
            target += 180;
            Debug.Log("large");
        }
        else
        {
            target -= 180;
            Debug.Log("small");
        }
        
        playerPosition = player.transform.position;
       // journeyLength = Vector3.Distance(player.transform.position, new Vector3(-1.7844f, -0.40135f, 2.08907f));
    }

    public void EndText()
    {

        text.enabled = true;
        quitText.SetActive(true);
    }

    public void DisableDot()
    {
        dot.SetActive(false);
    }
}
