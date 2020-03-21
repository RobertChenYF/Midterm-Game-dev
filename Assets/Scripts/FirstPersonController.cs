using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonController : MonoBehaviour
{
    private float xMove;
    private float yMove;
    //private bool jump;
    public float speed;
    public float gravity;
   //public float jumpSpeed;
    private Vector3 moveDirection;
    CharacterController characterController;
    public GameObject cameraOfThis;
    public Animator animator;
    public float speedH = 2.0f;
    public float speedV = 2.0f;
    private float currentSpeed;
    private float yaw = 0.0f;
    private float pitch = 0.0f;

    

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        xMove = Input.GetAxis("Horizontal");
        yMove = Input.GetAxis("Vertical");
        //jump = Input.GetButton("Jump");

        currentSpeed = Mathf.Abs(xMove) + Mathf.Abs(yMove);
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

       // yaw = Mathf.Clamp(yaw, -90f, 90f);
       
        pitch = Mathf.Clamp(pitch, -70f, 60f);
        


       cameraOfThis.transform.localRotation= Quaternion.Euler(pitch,0,0);
        transform.eulerAngles = new Vector3(0, yaw, 0.0f);
        moveDirection = yMove * transform.forward + xMove * transform.right;
        moveDirection *= speed;
        
        
      //  if (characterController.isGrounded)
      //  {
       //     moveDirection.y = jumpSpeed;
            
      //  }
       
        moveDirection.y -= gravity;
        animator.SetFloat("Speed", currentSpeed);
        characterController.Move(moveDirection*Time.deltaTime);
        //characterController.
        
    }

    void FixedUpdate()
    {
        //moveDirection = new Vector3(xMove, 0, yMove);
        
        
    }


   


}
