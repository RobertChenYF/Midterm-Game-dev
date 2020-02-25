using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastGrounded : MonoBehaviour
{
    // Start is called before the first frame update
    public float castingDistance = 4;

    // Update is called once per frame
    void Update()
    {
        Ray myRay = new Ray(transform.position, Vector3.down);

        Debug.DrawRay(myRay.origin,myRay.direction*castingDistance,Color.magenta);

        if (Physics.Raycast(myRay,castingDistance))
        {
            Debug.Log("hit ground");
        }
        else
        {
            transform.Rotate(new Vector3(0,5f,0),Space.Self);
        }
    }
}
