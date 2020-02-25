using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastRoomba : MonoBehaviour
{

    public float castingDistance = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray roombaRay = new Ray(transform.position, transform.forward);

        Debug.DrawRay(roombaRay.origin, roombaRay.direction*castingDistance,Color.green);

        transform.Translate(0,0,Time.deltaTime);

        if (Physics.Raycast(roombaRay,castingDistance))
        {
            int randomNumber = Random.Range(0,100);
            if (randomNumber < 50)
            {
                transform.Rotate(0, 90, 0);
            }
            else
            {
                transform.Rotate(0,-90,0);
            }
            
        }
    }
}
