using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastCamera : MonoBehaviour
{
    public float castingDistance = 4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray myRay = new Ray(transform.position, Vector3.forward);

        Debug.DrawRay(myRay.origin, myRay.direction * castingDistance, Color.magenta);

        if (Physics.Raycast(myRay, castingDistance))
        {
            Debug.Log(myRay);
        }
    }
}
