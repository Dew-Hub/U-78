using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    private void LateUpdate()
    {
        Vector3 desiredPositon = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPositon, smoothSpeed);
        transform.position = smoothedPosition;
    }
}
