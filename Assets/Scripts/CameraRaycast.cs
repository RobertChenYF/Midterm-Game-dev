using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRaycast : MonoBehaviour
{
    public float maxRayDistamce;
    public GameObject paintBrush;
    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray camray = Camera.main.ScreenPointToRay(Input.mousePosition);

        Debug.DrawRay(camray.origin, camray.direction * maxRayDistamce, Color.cyan);

        RaycastHit hitObject;

        if (Physics.Raycast(camray,out hitObject, maxRayDistamce))
        {
            paintBrush.transform.position = hitObject.point;

            if (Input.GetMouseButton(0))
            {
                //Instantiate(paintBrush, hitObject.point ,Quaternion.identity);
                GameObject paint =Instantiate(paintBrush,hitObject.point, Quaternion.identity);
                paint.transform.SetParent(canvas.transform);

            }
            hitObject.transform.Rotate(new Vector3 (35*Time.deltaTime,0,0));
        }
    }
}
