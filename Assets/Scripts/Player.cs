using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Camera m_MainCam;

    public float Speed = 10f;

    public float SwipeSpeed = 120f;

    private Transform localTrans;

    private Vector3 lastMousePos;

    private Vector3 mousePos;

    private Vector3 newPosForTrans;


    void Start()
    {
        localTrans = GetComponent<Transform>();
    }

    void Update()
    {

          

        if (Input.GetMouseButton(0))
        {
            mousePos = m_MainCam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 30f));

            float xDiff = mousePos.x - lastMousePos.x;

            newPosForTrans.x = localTrans.position.x + xDiff * Time.deltaTime * SwipeSpeed; ;
            newPosForTrans.y = localTrans.position.y;
            newPosForTrans.z = localTrans.position.z;

            localTrans.position = newPosForTrans + localTrans.forward * Speed * Time.deltaTime; 

            lastMousePos = mousePos;

        }
       

    }
}
