using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 positionOffset = new Vector3(0, 5, -5);

    private float _angleY;
    private float _angleX;
    public float rotationspeed = 2f;
    
    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + positionOffset;
        transform.LookAt(target);

        _angleX += Input.GetAxis("Mouse X") * rotationspeed;
        _angleY += Input.GetAxis("Mouse Y") * rotationspeed;

        Quaternion rotation = Quaternion.Euler(_angleY, _angleX, 0);
        Vector3 position = rotation * positionOffset + target.transform.position;

        transform.rotation = rotation;
        transform.position = position;
    }
}
